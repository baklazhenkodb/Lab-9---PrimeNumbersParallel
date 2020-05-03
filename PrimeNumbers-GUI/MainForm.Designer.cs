namespace PrimeNumbers_GUI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startNumTextBox = new System.Windows.Forms.TextBox();
            this.endNumTextBox = new System.Windows.Forms.TextBox();
            this.numbersTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ChunkTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime numbers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lower Range:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Upper Range:";
            // 
            // startNumTextBox
            // 
            this.startNumTextBox.Location = new System.Drawing.Point(16, 25);
            this.startNumTextBox.Name = "startNumTextBox";
            this.startNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.startNumTextBox.TabIndex = 3;
            this.startNumTextBox.Text = "1000";
            // 
            // endNumTextBox
            // 
            this.endNumTextBox.Location = new System.Drawing.Point(16, 64);
            this.endNumTextBox.Name = "endNumTextBox";
            this.endNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.endNumTextBox.TabIndex = 4;
            this.endNumTextBox.Text = "4000";
            // 
            // numbersTextBox
            // 
            this.numbersTextBox.Location = new System.Drawing.Point(144, 25);
            this.numbersTextBox.Multiline = true;
            this.numbersTextBox.Name = "numbersTextBox";
            this.numbersTextBox.ReadOnly = true;
            this.numbersTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.numbersTextBox.Size = new System.Drawing.Size(356, 258);
            this.numbersTextBox.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(16, 299);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(104, 37);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thread ranges:";
            // 
            // ChunkTextBox
            // 
            this.ChunkTextBox.Location = new System.Drawing.Point(16, 116);
            this.ChunkTextBox.Name = "ChunkTextBox";
            this.ChunkTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChunkTextBox.TabIndex = 11;
            this.ChunkTextBox.Text = "100";
            this.ChunkTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 357);
            this.Controls.Add(this.ChunkTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numbersTextBox);
            this.Controls.Add(this.endNumTextBox);
            this.Controls.Add(this.startNumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Prime Numbers";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startNumTextBox;
        private System.Windows.Forms.TextBox endNumTextBox;
        private System.Windows.Forms.TextBox numbersTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ChunkTextBox;
    }
}

