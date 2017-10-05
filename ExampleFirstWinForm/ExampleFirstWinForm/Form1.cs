using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleFirstWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonForShowInfo(object sender, EventArgs e)
        {
            string fio = "Arnur Zakaryanov";
            string birthday = "06.06.01";
            string learn = "IT";
            int countBox = 3;
            MessageBox.Show(fio);
            MessageBox.Show(birthday);
            MessageBox.Show(learn , ((fio.Length + birthday.Length + learn.Length) / 3).ToString() +" / "+ countBox);
        }
    }
}
