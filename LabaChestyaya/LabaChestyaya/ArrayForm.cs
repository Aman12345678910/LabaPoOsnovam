using System;
using System.Linq;
using System.Windows.Forms;

namespace LabaChestyaya
{
    public partial class ArrayForm : Form
    {
        private int[] _currentArray;

        public ArrayForm()
        {
            InitializeComponent();
            
            dataGridViewArray.ReadOnly = false;
            dataGridViewArray.AllowUserToAddRows = false;
            dataGridViewArray.CellValueChanged += dataGridViewArray_CellValueChanged;
        }

        /// <summary>
        /// Обновляет DataGridView на основе _currentArray
        /// </summary>
        private void UpdateGrid()
        {
            if (_currentArray == null) return;

            
            dataGridViewArray.CellValueChanged -= dataGridViewArray_CellValueChanged;

            
            dataGridViewArray.Rows.Clear();

            
            foreach (int value in _currentArray)
            {
                int rowIndex = dataGridViewArray.Rows.Add();
                dataGridViewArray.Rows[rowIndex].Cells[0].Value = value;
            }

           
            dataGridViewArray.CellValueChanged += dataGridViewArray_CellValueChanged;

            HighlightMinMax();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtLength.Text = "10";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLength.Text, out int len) || len < 1 || len > 2026)
            {
                MessageBox.Show("Длина массива должна быть от 1 до 2026.");
                return;
            }

            var worker = new ArrayWorker(len);
            _currentArray = worker.Array;
            UpdateGrid();
            lblTime.Text = "";
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            if (_currentArray == null || _currentArray.Length == 0)
            {
                MessageBox.Show("Сначала создайте массив!");
                return;
            }

            var worker = new ArrayWorker();
            // Обходим приватные поля через Reflection (или можно переделать ArrayWorker, но пока так)
            var field = typeof(ArrayWorker).GetField("_array", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var lenField = typeof(ArrayWorker).GetField("_length", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            field?.SetValue(worker, _currentArray);
            lenField?.SetValue(worker, _currentArray.Length);

            _currentArray = worker.InsertionSort(out double time);
            lblTime.Text = $"Сортировка вставками: {time:F2} мс";
            UpdateGrid();
        }

        private void btnGnomeSort_Click(object sender, EventArgs e)
        {
            if (_currentArray == null || _currentArray.Length == 0)
            {
                MessageBox.Show("Сначала создайте массив!");
                return;
            }

            var worker = new ArrayWorker();
            var field = typeof(ArrayWorker).GetField("_array", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var lenField = typeof(ArrayWorker).GetField("_length", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            field?.SetValue(worker, _currentArray);
            lenField?.SetValue(worker, _currentArray.Length);

            _currentArray = worker.GnomeSort(out double time);
            lblTime.Text = $"Гномья сортировка: {time:F2} мс";
            UpdateGrid();
        }

        private void HighlightMinMax()
        {
            if (_currentArray == null || _currentArray.Length == 0) return;

            int min = _currentArray.Min();
            int max = _currentArray.Max();

            for (int i = 0; i < dataGridViewArray.Rows.Count; i++)
            {
                var cell = dataGridViewArray.Rows[i].Cells[0];
                if (int.TryParse(cell.Value?.ToString(), out int val))
                {
                    if (val == min)
                        cell.Style.BackColor = System.Drawing.Color.LightBlue;
                    else if (val == max)
                        cell.Style.BackColor = System.Drawing.Color.LightCoral;
                    else
                        cell.Style.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            if (_currentArray == null || _currentArray.Length == 0)
            {
                MessageBox.Show("Сначала создайте массив!");
                return;
            }

            double avg = _currentArray.Average();
            int min = _currentArray.Min();
            int max = _currentArray.Max();
            MessageBox.Show($"Минимум: {min}\nМаксимум: {max}\nСреднее: {avg:F2}");
        }

        private void dataGridViewArray_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && _currentArray != null && e.RowIndex < _currentArray.Length)
            {
                if (int.TryParse(dataGridViewArray.Rows[e.RowIndex].Cells[0].Value?.ToString(), out int newVal))
                {
                    _currentArray[e.RowIndex] = newVal;
                }
            }
        }
    }
}