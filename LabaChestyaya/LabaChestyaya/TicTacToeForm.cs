using System;
using System.Windows.Forms;

namespace LabaChestyaya
{
    public partial class TicTacToeForm : Form
    {
        private char[,] _board = new char[10, 10];
        private char _currentPlayer = 'X';
        private bool _gameActive = true;

        public TicTacToeForm()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            _gameActive = true;
            _currentPlayer = 'X';
            lblStatus.Text = "Ход: X";

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    _board[i, j] = ' ';

            dataGridViewField.Rows.Clear();
            dataGridViewField.Columns.Clear();

            for (int i = 0; i < 10; i++)
            {
                dataGridViewField.Columns.Add("", "");
                dataGridViewField.Columns[i].Width = 35;
            }

            for (int i = 0; i < 10; i++)
            {
                dataGridViewField.Rows.Add();
                for (int j = 0; j < 10; j++)
                {
                    dataGridViewField.Rows[i].Cells[j].Value = "";
                }
            }
        }

        private void dataGridViewField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_gameActive || e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (_board[e.RowIndex, e.ColumnIndex] != ' ')
            {
                MessageBox.Show("Клетка уже занята!");
                return;
            }

            _board[e.RowIndex, e.ColumnIndex] = _currentPlayer;
            dataGridViewField.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _currentPlayer.ToString();

            if (CheckWin(_currentPlayer))
            {
                MessageBox.Show($"Игрок {_currentPlayer} победил!");
                _gameActive = false;
                return;
            }

            bool full = true;
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (_board[i, j] == ' ')
                        full = false;
            if (full)
            {
                MessageBox.Show("Ничья!");
                _gameActive = false;
                return;
            }

            _currentPlayer = _currentPlayer == 'X' ? 'O' : 'X';
            lblStatus.Text = $"Ход: {_currentPlayer}";
        }

        private bool CheckWin(char player)
        {
            int size = 10;
            for (int row = 0; row < size; row++)
                for (int col = 0; col <= size - 5; col++)
                    if (CheckLine(player, row, col, 0, 1)) return true;
            for (int row = 0; row <= size - 5; row++)
                for (int col = 0; col < size; col++)
                    if (CheckLine(player, row, col, 1, 0)) return true;
            for (int row = 0; row <= size - 5; row++)
                for (int col = 0; col <= size - 5; col++)
                    if (CheckLine(player, row, col, 1, 1)) return true;
            for (int row = 0; row <= size - 5; row++)
                for (int col = 4; col < size; col++)
                    if (CheckLine(player, row, col, 1, -1)) return true;
            return false;
        }

        private bool CheckLine(char player, int startRow, int startCol, int dRow, int dCol)
        {
            for (int i = 0; i < 5; i++)
            {
                int r = startRow + i * dRow;
                int c = startCol + i * dCol;
                if (_board[r, c] != player) return false;
            }
            return true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}