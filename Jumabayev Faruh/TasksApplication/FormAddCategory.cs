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
    public partial class FormAddCategory : Form
    {
        Categories categories = new Categories();

        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "binaryTasksDBDataSet1.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.binaryTasksDBDataSet1.Categories);
        }

        private void button_save_changes_Click(object sender, EventArgs e)
        {
            categoriesTableAdapter.Update(binaryTasksDBDataSet1);
        }


    }
}
