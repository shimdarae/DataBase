namespace DataBase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.createDataBase = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addTable = new System.Windows.Forms.Button();
            this.deleteTable = new System.Windows.Forms.Button();
            this.deleteColumn = new System.Windows.Forms.Button();
            this.addColumn = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DBName = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(204, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(64, 13);
            this.title.TabIndex = 60;
            this.title.Text = "Заголовок:";
            // 
            // createDataBase
            // 
            this.createDataBase.Location = new System.Drawing.Point(87, 99);
            this.createDataBase.Name = "createDataBase";
            this.createDataBase.Size = new System.Drawing.Size(123, 23);
            this.createDataBase.TabIndex = 59;
            this.createDataBase.Text = "Создать";
            this.createDataBase.UseVisualStyleBackColor = true;
            this.createDataBase.Click += new System.EventHandler(this.createDataBase_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 58;
            // 
            // addTable
            // 
            this.addTable.Enabled = false;
            this.addTable.Location = new System.Drawing.Point(327, 58);
            this.addTable.Name = "addTable";
            this.addTable.Size = new System.Drawing.Size(142, 23);
            this.addTable.TabIndex = 57;
            this.addTable.Text = "Добавить таблицу";
            this.addTable.UseVisualStyleBackColor = true;
            this.addTable.Click += new System.EventHandler(this.addTable_Click);
            // 
            // deleteTable
            // 
            this.deleteTable.Enabled = false;
            this.deleteTable.Location = new System.Drawing.Point(9, 58);
            this.deleteTable.Name = "deleteTable";
            this.deleteTable.Size = new System.Drawing.Size(105, 23);
            this.deleteTable.TabIndex = 56;
            this.deleteTable.Text = "Удалить таблицу";
            this.deleteTable.UseVisualStyleBackColor = true;
            this.deleteTable.Click += new System.EventHandler(this.deleteTable_Click);
            // 
            // deleteColumn
            // 
            this.deleteColumn.Enabled = false;
            this.deleteColumn.Location = new System.Drawing.Point(9, 87);
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Size = new System.Drawing.Size(105, 23);
            this.deleteColumn.TabIndex = 55;
            this.deleteColumn.Text = "Удалить колонку";
            this.deleteColumn.UseVisualStyleBackColor = true;
            this.deleteColumn.Click += new System.EventHandler(this.deleteColumn_Click);
            // 
            // addColumn
            // 
            this.addColumn.Enabled = false;
            this.addColumn.Location = new System.Drawing.Point(179, 58);
            this.addColumn.Name = "addColumn";
            this.addColumn.Size = new System.Drawing.Size(142, 23);
            this.addColumn.TabIndex = 54;
            this.addColumn.Text = "Добавить колонку";
            this.addColumn.UseVisualStyleBackColor = true;
            this.addColumn.Click += new System.EventHandler(this.addColumn_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Enabled = false;
            this.saveChanges.Location = new System.Drawing.Point(327, 87);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(142, 23);
            this.saveChanges.TabIndex = 53;
            this.saveChanges.Text = "Сохранить изменения";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Enabled = false;
            this.deleteRow.Location = new System.Drawing.Point(9, 29);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(105, 23);
            this.deleteRow.TabIndex = 52;
            this.deleteRow.Text = "Удалить строку";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(15, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 244);
            this.tabControl1.TabIndex = 51;
            // 
            // DBName
            // 
            this.DBName.Location = new System.Drawing.Point(9, 44);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(207, 20);
            this.DBName.TabIndex = 49;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(87, 70);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(123, 23);
            this.openButton.TabIndex = 48;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DBName);
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Controls.Add(this.createDataBase);
            this.groupBox1.Location = new System.Drawing.Point(535, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 207);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "БД:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Имя:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteRow);
            this.groupBox2.Controls.Add(this.title);
            this.groupBox2.Controls.Add(this.deleteTable);
            this.groupBox2.Controls.Add(this.saveChanges);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.addColumn);
            this.groupBox2.Controls.Add(this.deleteColumn);
            this.groupBox2.Controls.Add(this.addTable);
            this.groupBox2.Location = new System.Drawing.Point(21, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 133);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Элементы управления:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "База данных";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button createDataBase;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addTable;
        private System.Windows.Forms.Button deleteTable;
        private System.Windows.Forms.Button deleteColumn;
        private System.Windows.Forms.Button addColumn;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button deleteRow;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox DBName;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

