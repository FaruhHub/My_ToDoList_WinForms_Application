using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TasksApplication
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// мой список состоящий из класса Tasks
        /// </summary>
        public List<Tasks> TasksList = new List<Tasks>();
      
        public int ind_task = -1;
        public int ind_subtsk = -1;

        private string text;
        private Type type;
        private int id;
        public MainForm()
        {
            InitializeComponent();
            

            //считываем все данные из таблицы Tasks в наш лист под названием TasksList
            ReadAllData();
            Feel_Tree();

        }

        public void Feel_Tree()
        {
        #region   считываем картинки для tree view
                ImageList myImageList = new ImageList();
                myImageList.Images.Add(Image.FromFile(@"..\..\icons\1.ico"));
                myImageList.Images.Add(Image.FromFile(@"..\..\icons\2.ico"));
                myImageList.Images.Add(Image.FromFile(@"..\..\icons\3.ico"));
                myImageList.Images.Add(Image.FromFile(@"..\..\icons\4.ico"));
                myImageList.Images.Add(Image.FromFile(@"..\..\icons\5.ico"));
               
                // Assign the ImageList to the TreeView.
                
                treeView1.ImageList = myImageList;
                
        #endregion

            //перебор всех заданий
            foreach (var tsk in TasksList)
            {
                //создадим ноду(задание) которую потом добавим в tree view
                
                MyNode simpleNode = new MyNode(tsk.Description, tsk.GetType(), tsk.Id);

                //картинка для заданий
                simpleNode.ImageIndex = 4;
                simpleNode.SelectedImageIndex = 4;

                int index = 0;

                     //перебор всех подзаданий в текущем ( tsk ) задании
                    foreach (var subtsk in tsk.Subtask)
                    {
                        // в ноду (задание) добавим еще ветвь (подзадание)
                        simpleNode.Nodes.Add(new MyNode(subtsk.Description, subtsk.GetType(), subtsk.Id));
                        
                        //и зададим кртинку для подзадния
                        simpleNode.Nodes[index].ImageIndex = 3;
                        simpleNode.Nodes[index].SelectedImageIndex=3;
                        
                        index++;
                    }

                treeView1.Nodes.Add(simpleNode);
            }
            treeView1.ExpandAll(); //метод развертывающий все узлы дерева
            treeView1.Update();
        }
        
        public void ReadAllData()
        {
            //заполнимка мы все задачи, считаем их из базы и запишем в List
            SqlConnection sqlConnection;
            SqlCommand sqlCmd;
            string sql_query = @"select * from Tasks ";

            sqlConnection = new SqlConnection(MainClass.connectionString);
            try
            {   //подключаеся к базе
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql_query, sqlConnection);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                
                //считываем данные
                while (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                         //добавим в лист задач новый экземпляр(задачи) и заполним значениями
                        TasksList.Add(new Tasks()
                        {
                            CategoryLink = Convert.ToInt32(sqlReader.GetValue(0)),
                            IsFinished = Convert.ToBoolean(sqlReader.GetValue(1)),
                            Date = Convert.ToDateTime(sqlReader.GetValue(2)),
                            Description = sqlReader.GetValue(3).ToString(),
                            Id = Convert.ToInt32(sqlReader.GetValue(4))
                        });

                        //заполненную задачу сразу заполним
                        TasksList[TasksList.Count-1].Fill_Subtask();    //подзадачами
                        TasksList[TasksList.Count-1].Fill_Categories(); // и категориями
                    }
                 sqlReader.NextResult();
                }

                    sqlReader.Close();
                    sqlCmd.Dispose();
                    sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);  
            }
        
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                MyNode simpleNode = (MyNode)treeView1.SelectedNode;

                text = simpleNode.Text;
                type = simpleNode.TypeProperty;
                id = simpleNode.Id;

                foreach (var tsk in TasksList)
                {
                    if (tsk.Description == text && tsk.GetType() == type && tsk.Id == id)
                    {
                        textBoxTask.Text = tsk.Description;

                        textBoxDate.Text = tsk.Date.ToShortDateString();

                        textBoxCategory.Text = tsk.Category.Description;
                        
                        checkBoxTask.Checked = tsk.IsFinished;

                        ind_task=TasksList.IndexOf(tsk);
                       
                        break;
                    }

                    foreach (var subtsk in tsk.Subtask)
                    {
                        if (subtsk.Description == text && subtsk.GetType() == type && subtsk.Id == id)
                        {
                            textBoxSubtask.Text = subtsk.Description;

                             checkBox2.Checked = subtsk.IsFinished;
                            
                            ind_subtsk = tsk.Subtask.IndexOf(subtsk);

                            break;

                        }
                    }
                }
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //сохраняем изменения по кнопке сохранить
        public void save_changes()
        {
            foreach (var tsk in TasksList)
            {
                    if (tsk.Description == text && tsk.GetType() == type && tsk.Id == id)
                    {
                        tsk.Description=textBoxTask.Text ;

                        tsk.Date = Convert.ToDateTime(textBoxDate.Text);

                        tsk.Category.Description = textBoxCategory.Text;

                        tsk.IsFinished = checkBoxTask.Checked ;
                        tsk.Update();
                      

                        break;

                    }

                foreach (var subtsk in tsk.Subtask)
                {
                    
                    if (subtsk.Description == text && subtsk.GetType() == type && subtsk.Id == id)
                    {
                        subtsk.Description = textBoxSubtask.Text;

                        subtsk.IsFinished = checkBox2.Checked ;


                        subtsk.Update();

                        tsk.Update();

                        break;
                    }
                }
            }
        }

        //сохранить изменения
        private void button_save_all_Click(object sender, EventArgs e)
        {
            save_changes();


            //так как текст задачи или подзадачи изменился в TasksList, 
            //то необходимо изменить называние узлов элемента treeview
            //для этого очищаем узлы, и вызываем функцию для повторного заполнения treeview
            treeView1.Nodes.Clear();
            Feel_Tree();
        }
        
        //добавить задание
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddForm tmp=new AddForm(this);
            tmp.Show();
        }

        


        private void btnAddSubtask_Click(object sender, EventArgs e)
        {
            SubtaskAddForm subtsk = new SubtaskAddForm(this);
            subtsk.Show();
           
        }

        private void btnDeleteSubtask_Click(object sender, EventArgs e)
        {
            try
            {
                TasksList[ind_task].Subtask[ind_subtsk].Delete();
                TasksList[ind_task].Subtask.RemoveAt(ind_subtsk);

                treeView1.Nodes.Clear();
                Feel_Tree();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите подзадачу");
            }

        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            TasksList[ind_task].Delete();
            TasksList.RemoveAt(ind_task);

            treeView1.Nodes.Clear();
            Feel_Tree();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = TasksList.Count - 1; i >= 0; i--)
                {
                    if (TasksList[i].IsFinished)
                    {
                        TasksList[i].Delete();
                        TasksList.RemoveAt(i);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            treeView1.Nodes.Clear();
            Feel_Tree();    
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory tmp = new FormAddCategory();
            tmp.Show();
        }
        
    }
}
