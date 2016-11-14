using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserControl1 : UserControl
    {
        public Color BCD { get; set; }
        public event EventHandler ButtonClicked;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked ^= true;
            this.BackColor = BCD;
            if (checkBox1.Checked)
            {
               if (ButtonClicked!=null)
               ButtonClicked(sender, e);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
