using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksApplication
{
    public  class MainClass
    {
        /// <summary>
        /// Свойство описывающее название задачи
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// идентификатор задачи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// строка подключения к источнику данных
        /// </summary>
        public static string connectionString= @"Data Source=localhost;Initial Catalog=BinaryTasksDB; Integrated Security=true";

       
        public virtual void Fill(int id) { }

    }
}
