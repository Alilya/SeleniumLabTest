namespace SeleniumLab
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
        private void InitializeComponent() {
            TestBtn = new Button();
            textBoxValue = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            buttonPath = new Button();
            folderLabel = new Label();
            label2 = new Label();
            isSilent = new CheckBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // TestBtn
            // 
            TestBtn.BackColor = Color.AliceBlue;
            TestBtn.FlatStyle = FlatStyle.Popup;
            TestBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TestBtn.Location = new Point(62, 266);
            TestBtn.Margin = new Padding(3, 4, 3, 4);
            TestBtn.Name = "TestBtn";
            TestBtn.Size = new Size(527, 58);
            TestBtn.TabIndex = 0;
            TestBtn.Text = "Начать тестирование";
            TestBtn.UseVisualStyleBackColor = false;
            TestBtn.Click += TestBtn_Click;
            // 
            // textBoxValue
            // 
            textBoxValue.AllowDrop = true;
            textBoxValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValue.Location = new Point(62, 70);
            textBoxValue.Margin = new Padding(3, 4, 3, 4);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(488, 39);
            textBoxValue.TabIndex = 1;
            // 
            // buttonPath
            // 
            buttonPath.BackColor = Color.AliceBlue;
            buttonPath.FlatStyle = FlatStyle.Popup;
            buttonPath.Location = new Point(62, 230);
            buttonPath.Margin = new Padding(3, 4, 3, 4);
            buttonPath.Name = "buttonPath";
            buttonPath.Size = new Size(117, 28);
            buttonPath.TabIndex = 5;
            buttonPath.Text = "Выбрать папку";
            buttonPath.UseVisualStyleBackColor = false;
            buttonPath.Click += buttonPath_Click;
            // 
            // folderLabel
            // 
            folderLabel.AutoSize = true;
            folderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            folderLabel.Location = new Point(185, 227);
            folderLabel.Name = "folderLabel";
            folderLabel.Size = new Size(181, 28);
            folderLabel.TabIndex = 6;
            folderLabel.Text = "Папка сохранения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 37);
            label2.Name = "label2";
            label2.Size = new Size(247, 20);
            label2.TabIndex = 9;
            label2.Text = "Введите число для перевода в 2сс";
            // 
            // isSilent
            // 
            isSilent.AutoSize = true;
            isSilent.Location = new Point(62, 149);
            isSilent.Name = "isSilent";
            isSilent.Size = new Size(125, 24);
            isSilent.TabIndex = 10;
            isSilent.Text = "Тихий режим";
            isSilent.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 335);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(630, 29);
            progressBar1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 376);
            Controls.Add(progressBar1);
            Controls.Add(isSilent);
            Controls.Add(label2);
            Controls.Add(folderLabel);
            Controls.Add(buttonPath);
            Controls.Add(textBoxValue);
            Controls.Add(TestBtn);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TestBtn;
        private TextBox textBoxValue;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button buttonPath;
        private Label folderLabel;
        private Label label2;
        private CheckBox isSilent;
        private ProgressBar progressBar1;
    }
}