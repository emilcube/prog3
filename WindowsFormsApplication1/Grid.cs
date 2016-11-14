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
    public partial class Grid : Control
    {
        public Grid()
        {
            InitializeComponent();
        }

        public Color LineColor { get; set; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            Pen p = new Pen(LineColor, 3);

            for (int i = 0; i <= rows * cellSize; i += cellSize)
            {
                pe.Graphics.DrawLine(p, 0, i, cols * cellSize, i);
            }

            for (int i = 0; i <= cols * cellSize; i += cellSize)
            {
                pe.Graphics.DrawLine(p, i, 0, i, rows * cellSize);
            }

            for(int i=0;i<rows;i++)
                for(int j=0;j<cols; j++)
                {
                    g.DrawString(Convert.ToString(0),
                    Font,
                    Brushes.Black,
                    j*cellSize + cellSize/3, i*cellSize + cellSize / 3);
                }
        }

            int rows = 5, cols = 3, cellSize = 30;
        public int RowCount
        {
            get { return rows; }
            set { rows = value; Invalidate(); }
        }

        public int ColumnCount
        {
            get { return cols; }
            set { cols = value; Invalidate(); }
        }

        public int CellSize
        {
            get { return cellSize; }
            set { cellSize = value; Invalidate(); }
        }

        int[,] data = new int[1000, 1000];

        public void SetCell(int i, int j, int value)
        {
            data[i, j] = value;
        }
    }
}