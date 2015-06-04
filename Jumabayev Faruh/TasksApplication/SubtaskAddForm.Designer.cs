namespace TasksApplication
{
    partial class SubtaskAddForm
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
            this.checkBoxTaskLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.checkBoxTask = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tasks = new System.Windows.Forms.ComboBox();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaryTasksDBDataSet1 = new TasksApplication.BinaryTasksDBDataSet1();
            this.label_task = new System.Windows.Forms.Label();
            this.tasksTableAdapter = new TasksApplication.BinaryTasksDBDataSet1TableAdapters.TasksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryTasksDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxTaskLabel
            // 
            this.checkBoxTaskLabel.AutoSize = true;
            this.checkBoxTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTaskLabel.Location = new System.Drawing.Point(257, 187);
            this.checkBoxTaskLabel.Name = "checkBoxTaskLabel";
            this.checkBoxTaskLabel.Size = new System.Drawing.Size(0, 20);
            this.checkBoxTaskLabel.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(295, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 77;
            this.label9.Text = "Подзадачи";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTask.Location = new System.Drawing.Point(206, 225);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(241, 30);
            this.btnAddTask.TabIndex = 76;
            this.btnAddTask.Text = "Добавить новую подзадачу";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // checkBoxTask
            // 
            this.checkBoxTask.AutoSize = true;
            this.checkBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTask.Location = new System.Drawing.Point(206, 191);
            this.checkBoxTask.Name = "checkBoxTask";
            this.checkBoxTask.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTask.TabIndex = 75;
            this.checkBoxTask.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(81, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Выполнено ?";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask.Location = new System.Drawing.Point(187, 138);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(358, 26);
            this.textBoxTask.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Подзадача";
            // 
            // comboBox_tasks
            // 
            this.comboBox_tasks.DataSource = this.tasksBindingSource;
            this.comboBox_tasks.DisplayMember = "decription";
            this.comboBox_tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_tasks.FormattingEnabled = true;
            this.comboBox_tasks.Location = new System.Drawing.Point(187, 71);
            this.comboBox_tasks.Name = "comboBox_tasks";
            this.comboBox_tasks.Size = new System.Drawing.Size(358, 28);
            this.comboBox_tasks.TabIndex = 79;
            this.comboBox_tasks.ValueMember = "id";
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.binaryTasksDBDataSet1;
            // 
            // binaryTasksDBDataSet1
            // 
            this.binaryTasksDBDataSet1.DataSetName = "BinaryTasksDBDataSet1";
            this.binaryTasksDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_task
            // 
            this.label_task.AutoSize = true;
            this.label_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_task.Location = new System.Drawing.Point(114, 71);
            this.label_task.Name = "label_task";
            this.label_task.Size = new System.Drawing.Size(67, 20);
            this.label_task.TabIndex = 80;
            this.label_task.Text = "Задача";
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // SubtaskAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 264);
            this.Controls.Add(this.label_task);
            this.Controls.Add(this.comboBox_tasks);
            this.Controls.Add(this.checkBoxTaskLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.checkBoxTask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.label1);
            this.Name = "SubtaskAddForm";
            this.Text = "SubtaskAddForm";
            this.Load += new System.EventHandler(this.SubtaskAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryTasksDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkBoxTaskLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.CheckBox checkBoxTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tasks;
        private System.Windows.Forms.Label label_task;
        private BinaryTasksDBDataSet1 binaryTasksDBDataSet1;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private BinaryTasksDBDataSet1TableAdapters.TasksTableAdapter tasksTableAdapter;
    }
}