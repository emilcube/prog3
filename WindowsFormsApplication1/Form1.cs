using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MYEVENTHANDLER(object sender, EventArgs e)
        {

        }

        private void userControl11_ButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void redButton1_Click(object sender, EventArgs e)
        {
            redButton1.Crossed ^= true;
            int number;
            Random r = new Random();
            number = r.Next(0, 4);
            grid1[r.Next(1, grid1.ColsCount + 1), r.Next(1, grid1.RowsCount + 1)] = number;
        }

        private void grid1_Click(object sender, EventArgs e)
        {

        }


    }
}
