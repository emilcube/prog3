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
    public partial class RedButton : Button
    {
        public RedButton()
        {
            InitializeComponent();
        }

        //public bool Crossed { get; set; } // добавить СВОЙСТВО

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (Crossed)
            {
                Graphics g = pe.Graphics;
                Pen p = new Pen(Color.Orange, 5);
                g.DrawLine(p, 0, 0, this.Width, this.Height);
                g.DrawLine(p, 0, this.Height, this.Width, 0);
            }
        }

        bool c;
        public bool Crossed
        {
            get { return c; }
            set { c = value; Invalidate();}
        }
    }
}
