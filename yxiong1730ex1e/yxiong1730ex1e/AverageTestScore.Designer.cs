namespace yxiong1730ex1e
{
    partial class AverageTestScore
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
            this.txtTest1 = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.Label();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.Label();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.Label();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtCalculate = new System.Windows.Forms.Button();
            this.txtClear = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTest1
            // 
            this.txtTest1.AutoSize = true;
            this.txtTest1.Location = new System.Drawing.Point(139, 75);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(52, 17);
            this.txtTest1.TabIndex = 6;
            this.txtTest1.Text = "Test 1:";
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(211, 72);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(69, 22);
            this.txtScore1.TabIndex = 0;
            this.txtScore1.Text = "0";
            this.txtScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest2
            // 
            this.txtTest2.AutoSize = true;
            this.txtTest2.Location = new System.Drawing.Point(139, 109);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(52, 17);
            this.txtTest2.TabIndex = 7;
            this.txtTest2.Text = "Test 2:";
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(211, 106);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(69, 22);
            this.txtScore2.TabIndex = 1;
            this.txtScore2.Text = "0";
            this.txtScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest3
            // 
            this.txtTest3.AutoSize = true;
            this.txtTest3.Location = new System.Drawing.Point(139, 144);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(52, 17);
            this.txtTest3.TabIndex = 8;
            this.txtTest3.Text = "Test 3:";
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(211, 141);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(69, 22);
            this.txtScore3.TabIndex = 2;
            this.txtScore3.Text = "0";
            this.txtScore3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAverage
            // 
            this.txtAverage.AutoSize = true;
            this.txtAverage.Location = new System.Drawing.Point(126, 199);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(65, 17);
            this.txtAverage.TabIndex = 9;
            this.txtAverage.Text = "Average:";
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(211, 196);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.ReadOnly = true;
            this.txtAverageScore.Size = new System.Drawing.Size(69, 22);
            this.txtAverageScore.TabIndex = 10;
            this.txtAverageScore.TabStop = false;
            this.txtAverageScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCalculate
            // 
            this.txtCalculate.Location = new System.Drawing.Point(305, 72);
            this.txtCalculate.Name = "txtCalculate";
            this.txtCalculate.Size = new System.Drawing.Size(109, 35);
            this.txtCalculate.TabIndex = 3;
            this.txtCalculate.Text = "Calculate";
            this.txtCalculate.UseVisualStyleBackColor = true;
            this.txtCalculate.Click += new System.EventHandler(this.TxtCalculate_Click);
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(305, 114);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(109, 35);
            this.txtClear.TabIndex = 4;
            this.txtClear.Text = "Clear";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.TxtClear_Click);
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(305, 156);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(109, 35);
            this.txtExit.TabIndex = 5;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.TxtExit_Click);
            // 
            // AverageTestScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.txtCalculate);
            this.Controls.Add(this.txtAverageScore);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.txtTest1);
            this.Name = "AverageTestScore";
            this.Text = "yxiong1730: Average Test Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTest1;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.Label txtTest2;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.Label txtTest3;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.Label txtAverage;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Button txtCalculate;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.Button txtExit;
    }
}

