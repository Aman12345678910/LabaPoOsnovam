using System;
using System.Windows.Forms;

namespace LabaChestyaya
{
    public partial class GuessForm : Form
    {
        private double _correctAnswer;
        private int _attempts;
        private int _usedAttempts = 0;
        private System.Windows.Forms.Timer _gameTimer;
        private const int TIME_LIMIT_SECONDS = 30;
        private int _timeLeft = TIME_LIMIT_SECONDS;

        public GuessForm()
        {
            InitializeComponent();
            InitializeTimer();
            lblFormula.Text = "f(a, b) = sin²( log₅(b) / √cos(a) )";
        }

        private void InitializeTimer()
        {
            _gameTimer = new System.Windows.Forms.Timer();
            _gameTimer.Interval = 1000;
            _gameTimer.Tick += OnTimerTick;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text, out int a) || a < 1 || a > 10)
            {
                MessageBox.Show("a должно быть от 1 до 10");
                return;
            }
            if (!int.TryParse(txtB.Text, out int b) || b < 2 || b > 10)
            {
                MessageBox.Show("b должно быть от 2 до 10");
                return;
            }
            if (!int.TryParse(txtAttempts.Text, out int attempts) || attempts < 1 || attempts > 10)
            {
                MessageBox.Show("Попытки: от 1 до 10");
                return;
            }

            _correctAnswer = GuessGame.CalculateFunction(a, b);
            _attempts = attempts;
            _usedAttempts = 0;
            txtGuess.Enabled = true;
            btnGuess.Enabled = true;
            txtGuess.Text = "";
            lblStatus.Text = "";

            _timeLeft = TIME_LIMIT_SECONDS;
            progressBarTime.Maximum = TIME_LIMIT_SECONDS;
            progressBarTime.Value = _timeLeft;
            _gameTimer.Start();
            lblTime.Text = $"Время: {_timeLeft} сек";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtGuess.Text, out double guess))
            {
                MessageBox.Show("Введите число!");
                return;
            }

            _usedAttempts++;
            if (Math.Abs(guess - _correctAnswer) < 0.01)
            {
                _gameTimer.Stop();
                MessageBox.Show("Поздравляем! Вы угадали!");
                this.Close();
            }
            else if (_usedAttempts >= _attempts)
            {
                _gameTimer.Stop();
                MessageBox.Show($"Попытки закончились.\nПравильный ответ: {Math.Round(_correctAnswer, 2)}");
                this.Close();
            }
            else
            {
                lblStatus.Text = $"Неверно. Осталось {_attempts - _usedAttempts} попыток.";
                txtGuess.Clear();
                txtGuess.Focus();
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            _timeLeft--;
            if (_timeLeft >= 0)
            {
                progressBarTime.Value = _timeLeft;
                lblTime.Text = $"Время: {_timeLeft} сек";
            }

            if (_timeLeft <= 0)
            {
                _gameTimer.Stop();
                MessageBox.Show($"Время вышло!\nПравильный ответ: {Math.Round(_correctAnswer, 2)}");
                this.Close();
            }
        }

        private void GuessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _gameTimer?.Stop();
        }
    }
}