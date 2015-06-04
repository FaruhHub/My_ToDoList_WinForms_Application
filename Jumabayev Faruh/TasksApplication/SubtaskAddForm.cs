using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksApplication
{
    public partial class SubtaskAddForm : Form
    {
         private MainForm mainForm;
        public SubtaskAddForm(MainForm tmp)
        {
            InitializeComponent();
            mainForm = tmp;
        }

        private void SubtaskAddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "binaryTasksDBDataSet1.Tasks". При необходимости она может быть перемещена или удалена.
            this.tasksTableAdapter.Fill(this.binaryTasksDBDataSet1.Tasks);

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            foreach (var tsk in mainForm.TasksList)
            {
                if (tsk.Id == (int) comboBox_tasks.SelectedValue)
                {
                    tsk.Subtask.Add(new Subtasks()
                    {
                        TaskLink = (int)comboBox_tasks.SelectedValue,
                        IsFinished = checkBoxTask.Checked,
                        Description = textBoxTask.Text,
                        Id = 0,
                       
                    });

                    tsk.Subtask[tsk.Subtask.Count-1].Add();
                   break;
                }
            }

            textBoxTask.Text = ""; // очищаем поле ввода задачи

            mainForm.treeView1.Nodes.Clear();

            mainForm.Feel_Tree();

        }
    }
}
