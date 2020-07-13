using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Call the OnPaint method of the base class.  
            base.OnPaint(e);
            // Call methods of the System.Drawing.Graphics object.  
            //e.Graphics.DrawString("안녕",Font, new SolidBrush(ForeColor), ClientRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics aGraphics = CreateGraphics();
            aGraphics.DrawString("안녕", Font, new SolidBrush(ForeColor), ClientRectangle);
        }
    }
}