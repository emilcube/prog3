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
            comboBox1.Items.Add(Grid.GridDisplayMode.Colors);
            comboBox1.Items.Add(Grid.GridDisplayMode.Numbers);
            comboBox1.Items.Add(Grid.GridDisplayMode.NumberAndColors);
            comboBox1.Items.Add(Grid.GridDisplayMode.Image);
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

        private void grid1_CellClick(object sender, int row, int column)
        {
            int number = 0;
            Random r = new Random();
            number = r.Next(0, 4);
            while (number == grid1[row, column])
                number = r.Next(0, 4);
            grid1.SetCell(row, column, number);
            //Console.WriteLine("{0},{1} -> {2}", row, column, number);
            //grid1[row, column] = r.Next(1, 400);
            //grid1.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid1.DisplayMode = (Grid.GridDisplayMode)comboBox1.SelectedItem;
            grid1.Invalidate();
        }

    }
}
