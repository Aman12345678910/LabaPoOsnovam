using System;
using System.Windows.Forms;
using LabaChestyaya;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            new GuessForm().ShowDialog();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            new ArrayForm().ShowDialog();
        }

        private void btnTicTacToe_Click(object sender, EventArgs e)
        {
            new TicTacToeForm().ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}