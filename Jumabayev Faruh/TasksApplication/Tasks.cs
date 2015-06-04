using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksApplication
{
    public class Tasks:MainClass
    {

        /// <summary>
        /// Содержит ссылку на категорию к которой относится задача
        /// </summary>
        public int CategoryLink { get; set; }
        /// <summary>
        /// Задача выполнена ?
        /// </summary>
        public bool IsFinished { get; set; }
        /// <summary>
        /// Дата задания
        /// </summary>
        public DateTime Date { get; set; }
        
        /// <summary>
        /// список моих подзадач
        /// </summary>
        public List<Subtasks> Subtask = new List<Subtasks>();

        //категория задания
        public Categories Category = new Categories();

        public void Fill_Categories()
        {
            SqlConnection sqlConnection;
            SqlCommand sqlCmd;
            string sql_query = "select * from Categories where id=" + CategoryLink + ";";


            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql_query, sqlConnection);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                while (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        Category.Description = (string) sqlReader.GetValue(0);
                        Category.Id = (int) sqlReader.GetValue(1);
                    }
                    sqlReader.NextResult();
                }

                sqlReader.Close();
                sqlCmd.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! "+ex.Message);
                
            }
        }
        public void Fill_Subtask()
        {
            SqlCommand sqlCmd;

            string sql_query = "select * from Subtasks where task_link=" + Id + ";";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlCmd = new SqlCommand(sql_query, sqlConnection);
            try
            {
                sqlConnection.Open();

                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                while (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {

                       Subtask.Add(new Subtasks()
                       {
                           TaskLink = (int)sqlReader.GetValue(0),
                           IsFinished = (bool)sqlReader.GetValue(1),
                           Description =(string)sqlReader.GetValue(2),
                           Id = (int)sqlReader.GetValue(3)
                       });
                    }
                    sqlReader.NextResult();
                }

                sqlReader.Close();
                sqlCmd.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Fill(int id)
        {
            
            SqlConnection sqlConnection ;
            SqlCommand sqlCmd ;
            string sql_query = "select * from Tasks where id =" + id;
            sqlConnection  = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql_query, sqlConnection );
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                
                    while (sqlReader.Read())
                    {
                        CategoryLink = Convert.ToInt32(sqlReader.GetValue(0));
                        IsFinished = Convert.ToBoolean(sqlReader.GetValue(1));
                        Date = Convert.ToDateTime(sqlReader.GetValue(2));
                        Description = sqlReader.GetValue(3).ToString();
                        Id = Convert.ToInt32(sqlReader.GetValue(4));
                    }
                

                sqlReader.Close();
                sqlCmd.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        //++обновления в базу
        public void Update()
        {


            //проверим если все подзадания выполнены, то установим задание выполненым.
            int count = 0;

            //посчитаем колиичество выполненых задач
            foreach (var val in Subtask)
            {
                if (val.IsFinished) { count++; }
            }

            //если общее количество подзаданий совпадает с количетсвом подсчитанном в count
            //и количество выполненых подзадач больше нуля ,считаем задачу выполненой

            if (Subtask.Count == count && count != 0)
                IsFinished = true;
            else 
                IsFinished = false; 

        
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "UPDATE Tasks SET " +
                              "[category_link]=@category_link ," +
                              "[is_finished]=@is_finished ," +
                              "[date]=@date," +
                              "[decription]= @description " +

                              "WHERE [id]=@id; ";

            cmd.Parameters.AddWithValue("@category_link", CategoryLink);
            cmd.Parameters.AddWithValue("@is_finished", IsFinished);
            cmd.Parameters.AddWithValue("@date", Date.ToShortDateString());
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();

                cmd.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления задания " + ex.Message);
            }
        }
        //++
        public void Add()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "INSERT Tasks (category_link, is_finished , date , decription) VALUES(@category_link, @is_finished, @date , @decription) ;  ";


            cmd.Parameters.AddWithValue("@category_link", CategoryLink);
            cmd.Parameters.AddWithValue("@is_finished", IsFinished);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@decription", Description);

            //cmd.Parameters.AddWithValue("@id", Id);
            cmd.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();

                cmd.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления задания " + ex.Message);
            }

            //а теперь считаем id который автоматичски дался базой данных

            try
            {
                //cmd.CommandText = "SELECT id FROM Tasks WHERE " +
                //                  "[category_link]=@category_link ," +
                //                  "[is_finished]=@is_finished ," +
                //                  "[date]=@date," +
                //                  "[decription]= @decription ;";


                cmd.CommandText = "SELECT * FROM Tasks ;";
                
                //cmd параметры уже есть (выше)
                sqlConnection.Open();


                SqlDataReader sqlReader = cmd.ExecuteReader();
                while (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        Id = (int)sqlReader.GetValue(4);
                        //MessageBox.Show(Id.ToString());
                    }
                    sqlReader.NextResult();
                }

                sqlReader.Close();
                cmd.Dispose();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не получилось узнать ID вновь добавленного Задания! "+ex.Message);
            }

            //не забываем заполнить категрию по имеющемуся id категории
            
            Fill_Categories();

        }

        //++
        public void Delete()
        {
            foreach (var subtsk in Subtask)
            {
                subtsk.Delete();
            }


            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "DELETE Tasks WHERE [id]=@id; ";

            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();

                cmd.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления задания. " + ex.Message);
            }
        }

    }
}
