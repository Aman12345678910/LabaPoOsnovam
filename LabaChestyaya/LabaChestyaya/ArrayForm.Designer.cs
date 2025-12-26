namespace LabaChestyaya
{
    partial class ArrayForm
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
            txtLength = new TextBox();
            label1 = new Label();
            btnDefault = new Button();
            btnGenerate = new Button();
            dataGridViewArray = new DataGridView();
            Value = new DataGridViewTextBoxColumn();
            btnInsertionSort = new Button();
            btnGnomeSort = new Button();
            btnStats = new Button();
            lblTime = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray).BeginInit();
            SuspendLayout();
            // 
            // txtLength
            // 
            txtLength.Location = new Point(90, 15);
            txtLength.Margin = new Padding(3, 4, 3, 4);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(60, 27);
            txtLength.TabIndex = 0;
            txtLength.Text = "10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Длина =";
            // 
            // btnDefault
            // 
            btnDefault.Location = new Point(160, 12);
            btnDefault.Margin = new Padding(3, 4, 3, 4);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(100, 32);
            btnDefault.TabIndex = 2;
            btnDefault.Text = "Дефолтное";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.Click += btnDefault_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(270, 12);
            btnGenerate.Margin = new Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(103, 32);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Сгенерировать";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // dataGridViewArray
            // 
            dataGridViewArray.AllowUserToAddRows = false;
            dataGridViewArray.AllowUserToDeleteRows = false;
            dataGridViewArray.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewArray.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArray.Columns.AddRange(new DataGridViewColumn[] { Value });
            dataGridViewArray.Location = new Point(12, 62);
            dataGridViewArray.Margin = new Padding(3, 4, 3, 4);
            dataGridViewArray.Name = "dataGridViewArray";
            dataGridViewArray.RowHeadersWidth = 51;
            dataGridViewArray.RowTemplate.Height = 24;
            dataGridViewArray.Size = new Size(150, 375);
            dataGridViewArray.TabIndex = 4;
            // 
            // Value
            // 
            Value.HeaderText = "Значение";
            Value.MinimumWidth = 6;
            Value.Name = "Value";
            Value.Width = 120;
            // 
            // btnInsertionSort
            // 
            btnInsertionSort.Location = new Point(180, 62);
            btnInsertionSort.Margin = new Padding(3, 4, 3, 4);
            btnInsertionSort.Name = "btnInsertionSort";
            btnInsertionSort.Size = new Size(190, 38);
            btnInsertionSort.TabIndex = 5;
            btnInsertionSort.Text = "Сортировка вставками";
            btnInsertionSort.UseVisualStyleBackColor = true;
            btnInsertionSort.Click += btnInsertionSort_Click;
            // 
            // btnGnomeSort
            // 
            btnGnomeSort.Location = new Point(180, 112);
            btnGnomeSort.Margin = new Padding(3, 4, 3, 4);
            btnGnomeSort.Name = "btnGnomeSort";
            btnGnomeSort.Size = new Size(190, 38);
            btnGnomeSort.TabIndex = 6;
            btnGnomeSort.Text = "Гномья сортировка";
            btnGnomeSort.UseVisualStyleBackColor = true;
            btnGnomeSort.Click += btnGnomeSort_Click;
            // 
            // btnStats
            // 
            btnStats.Location = new Point(180, 162);
            btnStats.Margin = new Padding(3, 4, 3, 4);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(190, 38);
            btnStats.TabIndex = 7;
            btnStats.Text = "Мин/Макс/Среднее";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(180, 212);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 20);
            lblTime.TabIndex = 8;
            // 
            // ArrayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 456);
            Controls.Add(lblTime);
            Controls.Add(btnStats);
            Controls.Add(btnGnomeSort);
            Controls.Add(btnInsertionSort);
            Controls.Add(dataGridViewArray);
            Controls.Add(btnGenerate);
            Controls.Add(btnDefault);
            Controls.Add(label1);
            Controls.Add(txtLength);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ArrayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Работа с массивом";
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value; 
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnGnomeSort;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Label lblTime;
    }
}