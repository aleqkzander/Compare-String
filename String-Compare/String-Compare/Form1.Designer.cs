
namespace String_Compare
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StringOneTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StringTwoTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StringOneTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "String 1";
            // 
            // StringOneTextBox
            // 
            this.StringOneTextBox.Location = new System.Drawing.Point(6, 19);
            this.StringOneTextBox.Name = "StringOneTextBox";
            this.StringOneTextBox.Size = new System.Drawing.Size(258, 200);
            this.StringOneTextBox.TabIndex = 0;
            this.StringOneTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StringTwoTextBox);
            this.groupBox2.Location = new System.Drawing.Point(289, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "String 2";
            // 
            // StringTwoTextBox
            // 
            this.StringTwoTextBox.Location = new System.Drawing.Point(6, 19);
            this.StringTwoTextBox.Name = "StringTwoTextBox";
            this.StringTwoTextBox.Size = new System.Drawing.Size(258, 200);
            this.StringTwoTextBox.TabIndex = 0;
            this.StringTwoTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ScoreLabel);
            this.groupBox3.Controls.Add(this.CompareBtn);
            this.groupBox3.Location = new System.Drawing.Point(13, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controll";
            // 
            // CompareBtn
            // 
            this.CompareBtn.Location = new System.Drawing.Point(7, 20);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(75, 23);
            this.CompareBtn.TabIndex = 0;
            this.CompareBtn.Text = "Compare";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(6, 46);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(53, 13);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score: 00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox StringOneTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox StringTwoTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CompareBtn;
        private System.Windows.Forms.Label ScoreLabel;
    }
}

