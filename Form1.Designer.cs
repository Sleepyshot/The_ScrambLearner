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
            AcceptButton = new Button();
            textBoxReply = new TextBox();
            DescriptionLabel = new Label();
            CurrentLvlText = new Label();
            levelLabel = new Label();
            infoTextBox = new TextBox();
            IncorrectLable = new Label();
            pointsLabel = new Label();
            timerLabel = new Label();
            label2 = new Label();
            livesLabel = new Label();
            scrambledWordLabel = new Label();
            attemptsLabel = new Label();
            SuspendLayout();
            // 
            // AcceptButton
            // 
            AcceptButton.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AcceptButton.Location = new Point(586, 67);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(94, 39);
            AcceptButton.TabIndex = 1;
            AcceptButton.Text = "Answer";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += button1_Click;
            // 
            // textBoxReply
            // 
            textBoxReply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxReply.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReply.Location = new Point(538, 29);
            textBoxReply.Name = "textBoxReply";
            textBoxReply.Size = new Size(183, 32);
            textBoxReply.TabIndex = 2;
            textBoxReply.TextAlign = HorizontalAlignment.Center;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.ForeColor = SystemColors.ActiveCaptionText;
            DescriptionLabel.Location = new Point(41, 164);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(517, 104);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "-Unscramble to gain points and move on.\r\n-Wrong answers will deduct points\r\n-The timer ending will give less points\r\n-Words have 3 attempts effected by the above ";
            DescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CurrentLvlText
            // 
            CurrentLvlText.AutoSize = true;
            CurrentLvlText.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentLvlText.Location = new Point(614, 207);
            CurrentLvlText.Name = "CurrentLvlText";
            CurrentLvlText.Size = new Size(69, 21);
            CurrentLvlText.TabIndex = 6;
            CurrentLvlText.Text = "Points";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            levelLabel.Location = new Point(41, 100);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(181, 26);
            levelLabel.TabIndex = 7;
            levelLabel.Text = "Difficulty: Med";
            // 
            // infoTextBox
            // 
            infoTextBox.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infoTextBox.Location = new Point(22, 332);
            infoTextBox.Multiline = true;
            infoTextBox.Name = "infoTextBox";
            infoTextBox.Size = new Size(766, 106);
            infoTextBox.TabIndex = 8;
            infoTextBox.Text = "Word hints / definitions go here";
            // 
            // IncorrectLable
            // 
            IncorrectLable.AutoSize = true;
            IncorrectLable.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IncorrectLable.Location = new Point(457, 73);
            IncorrectLable.Name = "IncorrectLable";
            IncorrectLable.Size = new Size(123, 26);
            IncorrectLable.TabIndex = 9;
            IncorrectLable.Text = "Incorrect";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            pointsLabel.Location = new Point(614, 164);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(107, 46);
            pointsLabel.TabIndex = 10;
            pointsLabel.Text = "1,330";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            timerLabel.Location = new Point(41, 37);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(55, 43);
            timerLabel.TabIndex = 11;
            timerLabel.Text = "45";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(724, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 26);
            label2.TabIndex = 12;
            label2.Text = "lives";
            // 
            // livesLabel
            // 
            livesLabel.AutoSize = true;
            livesLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            livesLabel.Location = new Point(737, 15);
            livesLabel.Name = "livesLabel";
            livesLabel.Size = new Size(38, 46);
            livesLabel.TabIndex = 13;
            livesLabel.Text = "3";
            // 
            // scrambledWordLabel
            // 
            scrambledWordLabel.AutoSize = true;
            scrambledWordLabel.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            scrambledWordLabel.Location = new Point(127, 29);
            scrambledWordLabel.Name = "scrambledWordLabel";
            scrambledWordLabel.Size = new Size(126, 43);
            scrambledWordLabel.TabIndex = 14;
            scrambledWordLabel.Text = "word";
            // 
            // attemptsLabel
            // 
            attemptsLabel.AutoSize = true;
            attemptsLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            attemptsLabel.Location = new Point(248, 100);
            attemptsLabel.Name = "attemptsLabel";
            attemptsLabel.Size = new Size(125, 26);
            attemptsLabel.TabIndex = 15;
            attemptsLabel.Text = "Attempt: 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(attemptsLabel);
            Controls.Add(scrambledWordLabel);
            Controls.Add(livesLabel);
            Controls.Add(label2);
            Controls.Add(timerLabel);
            Controls.Add(pointsLabel);
            Controls.Add(IncorrectLable);
            Controls.Add(infoTextBox);
            Controls.Add(levelLabel);
            Controls.Add(CurrentLvlText);
            Controls.Add(DescriptionLabel);
            Controls.Add(textBoxReply);
            Controls.Add(AcceptButton);
            MaximizeBox = false;
            Name = "Form1";
            Text = "The ScrambLearner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AcceptButton;
        private TextBox textBoxReply;
        private Label DescriptionLabel;
        private Label CurrentLvlText;
        private Label levelLabel;
        private TextBox infoTextBox;
        private Label IncorrectLable;
        private Label pointsLabel;
        private Label timerLabel;
        private Label label2;
        private Label livesLabel;
        private Label scrambledWordLabel;
        private Label attemptsLabel;
    }
}