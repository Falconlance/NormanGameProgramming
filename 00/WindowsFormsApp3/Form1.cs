using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            e.Graphics.FillRectangle(Brushes.DarkGreen, 0, 0, w, h);
            e.Graphics.DrawLine(pen, w/3, 0, w/3, h);
            e.Graphics.DrawLine(pen, (w/3)*2, 0, (w/3)*2, h);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Update();
        }
    }
}