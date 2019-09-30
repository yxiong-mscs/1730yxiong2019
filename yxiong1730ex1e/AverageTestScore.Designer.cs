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
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTest1 = new System.Windows.Forms.Label();
            this.txtTest2 = new System.Windows.Forms.Label();
            this.txtTest3 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.Label();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(209, 80);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 22);
            this.txtScore1.TabIndex = 0;
            this.txtScore1.Text = "0";
            this.txtScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(209, 109);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 22);
            this.txtScore2.TabIndex = 1;
            this.txtScore2.Text = "0";
            this.txtScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(209, 138);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(100, 22);
            this.txtScore3.TabIndex = 2;
            this.txtScore3.Text = "0";
            this.txtScore3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(341, 80);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 38);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(341, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 38);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(341, 168);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtTest1
            // 
            this.txtTest1.AutoSize = true;
            this.txtTest1.Location = new System.Drawing.Point(151, 83);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(52, 17);
            this.txtTest1.TabIndex = 6;
            this.txtTest1.Text = "Test 1:";
            // 
            // txtTest2
            // 
            this.txtTest2.AutoSize = true;
            this.txtTest2.Location = new System.Drawing.Point(151, 112);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(52, 17);
            this.txtTest2.TabIndex = 7;
            this.txtTest2.Text = "Test 2:";
            // 
            // txtTest3
            // 
            this.txtTest3.AutoSize = true;
            this.txtTest3.Location = new System.Drawing.Point(151, 141);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(52, 17);
            this.txtTest3.TabIndex = 8;
            this.txtTest3.Text = "Test 3:";
            // 
            // txtAverage
            // 
            this.txtAverage.AutoSize = true;
            this.txtAverage.Location = new System.Drawing.Point(138, 199);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(65, 17);
            this.txtAverage.TabIndex = 9;
            this.txtAverage.Text = "Average:";
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(209, 196);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.ReadOnly = true;
            this.txtAverageScore.Size = new System.Drawing.Size(100, 22);
            this.txtAverageScore.TabIndex = 10;
            this.txtAverageScore.TabStop = false;
            this.txtAverageScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AverageTestScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAverageScore);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Name = "AverageTestScore";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label txtTest1;
        private System.Windows.Forms.Label txtTest2;
        private System.Windows.Forms.Label txtTest3;
        private System.Windows.Forms.Label txtAverage;
        private System.Windows.Forms.TextBox txtAverageScore;
    }
}

