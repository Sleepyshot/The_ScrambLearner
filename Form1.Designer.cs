namespace The_ScrambLearner
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
            ScrambledWordBox = new TextBox();
            AcceptButton = new Button();
            textBoxReply = new TextBox();
            progressBar1 = new ProgressBar();
            DescriptionLabel = new Label();
            label1 = new Label();
            CurrentLvlText = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ScrambledWordBox
            // 
            ScrambledWordBox.Font = new Font("Showcard Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            ScrambledWordBox.Location = new Point(60, 12);
            ScrambledWordBox.Multiline = true;
            ScrambledWordBox.Name = "ScrambledWordBox";
            ScrambledWordBox.Size = new Size(666, 77);
            ScrambledWordBox.TabIndex = 0;
            ScrambledWordBox.Text = "Scrambled Word";
            ScrambledWordBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AcceptButton
            // 
            AcceptButton.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AcceptButton.Location = new Point(331, 178);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(94, 39);
            AcceptButton.TabIndex = 1;
            AcceptButton.Text = "Accept";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += button1_Click;
            // 
            // textBoxReply
            // 
            textBoxReply.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxReply.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReply.Location = new Point(293, 140);
            textBoxReply.Name = "textBoxReply";
            textBoxReply.Size = new Size(183, 32);
            textBoxReply.TabIndex = 2;
            textBoxReply.TextAlign = HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 418);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(730, 18);
            progressBar1.TabIndex = 3;
            progressBar1.Value = 25;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.ForeColor = SystemColors.ActiveCaptionText;
            DescriptionLabel.Location = new Point(146, 92);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(514, 26);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "Unscramble the word to move on to the next.\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 144);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 5;
            label1.Text = "Answer";
            // 
            // CurrentLvlText
            // 
            CurrentLvlText.AutoSize = true;
            CurrentLvlText.Location = new Point(33, 395);
            CurrentLvlText.Name = "CurrentLvlText";
            CurrentLvlText.Size = new Size(55, 20);
            CurrentLvlText.TabIndex = 6;
            CurrentLvlText.Text = "Level 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(708, 395);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 7;
            label2.Text = "Level 2";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(146, 269);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(514, 143);
            textBox1.TabIndex = 8;
            textBox1.Text = "Description goes here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(CurrentLvlText);
            Controls.Add(label1);
            Controls.Add(DescriptionLabel);
            Controls.Add(progressBar1);
            Controls.Add(textBoxReply);
            Controls.Add(AcceptButton);
            Controls.Add(ScrambledWordBox);
            Name = "Form1";
            Text = "The ScrambLearner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ScrambledWordBox;
        private Button AcceptButton;
        private TextBox textBoxReply;
        private ProgressBar progressBar1;
        private Label DescriptionLabel;
        private Label label1;
        private Label CurrentLvlText;
        private Label label2;
        private TextBox textBox1;
    }
}