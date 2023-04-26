namespace StiflerA
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
            pictureBox1 = new PictureBox();
            StartButton = new Button();
            StartTextBox = new TextBox();
            AnswerTextBox = new TextBox();
            AnswerButton = new Button();
            AnserLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.Location = new Point(400, 57);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(318, 25);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StartTextBox
            // 
            StartTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            StartTextBox.Location = new Point(400, 12);
            StartTextBox.Multiline = true;
            StartTextBox.Name = "StartTextBox";
            StartTextBox.Size = new Size(318, 28);
            StartTextBox.TabIndex = 2;
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AnswerTextBox.Location = new Point(400, 272);
            AnswerTextBox.Multiline = true;
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.Size = new Size(318, 28);
            AnswerTextBox.TabIndex = 4;
            // 
            // AnswerButton
            // 
            AnswerButton.Location = new Point(400, 317);
            AnswerButton.Name = "AnswerButton";
            AnswerButton.Size = new Size(318, 23);
            AnswerButton.TabIndex = 3;
            AnswerButton.Text = "Дать ответ";
            AnswerButton.UseVisualStyleBackColor = true;
            AnswerButton.Click += AnswerButton_Click;
            // 
            // AnserLabel
            // 
            AnserLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AnserLabel.Location = new Point(400, 85);
            AnserLabel.Name = "AnserLabel";
            AnserLabel.RightToLeft = RightToLeft.No;
            AnserLabel.Size = new Size(318, 184);
            AnserLabel.TabIndex = 5;
            AnserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 362);
            Controls.Add(AnserLabel);
            Controls.Add(AnswerTextBox);
            Controls.Add(AnswerButton);
            Controls.Add(StartTextBox);
            Controls.Add(StartButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button StartButton;
        private TextBox StartTextBox;
        private TextBox AnswerTextBox;
        private Button AnswerButton;
        private Label AnserLabel;
    }
}