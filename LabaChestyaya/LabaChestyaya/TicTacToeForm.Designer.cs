namespace LabaChestyaya
{
    partial class TicTacToeForm
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
            this.dataGridViewField = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewField)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewField
            // 
            this.dataGridViewField.AllowUserToAddRows = false;
            this.dataGridViewField.AllowUserToDeleteRows = false;
            this.dataGridViewField.AllowUserToResizeColumns = false;
            this.dataGridViewField.AllowUserToResizeRows = false;
            this.dataGridViewField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewField.ColumnHeadersVisible = false;
            this.dataGridViewField.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewField.Name = "dataGridViewField";
            this.dataGridViewField.RowHeadersVisible = false;
            this.dataGridViewField.RowHeadersWidth = 51;
            this.dataGridViewField.RowTemplate.Height = 24;
            this.dataGridViewField.Size = new System.Drawing.Size(350, 350);
            this.dataGridViewField.TabIndex = 0;
            this.dataGridViewField.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewField_CellClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(12, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Ход: X";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(260, 10);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 25);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 400);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dataGridViewField);
            this.Name = "TicTacToeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Крестики-нолики 10×10";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewField;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNewGame;
    }
}