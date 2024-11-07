namespace zd2
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
            closeTabControl = new TabControl();
            tabPage1 = new TabPage();
            saveButton = new Button();
            filenameTextBox = new TextBox();
            label1 = new Label();
            loadButton = new Button();
            phoneBookListBox = new ListBox();
            tabPage2 = new TabPage();
            removeButton = new Button();
            nameTextBox = new TextBox();
            label2 = new Label();
            nameButton = new Button();
            tabPage3 = new TabPage();
            replaceButton = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            addContactButton = new Button();
            tabPage4 = new TabPage();
            closeButton = new Button();
            closeTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // closeTabControl
            // 
            closeTabControl.Controls.Add(tabPage1);
            closeTabControl.Controls.Add(tabPage2);
            closeTabControl.Controls.Add(tabPage3);
            closeTabControl.Controls.Add(tabPage4);
            closeTabControl.Dock = DockStyle.Fill;
            closeTabControl.Location = new Point(0, 0);
            closeTabControl.Name = "closeTabControl";
            closeTabControl.SelectedIndex = 0;
            closeTabControl.Size = new Size(800, 450);
            closeTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(saveButton);
            tabPage1.Controls.Add(filenameTextBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(loadButton);
            tabPage1.Controls.Add(phoneBookListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Вывод информации";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(48, 143);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(158, 29);
            saveButton.TabIndex = 34;
            saveButton.Text = " Сохранить в файл";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // filenameTextBox
            // 
            filenameTextBox.Location = new Point(61, 75);
            filenameTextBox.Name = "filenameTextBox";
            filenameTextBox.Size = new Size(125, 27);
            filenameTextBox.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 20;
            label1.Text = "Введите название файла";
            // 
            // loadButton
            // 
            loadButton.Location = new Point(48, 108);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(158, 29);
            loadButton.TabIndex = 19;
            loadButton.Text = "Вывести контакты";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // phoneBookListBox
            // 
            phoneBookListBox.FormattingEnabled = true;
            phoneBookListBox.Location = new Point(227, 27);
            phoneBookListBox.Name = "phoneBookListBox";
            phoneBookListBox.Size = new Size(538, 144);
            phoneBookListBox.TabIndex = 18;
            phoneBookListBox.SelectedIndexChanged += phoneBookListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(removeButton);
            tabPage2.Controls.Add(nameTextBox);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(nameButton);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Вывод и удаление";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(329, 178);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(158, 29);
            removeButton.TabIndex = 36;
            removeButton.Text = "Удлить контакт";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(342, 97);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 60);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 34;
            label2.Text = "Введите имя для поиска";
            // 
            // nameButton
            // 
            nameButton.Location = new Point(329, 143);
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(158, 29);
            nameButton.TabIndex = 33;
            nameButton.Text = "Вывести контакт";
            nameButton.UseVisualStyleBackColor = true;
            nameButton.Click += nameButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(replaceButton);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(addContactButton);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Добавление и редактирование";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // replaceButton
            // 
            replaceButton.Location = new Point(395, 158);
            replaceButton.Name = "replaceButton";
            replaceButton.Size = new Size(181, 29);
            replaceButton.TabIndex = 41;
            replaceButton.Text = "Редактировать контакт";
            replaceButton.UseVisualStyleBackColor = true;
            replaceButton.Click += replaceButton_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(410, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 27);
            textBox3.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 117);
            label5.Name = "label5";
            label5.Size = new Size(185, 20);
            label5.TabIndex = 39;
            label5.Text = "Введите номер телефона";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(410, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 27);
            textBox2.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 84);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 37;
            label4.Text = "Введите фамилию";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(410, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 52);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 35;
            label3.Text = "Введите имя";
            // 
            // addContactButton
            // 
            addContactButton.Location = new Point(216, 158);
            addContactButton.Name = "addContactButton";
            addContactButton.Size = new Size(158, 29);
            addContactButton.TabIndex = 34;
            addContactButton.Text = "Добавить контакт";
            addContactButton.UseVisualStyleBackColor = true;
            addContactButton.Click += addContactButton_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(closeButton);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 417);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Выход";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(317, 194);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(158, 29);
            closeButton.TabIndex = 36;
            closeButton.Text = "Выйти";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeTabControl);
            Name = "Form1";
            Text = "Form1";
            closeTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl closeTabControl;
        private TabPage tabPage1;
        private Button saveButton;
        private TextBox filenameTextBox;
        private Label label1;
        private Button loadButton;
        private ListBox phoneBookListBox;
        private TabPage tabPage2;
        private Button removeButton;
        private TextBox nameTextBox;
        private Label label2;
        private Button nameButton;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button replaceButton;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Button addContactButton;
        private Button closeButton;
    }
}
