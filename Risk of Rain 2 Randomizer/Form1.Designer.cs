namespace Risk_of_Rain_2_Randomizer
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
            this.lbChar = new System.Windows.Forms.ListBox();
            this.lbDiff = new System.Windows.Forms.ListBox();
            this.lbArt = new System.Windows.Forms.ListBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.gbPlayerCount = new System.Windows.Forms.GroupBox();
            this.cbDupe = new System.Windows.Forms.CheckBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.btnPlayer3 = new System.Windows.Forms.Button();
            this.btnPlayer4 = new System.Windows.Forms.Button();
            this.gbPlayerCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbChar
            // 
            this.lbChar.FormattingEnabled = true;
            this.lbChar.Location = new System.Drawing.Point(431, 316);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(161, 69);
            this.lbChar.TabIndex = 0;
            this.lbChar.SelectedIndexChanged += new System.EventHandler(this.lbChar_SelectedIndexChanged);
            // 
            // lbDiff
            // 
            this.lbDiff.FormattingEnabled = true;
            this.lbDiff.Location = new System.Drawing.Point(238, 35);
            this.lbDiff.Name = "lbDiff";
            this.lbDiff.Size = new System.Drawing.Size(120, 30);
            this.lbDiff.TabIndex = 1;
            // 
            // lbArt
            // 
            this.lbArt.FormattingEnabled = true;
            this.lbArt.Location = new System.Drawing.Point(387, 35);
            this.lbArt.Name = "lbArt";
            this.lbArt.Size = new System.Drawing.Size(205, 199);
            this.lbArt.TabIndex = 2;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(238, 235);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(120, 72);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Best of luck";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // gbPlayerCount
            // 
            this.gbPlayerCount.Controls.Add(this.cbDupe);
            this.gbPlayerCount.Controls.Add(this.rb4);
            this.gbPlayerCount.Controls.Add(this.rb3);
            this.gbPlayerCount.Controls.Add(this.rb2);
            this.gbPlayerCount.Controls.Add(this.rb1);
            this.gbPlayerCount.Location = new System.Drawing.Point(37, 205);
            this.gbPlayerCount.Name = "gbPlayerCount";
            this.gbPlayerCount.Size = new System.Drawing.Size(191, 180);
            this.gbPlayerCount.TabIndex = 4;
            this.gbPlayerCount.TabStop = false;
            this.gbPlayerCount.Text = "Number of Players:";
            // 
            // cbDupe
            // 
            this.cbDupe.AutoSize = true;
            this.cbDupe.Location = new System.Drawing.Point(61, 138);
            this.cbDupe.Name = "cbDupe";
            this.cbDupe.Size = new System.Drawing.Size(76, 17);
            this.cbDupe.TabIndex = 4;
            this.cbDupe.Text = "Duplicates";
            this.cbDupe.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(75, 104);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(31, 17);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(75, 81);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(31, 17);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(75, 58);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(31, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(75, 35);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(31, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.Location = new System.Drawing.Point(37, 15);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(80, 80);
            this.btnPlayer1.TabIndex = 5;
            this.btnPlayer1.UseVisualStyleBackColor = true;
            this.btnPlayer1.Visible = false;
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.Location = new System.Drawing.Point(148, 15);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(80, 80);
            this.btnPlayer2.TabIndex = 6;
            this.btnPlayer2.UseVisualStyleBackColor = true;
            this.btnPlayer2.Visible = false;
            // 
            // btnPlayer3
            // 
            this.btnPlayer3.Location = new System.Drawing.Point(37, 101);
            this.btnPlayer3.Name = "btnPlayer3";
            this.btnPlayer3.Size = new System.Drawing.Size(80, 80);
            this.btnPlayer3.TabIndex = 7;
            this.btnPlayer3.UseVisualStyleBackColor = true;
            this.btnPlayer3.Visible = false;
            // 
            // btnPlayer4
            // 
            this.btnPlayer4.Location = new System.Drawing.Point(148, 101);
            this.btnPlayer4.Name = "btnPlayer4";
            this.btnPlayer4.Size = new System.Drawing.Size(80, 80);
            this.btnPlayer4.TabIndex = 8;
            this.btnPlayer4.UseVisualStyleBackColor = true;
            this.btnPlayer4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 397);
            this.Controls.Add(this.btnPlayer4);
            this.Controls.Add(this.btnPlayer3);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer1);
            this.Controls.Add(this.gbPlayerCount);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lbArt);
            this.Controls.Add(this.lbDiff);
            this.Controls.Add(this.lbChar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPlayerCount.ResumeLayout(false);
            this.gbPlayerCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbChar;
        private System.Windows.Forms.ListBox lbDiff;
        private System.Windows.Forms.ListBox lbArt;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.GroupBox gbPlayerCount;
        private System.Windows.Forms.CheckBox cbDupe;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Button btnPlayer3;
        private System.Windows.Forms.Button btnPlayer4;
    }
}

