namespace TasksApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.checkBoxTaskLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.checkBoxTask = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox2Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddSubtask = new System.Windows.Forms.Button();
            this.btnDeleteSubtask = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSubtask = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_save_all = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 468);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(322, 462);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnAddCategory);
            this.panel2.Controls.Add(this.btnDeleteAll);
            this.panel2.Controls.Add(this.checkBoxTaskLabel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnAddTask);
            this.panel2.Controls.Add(this.btnDeleteTask);
            this.panel2.Controls.Add(this.checkBoxTask);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxCategory);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxTask);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(346, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 215);
            this.panel2.TabIndex = 45;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteAll.Location = new System.Drawing.Point(503, 136);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(156, 76);
            this.btnDeleteAll.TabIndex = 56;
            this.btnDeleteAll.Text = "Удалить выполненные задачи";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // checkBoxTaskLabel
            // 
            this.checkBoxTaskLabel.AutoSize = true;
            this.checkBoxTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTaskLabel.Location = new System.Drawing.Point(208, 167);
            this.checkBoxTaskLabel.Name = "checkBoxTaskLabel";
            this.checkBoxTaskLabel.Size = new System.Drawing.Size(0, 20);
            this.checkBoxTaskLabel.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(236, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "Задача";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTask.Location = new System.Drawing.Point(503, 5);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(156, 30);
            this.btnAddTask.TabIndex = 53;
            this.btnAddTask.Text = "Добавить задачу";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTask.Location = new System.Drawing.Point(503, 38);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(156, 30);
            this.btnDeleteTask.TabIndex = 52;
            this.btnDeleteTask.Text = "Удалить задачу";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // checkBoxTask
            // 
            this.checkBoxTask.AutoSize = true;
            this.checkBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTask.Location = new System.Drawing.Point(157, 171);
            this.checkBoxTask.Name = "checkBoxTask";
            this.checkBoxTask.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTask.TabIndex = 51;
            this.checkBoxTask.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Выполнено ?";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategory.Location = new System.Drawing.Point(128, 122);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(362, 26);
            this.textBoxCategory.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Категория";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDate.Location = new System.Drawing.Point(128, 82);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(362, 26);
            this.textBoxDate.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Дата";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask.Location = new System.Drawing.Point(128, 45);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(362, 26);
            this.textBoxTask.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Задача";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.checkBox2Label);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnAddSubtask);
            this.panel3.Controls.Add(this.btnDeleteSubtask);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxSubtask);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(347, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 199);
            this.panel3.TabIndex = 46;
            // 
            // checkBox2Label
            // 
            this.checkBox2Label.AutoSize = true;
            this.checkBox2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2Label.Location = new System.Drawing.Point(207, 195);
            this.checkBox2Label.Name = "checkBox2Label";
            this.checkBox2Label.Size = new System.Drawing.Size(0, 20);
            this.checkBox2Label.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(220, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "Подзадачи";
            // 
            // btnAddSubtask
            // 
            this.btnAddSubtask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSubtask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSubtask.Location = new System.Drawing.Point(310, 146);
            this.btnAddSubtask.Name = "btnAddSubtask";
            this.btnAddSubtask.Size = new System.Drawing.Size(179, 30);
            this.btnAddSubtask.TabIndex = 54;
            this.btnAddSubtask.Text = "Добавить подзадачу";
            this.btnAddSubtask.UseVisualStyleBackColor = true;
            this.btnAddSubtask.Click += new System.EventHandler(this.btnAddSubtask_Click);
            // 
            // btnDeleteSubtask
            // 
            this.btnDeleteSubtask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSubtask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSubtask.Location = new System.Drawing.Point(35, 146);
            this.btnDeleteSubtask.Name = "btnDeleteSubtask";
            this.btnDeleteSubtask.Size = new System.Drawing.Size(184, 30);
            this.btnDeleteSubtask.TabIndex = 53;
            this.btnDeleteSubtask.Text = "Удалить подзадачу";
            this.btnDeleteSubtask.UseVisualStyleBackColor = true;
            this.btnDeleteSubtask.Click += new System.EventHandler(this.btnDeleteSubtask_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(155, 115);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 52;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Выполнено ?";
            // 
            // textBoxSubtask
            // 
            this.textBoxSubtask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubtask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSubtask.Location = new System.Drawing.Point(136, 51);
            this.textBoxSubtask.Name = "textBoxSubtask";
            this.textBoxSubtask.Size = new System.Drawing.Size(353, 26);
            this.textBoxSubtask.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(24, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "подЗадача";
            // 
            // button_save_all
            // 
            this.button_save_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save_all.Location = new System.Drawing.Point(347, 444);
            this.button_save_all.Name = "button_save_all";
            this.button_save_all.Size = new System.Drawing.Size(683, 33);
            this.button_save_all.TabIndex = 47;
            this.button_save_all.Text = "Сохранить";
            this.button_save_all.UseVisualStyleBackColor = true;
            this.button_save_all.Click += new System.EventHandler(this.button_save_all_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCategory.Location = new System.Drawing.Point(503, 74);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(156, 56);
            this.btnAddCategory.TabIndex = 57;
            this.btnAddCategory.Text = "Добавить категорию";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 495);
            this.Controls.Add(this.button_save_all);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Tasks Manager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.CheckBox checkBoxTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddSubtask;
        private System.Windows.Forms.Button btnDeleteSubtask;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSubtask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label checkBoxTaskLabel;
        private System.Windows.Forms.Label checkBox2Label;
        private System.Windows.Forms.Button button_save_all;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnAddCategory;
    }
}

