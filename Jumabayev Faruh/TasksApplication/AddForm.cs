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
    public partial class AddForm : Form
    {
        private MainForm mainForm;
        public AddForm(MainForm tmp)
        {
            mainForm = tmp;
            InitializeComponent();
        }
        

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                mainForm.TasksList.Add(new Tasks()
                {
                    CategoryLink = (int)comboBox1.SelectedValue,
                    IsFinished = checkBoxTask.Checked,
                    Date = Convert.ToDateTime(dateTimePicker1.Text),
                    Description = textBoxTask.Text,

                });
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            textBoxTask.Text = "";
            
            int a = (mainForm.TasksList.Count )- 1;

            mainForm.TasksList[a].Add();

            mainForm.treeView1.Nodes.Clear();
          
            mainForm.Feel_Tree();

            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "binaryTasksDBDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.binaryTasksDBDataSet.Categories);

        }
    }
}
