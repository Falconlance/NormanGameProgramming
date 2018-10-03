﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Engine
{
    public partial class Engine : Form
    {
        static bool[,] board = new bool[5, 5];

        private static bool mouseDown = false;
        public static bool IsMouseDown
        {
            get { return mouseDown; }
        }

        private static int clickX = 0;
        private static int clickY = 0;
        public static int ClickX
        {
            get { return clickX; }
        }
        public static int ClickY
        {
            get { return clickY; }
        }

        private static int frameCount = 0;
        public static int FrameCount
        {
            get { return frameCount; }
        }

        public Engine()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Timer t = new Timer();
            t.Interval = 33;
            t.Tick += T_Tick;
            t.Start(); 
        }

        private void T_Tick(object sender, EventArgs e)
        {
            frameCount += 1;
            Refresh();
            //Console.WriteLine(frameCount);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.RotateTransform(10);
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            e.Graphics.FillRectangle(Brushes.White, 0, 0, w, h);
            e.Graphics.DrawString("asdf", new Font("Times New Roman", 10), Brushes.Black, 10, 10);
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (board[i, j])
                    {
                        e.Graphics.FillRectangle(Brushes.Black, w * i / 5, h * j / 5, w / 5, h / 5);
                        e.Graphics.DrawImage(Image.FromFile("acorn.png"), w * i / 5, h * j / 5, w / 5, h / 5);
                    }
                }
         
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Update();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            clickX = e.X;
            clickY = e.Y;
        }


    }
}
