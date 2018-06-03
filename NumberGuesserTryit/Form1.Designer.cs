namespace NumberGuesserTryit
{
    partial class Form1
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
            this.LL_Box = new System.Windows.Forms.TextBox();
            this.LL_Title = new System.Windows.Forms.Label();
            this.UL_Box = new System.Windows.Forms.TextBox();
            this.UL_Title = new System.Windows.Forms.Label();
            this.Guess_Label = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Attempts = new System.Windows.Forms.Label();
            this.NumberIs = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.GuessBox = new System.Windows.Forms.TextBox();
            this.SecretNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LL_Box
            // 
            this.LL_Box.Location = new System.Drawing.Point(113, 71);
            this.LL_Box.Name = "LL_Box";
            this.LL_Box.Size = new System.Drawing.Size(100, 22);
            this.LL_Box.TabIndex = 1;
            // 
            // LL_Title
            // 
            this.LL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LL_Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LL_Title.Location = new System.Drawing.Point(18, 70);
            this.LL_Title.Name = "LL_Title";
            this.LL_Title.Size = new System.Drawing.Size(89, 23);
            this.LL_Title.TabIndex = 2;
            this.LL_Title.Text = "Lower Limit";
            // 
            // UL_Box
            // 
            this.UL_Box.Location = new System.Drawing.Point(310, 71);
            this.UL_Box.Name = "UL_Box";
            this.UL_Box.Size = new System.Drawing.Size(100, 22);
            this.UL_Box.TabIndex = 3;
            // 
            // UL_Title
            // 
            this.UL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UL_Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UL_Title.Location = new System.Drawing.Point(219, 70);
            this.UL_Title.Name = "UL_Title";
            this.UL_Title.Size = new System.Drawing.Size(85, 23);
            this.UL_Title.TabIndex = 4;
            this.UL_Title.Text = "Upper Limit";
            // 
            // Guess_Label
            // 
            this.Guess_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Guess_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Guess_Label.Location = new System.Drawing.Point(18, 117);
            this.Guess_Label.Name = "Guess_Label";
            this.Guess_Label.Size = new System.Drawing.Size(124, 23);
            this.Guess_Label.TabIndex = 5;
            this.Guess_Label.Text = "Make a Guess";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(416, 70);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(198, 24);
            this.Generate.TabIndex = 8;
            this.Generate.Text = "Generate a Secret Number";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(240, 116);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(50, 24);
            this.Play.TabIndex = 9;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Attempts
            // 
            this.Attempts.AutoSize = true;
            this.Attempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Attempts.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Attempts.Location = new System.Drawing.Point(296, 123);
            this.Attempts.Name = "Attempts";
            this.Attempts.Size = new System.Drawing.Size(71, 17);
            this.Attempts.TabIndex = 10;
            this.Attempts.Text = "Attempts: ";
            // 
            // NumberIs
            // 
            this.NumberIs.AutoSize = true;
            this.NumberIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.NumberIs.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NumberIs.Location = new System.Drawing.Point(413, 123);
            this.NumberIs.Name = "NumberIs";
            this.NumberIs.Size = new System.Drawing.Size(113, 17);
            this.NumberIs.TabIndex = 11;
            this.NumberIs.Text = "The Number is:  ";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(15, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(564, 36);
            this.Title.TabIndex = 12;
            this.Title.Text = "Welcome to The Number Guessing Game";
            // 
            // GuessBox
            // 
            this.GuessBox.Location = new System.Drawing.Point(134, 117);
            this.GuessBox.Name = "GuessBox";
            this.GuessBox.Size = new System.Drawing.Size(100, 22);
            this.GuessBox.TabIndex = 13;
            // 
            // SecretNum
            // 
            this.SecretNum.AutoSize = true;
            this.SecretNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SecretNum.Location = new System.Drawing.Point(290, 226);
            this.SecretNum.Name = "SecretNum";
            this.SecretNum.Size = new System.Drawing.Size(0, 46);
            this.SecretNum.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 433);
            this.Controls.Add(this.SecretNum);
            this.Controls.Add(this.GuessBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.NumberIs);
            this.Controls.Add(this.Attempts);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Guess_Label);
            this.Controls.Add(this.UL_Title);
            this.Controls.Add(this.UL_Box);
            this.Controls.Add(this.LL_Title);
            this.Controls.Add(this.LL_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LL_Box;
        private System.Windows.Forms.Label LL_Title;
        private System.Windows.Forms.TextBox UL_Box;
        private System.Windows.Forms.Label UL_Title;
        private System.Windows.Forms.Label Guess_Label;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label Attempts;
        private System.Windows.Forms.Label NumberIs;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox GuessBox;
        private System.Windows.Forms.Label SecretNum;
    }
}

