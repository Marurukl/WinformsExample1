using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSecondWinForm
{
    public partial class Form1 : Form
    {
        Numbers _numbers = new Numbers();
        public Form1()
        {
            InitializeComponent();
            startGameButton.Visible = true;
            number.Visible = false;
            largerButton.Visible = false;
            lessButton.Visible = false;
            endGameButton.Visible = false;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            startGameButton.Visible = false;
            number.Visible = true;
            largerButton.Visible = true;
            lessButton.Visible = true;
            endGameButton.Visible = true;
            MessageBox.Show("Загадайте число с 1 до 2000!");
            number.Text = (_numbers.Number).ToString();

        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Ваше число было отгадано за {0} ходов", _numbers.Count));
            _numbers.Number = 1000;
            _numbers.EndRange = 2000;
            _numbers.StartRange = 1;
            _numbers.Count = 0;
            startGameButton.Visible = true;
            number.Visible = false;
            largerButton.Visible = false;
            lessButton.Visible = false;
            endGameButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void largerButton_Click(object sender, EventArgs e)
        {
            _numbers.NumLarger();
            number.Text = (_numbers.Number).ToString();
        }

        private void lessButton_Click(object sender, EventArgs e)
        {
            _numbers.NumLess();
            number.Text = (_numbers.Number).ToString();
        }
    }
}
