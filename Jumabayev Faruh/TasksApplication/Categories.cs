using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksApplication
{
    public class Categories : MainClass
    {
        //++
        public void Update()
        {
            
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "UPDATE Categories SET [description]= @description WHERE [id]=@id; ";

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
                MessageBox.Show("Ошибка обновления категории. "+ ex.Message);
            }
            
        }

        //++данная функция лишь ля создания новой! категории
        public void Add()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "INSERT Categories  (description) VALUES( @description) ;  ";

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
                MessageBox.Show("Ошибка добавления категории " + ex.Message);
            }

            //а теперь считаем id который автоматичски дался базой данных

            try
            {
                cmd.CommandText = "SELECT id FROM Categories WHERE [description]= @description ";
                //cmd параметры уже есть (выше)
                sqlConnection.Open();

                SqlDataReader sqlReader = cmd.ExecuteReader();
                while (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        Id = (int)sqlReader.GetValue(0);
                    }
                    sqlReader.NextResult();
                }

                sqlReader.Close();
                cmd.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не получилось узнать ID вновь добавленной категории " + ex.Message);
            }
            //

        }

        //++++
        public void Delete()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "DELETE Categories WHERE [id]=@id; ";

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
                MessageBox.Show("Ошибка удаления категории. " + ex.Message);
            }
        }
    }
  

}
