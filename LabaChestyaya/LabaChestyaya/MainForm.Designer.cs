namespace WinFormsApp
{
    partial class MainForm
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
            btnGuess = new Button();
            btnArray = new Button();
            btnTicTacToe = new Button();
            btnAbout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(521, 112);
            btnGuess.Margin = new Padding(3, 4, 3, 4);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(200, 44);
            btnGuess.TabIndex = 0;
            btnGuess.Text = "Отгадай ответ";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // btnArray
            // 
            btnArray.Location = new Point(521, 212);
            btnArray.Margin = new Padding(3, 4, 3, 4);
            btnArray.Name = "btnArray";
            btnArray.Size = new Size(200, 44);
            btnArray.TabIndex = 1;
            btnArray.Text = "Работа с массивом";
            btnArray.UseVisualStyleBackColor = true;
            btnArray.Click += btnArray_Click;
            // 
            // btnTicTacToe
            // 
            btnTicTacToe.Location = new Point(521, 309);
            btnTicTacToe.Margin = new Padding(3, 4, 3, 4);
            btnTicTacToe.Name = "btnTicTacToe";
            btnTicTacToe.Size = new Size(200, 44);
            btnTicTacToe.TabIndex = 2;
            btnTicTacToe.Text = "Крестики-нолики (10×10)";
            btnTicTacToe.UseVisualStyleBackColor = true;
            btnTicTacToe.Click += btnTicTacToe_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(521, 424);
            btnAbout.Margin = new Padding(3, 4, 3, 4);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(200, 44);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "Об авторе";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(521, 520);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 44);
            btnExit.TabIndex = 4;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 608);
            Controls.Add(btnExit);
            Controls.Add(btnAbout);
            Controls.Add(btnTicTacToe);
            Controls.Add(btnArray);
            Controls.Add(btnGuess);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnTicTacToe;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
    }
}