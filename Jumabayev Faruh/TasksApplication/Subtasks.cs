using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksApplication
{
    public class Subtasks:MainClass
    {
        public int TaskLink { get; set; }
        public bool IsFinished { get; set; }

        //++
        public void Update()
        {
            //connectionString

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            //SqlCommand cmd = new SqlCommand(UPDATE Categories SET [description]= @description WHERE [id]=@id;" , sqlConnection);

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "UPDATE Subtasks SET [is_finished]=@is_finished ,[description]= @description WHERE [id]=@id; ";

            cmd.Parameters.AddWithValue("@is_finished", IsFinished);
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
                MessageBox.Show("Ошибка обновления подзадания. " + ex.Message);
            }
        }

        //++
        public void Add()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "INSERT Subtasks (task_link, is_finished , description) VALUES(@task_link, @is_finished , @description) ;  ";


            cmd.Parameters.AddWithValue("@task_link", TaskLink);
            cmd.Parameters.AddWithValue("@is_finished", IsFinished);
            cmd.Parameters.AddWithValue("@description", Description);
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
                MessageBox.Show("Ошибка добавления под задания " + ex.Message);
            }

            //а теперь считаем id который автоматичски дался базой данных

            try
            {
                //cmd.CommandText = "SELECT id FROM Subtasks WHERE " +
                //                  "[task_link]=@task_link ," +
                //                  "[is_finished]=@is_finished ," +
                //                  "[description]= @description ";

                cmd.CommandText = "SELECT * FROM Subtasks ;";
                //cmd параметры уже есть (выше)
                sqlConnection.Open();

                SqlDataReader sqlReader = cmd.ExecuteReader();
                while (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        Id = (int)sqlReader.GetValue(3);
                    }
                    sqlReader.NextResult();
                }

                sqlReader.Close();
                cmd.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не получилось узнать ID вновь добавленного под Задания! " + ex.Message);
            }
            //

        }

        //++
        public void Delete()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "DELETE Subtasks WHERE [id]=@id; ";

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
                MessageBox.Show("Ошибка удаления под задания. " + ex.Message);
            }
        }

    }
}
