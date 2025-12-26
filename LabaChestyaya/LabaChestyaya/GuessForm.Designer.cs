namespace LabaChestyaya
{
    partial class GuessForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFormula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAttempts = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormula.Location = new System.Drawing.Point(20, 20);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(350, 20);
            this.lblFormula.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "a =";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(60, 58);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(40, 22);
            this.txtA.TabIndex = 2;
            this.txtA.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "b =";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(160, 58);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(40, 22);
            this.txtB.TabIndex = 4;
            this.txtB.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Попыток =";
            // 
            // txtAttempts
            // 
            this.txtAttempts.Location = new System.Drawing.Point(310, 58);
            this.txtAttempts.Name = "txtAttempts";
            this.txtAttempts.Size = new System.Drawing.Size(40, 22);
            this.txtAttempts.TabIndex = 6;
            this.txtAttempts.Text = "3";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(20, 90);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 30);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Начать игру";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ваш ответ:";
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(110, 138);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 22);
            this.txtGuess.TabIndex = 9;
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(220, 136);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(80, 26);
            this.btnGuess.TabIndex = 10;
            this.btnGuess.Text = "Угадать";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(20, 170);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 11;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(20, 200);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(90, 17);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Время: 30 сек";
            // 
            // progressBarTime
            // 
            this.progressBarTime.Location = new System.Drawing.Point(20, 220);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(330, 23);
            this.progressBarTime.TabIndex = 13;
            // 
            // GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 260);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtAttempts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFormula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GuessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отгадай ответ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuessForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAttempts;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ProgressBar progressBarTime;
    }
}