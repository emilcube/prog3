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
        Pen p = new Pen(Color.Red, 3);
        int[,] data;
        int rows = 5, cols = 3, cellSize = 30;

        public Grid()
        {
            InitializeComponent();
            data = new int[1000, 1000];

        }

        //public Color LineColor { get; set; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            //Pen p = new Pen(LineColor, 3);

            //for (int i = 0; i <= rows * cellSize; i += cellSize)
            //{
            //    g.DrawLine(p, 0, i, cols * cellSize, i);
            //}

            //for (int i = 0; i <= cols * cellSize; i += cellSize)
            //{
            //   g.DrawLine(p, i, 0, i, rows * cellSize);
            //}

            for (int i = 0; i < cols + 1; i++)
                g.DrawLine(p, i * cellSize + p.Width / 2, 0 + p.Width / 2, i * cellSize + p.Width / 2, cellSize * rows + p.Width);

            for (int i = 0; i < rows + 1; i++)
                g.DrawLine(p, 0, i * cellSize + p.Width / 2, cellSize * cols + p.Width, i * cellSize + p.Width / 2);
       


            for (int i = 1; i < cols + 1; i++)
                for (int j = 0; j < rows + 1; j++)
                    g.DrawString
                    (
                        Convert.ToString(data[i, j]),
                        Font, // шрифт, выбранный в дизайнере
                        Brushes.Black, // цвет цифр
                        i * cellSize + p.Width / 4 - 3 * cellSize / 4,
                        j * cellSize - p.Width - 3 * cellSize / 4 // координаты надписи
                    );
        }


        //public int RowCount
        //{
        //    get { return rows; }
        //    set { rows = value; Invalidate(); }
        //}

        //public int ColumnCount
        //{
        //    get { return cols; }
        //    set { cols = value; Invalidate(); }
        //}

        //public int CellSize
        //{
        //    get { return cellSize; }
        //    set { cellSize = value; Invalidate(); }
        //}

        public void SetCell(int i, int j, int value)
        {
            if (i < cols + 1 && i >= 0 && j < rows + 1 && j >= 0)
            {
                data[i, j] = value;
                Invalidate();
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < rows && i >= 0 && j < cols && j >= 0)
                    return data[i, j];
                else
                    return -1;
            }
            set
            {
                if (i < rows && i >= 0 && j < cols && j >= 0)
                {
                    data[i, j] = value;
                    Invalidate();
                }
            }
        }

        [Category("Cells lines")
         DefaultValue("Red")
        ]
        public Color LineColor { get { return p.Color; } set { p.Color = value; } }

        [Category("Cells width")
         DefaultValue("3")
        ]
        public float CellWidth { get { return p.Width; } set { p.Width = value; } }

        [Category("Rows count")
         DefaultValue("5")
        ]
        public int RowsCount
        {
            get { return rows; }
            set
            {
                if (value > 0)
                {
                    rows = value;
                    Invalidate();
                }
                else
                    throw new Exception();
            }
        }
        [Category("Cols count")
         DefaultValue("3")
         Description("This is the count of the cell's cols.")]
        public int ColsCount
        {
            get { return cols; }
            set
            {
                if (value > 0)
                {
                    cols = value;
                    Invalidate();
                }
                else
                    throw new Exception();
            }
        }
        [Category("Cell size")
         DefaultValue("100")
         Description("This is the size of the cells.")]
        public int CellSize
        {
            get { return cellSize; }
            set
            {
                if (value > 0)
                {
                    cellSize = value;
                    Invalidate();
                }
                else
                    throw new Exception();
            }
        }




    }
}