namespace todoList_winForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCloseApp = new Button();
            btnMinimizeApp = new Button();
            panel3 = new Panel();
            btnDeleteList = new Button();
            todoCheckBox = new CheckBox();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            listViewTodo = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label2 = new Label();
            todoDescText = new RichTextBox();
            label1 = new Label();
            todoText = new RichTextBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCloseApp
            // 
            btnCloseApp.FlatStyle = FlatStyle.System;
            btnCloseApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCloseApp.Location = new Point(1158, 3);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(41, 23);
            btnCloseApp.TabIndex = 0;
            btnCloseApp.Text = "X";
            btnCloseApp.UseVisualStyleBackColor = true;
            btnCloseApp.Click += btnCloseApp_Click;
            // 
            // btnMinimizeApp
            // 
            btnMinimizeApp.BackColor = Color.Black;
            btnMinimizeApp.FlatAppearance.BorderSize = 0;
            btnMinimizeApp.FlatStyle = FlatStyle.System;
            btnMinimizeApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnMinimizeApp.ForeColor = Color.White;
            btnMinimizeApp.Location = new Point(1111, 3);
            btnMinimizeApp.Name = "btnMinimizeApp";
            btnMinimizeApp.Size = new Size(41, 23);
            btnMinimizeApp.TabIndex = 1;
            btnMinimizeApp.Text = "---";
            btnMinimizeApp.TextAlign = ContentAlignment.BottomCenter;
            btnMinimizeApp.UseVisualStyleBackColor = false;
            btnMinimizeApp.Click += btnMinimizeApp_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDeleteList);
            panel3.Controls.Add(todoCheckBox);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(listViewTodo);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(todoDescText);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(todoText);
            panel3.Location = new Point(49, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(1103, 568);
            panel3.TabIndex = 4;
            // 
            // btnDeleteList
            // 
            btnDeleteList.BackColor = Color.FromArgb(56, 58, 64);
            btnDeleteList.FlatStyle = FlatStyle.Flat;
            btnDeleteList.Font = new Font("Segoe UI", 12F);
            btnDeleteList.ForeColor = Color.White;
            btnDeleteList.Location = new Point(937, 47);
            btnDeleteList.Name = "btnDeleteList";
            btnDeleteList.Size = new Size(103, 52);
            btnDeleteList.TabIndex = 10;
            btnDeleteList.Text = "DELETAR LISTA";
            btnDeleteList.UseVisualStyleBackColor = false;
            btnDeleteList.Click += btnDeleteList_Click;
            // 
            // todoCheckBox
            // 
            todoCheckBox.AutoSize = true;
            todoCheckBox.BackColor = Color.FromArgb(56, 58, 64);
            todoCheckBox.ForeColor = Color.White;
            todoCheckBox.Location = new Point(545, 136);
            todoCheckBox.Name = "todoCheckBox";
            todoCheckBox.Size = new Size(78, 19);
            todoCheckBox.TabIndex = 9;
            todoCheckBox.Text = "Completa";
            todoCheckBox.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(56, 58, 64);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(763, 47);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 52);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "DELETAR";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(56, 58, 64);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(654, 47);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 52);
            btnClear.TabIndex = 7;
            btnClear.Text = "LIMPAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(56, 58, 64);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(545, 47);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 52);
            btnSave.TabIndex = 6;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // listViewTodo
            // 
            listViewTodo.BackColor = Color.FromArgb(56, 58, 64);
            listViewTodo.BorderStyle = BorderStyle.None;
            listViewTodo.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewTodo.Font = new Font("Segoe UI", 12F);
            listViewTodo.Location = new Point(47, 221);
            listViewTodo.Name = "listViewTodo";
            listViewTodo.Size = new Size(993, 328);
            listViewTodo.TabIndex = 5;
            listViewTodo.TileSize = new Size(10, 10);
            listViewTodo.UseCompatibleStateImageBehavior = false;
            listViewTodo.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tarefa";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descrição";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Data";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Finalizada";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 240;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 100);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 4;
            label2.Text = "Descrição";
            // 
            // todoDescText
            // 
            todoDescText.BackColor = Color.FromArgb(56, 58, 64);
            todoDescText.BorderStyle = BorderStyle.None;
            todoDescText.Font = new Font("Segoe UI", 12F);
            todoDescText.ForeColor = Color.White;
            todoDescText.Location = new Point(47, 131);
            todoDescText.Name = "todoDescText";
            todoDescText.Size = new Size(455, 24);
            todoDescText.TabIndex = 3;
            todoDescText.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 16);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 2;
            label1.Text = "Qual é a tarefa?";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // todoText
            // 
            todoText.BackColor = Color.FromArgb(56, 58, 64);
            todoText.BorderStyle = BorderStyle.None;
            todoText.Font = new Font("Segoe UI", 12F);
            todoText.ForeColor = Color.White;
            todoText.Location = new Point(47, 47);
            todoText.Name = "todoText";
            todoText.Size = new Size(455, 24);
            todoText.TabIndex = 1;
            todoText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 31, 34);
            ClientSize = new Size(1201, 684);
            Controls.Add(btnCloseApp);
            Controls.Add(panel3);
            Controls.Add(btnMinimizeApp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCloseApp;
        private Button btnMinimizeApp;
        private Panel panel3;
        private Label label1;
        private RichTextBox todoText;
        private Label label2;
        private RichTextBox todoDescText;
        private ListView listViewTodo;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;
        private CheckBox todoCheckBox;
        private Button btnDeleteList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
