namespace TasksApplication
{
    partial class FormAddCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaryTasksDBDataSet1 = new TasksApplication.BinaryTasksDBDataSet1();
            this.categoriesTableAdapter = new TasksApplication.BinaryTasksDBDataSet1TableAdapters.CategoriesTableAdapter();
            this.categoriesTableAdapter1 = new TasksApplication.BinaryTasksDBDataSet1TableAdapters.CategoriesTableAdapter();
            this.button_save_changes = new System.Windows.Forms.Button();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryTasksDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(619, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.binaryTasksDBDataSet1;
            // 
            // binaryTasksDBDataSet1
            // 
            this.binaryTasksDBDataSet1.DataSetName = "BinaryTasksDBDataSet1";
            this.binaryTasksDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // button_save_changes
            // 
            this.button_save_changes.Location = new System.Drawing.Point(160, 227);
            this.button_save_changes.Name = "button_save_changes";
            this.button_save_changes.Size = new System.Drawing.Size(246, 23);
            this.button_save_changes.TabIndex = 1;
            this.button_save_changes.Text = "Сохранить изменения";
            this.button_save_changes.UseVisualStyleBackColor = true;
            this.button_save_changes.Click += new System.EventHandler(this.button_save_changes_Click);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Название категории";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 137;
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 262);
            this.Controls.Add(this.button_save_changes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAddCategory";
            this.Text = "FormAddCategory";
            this.Load += new System.EventHandler(this.FormAddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryTasksDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BinaryTasksDBDataSet1 binaryTasksDBDataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private BinaryTasksDBDataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private BinaryTasksDBDataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private System.Windows.Forms.Button button_save_changes;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}