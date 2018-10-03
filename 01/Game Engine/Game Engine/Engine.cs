using System;
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
        static Sprite canvas = new Sprite(0, 0);

        static Engine engine;
        public static Engine Form
        {
            get { return engine; }
        }

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
            set { clickX = value; }
        }
        public static int ClickY
        {
            get { return clickY; }
            set { clickY = value; }
        }

        private static int frameCount = 0;
        public static int FrameCount
        {
            get { return frameCount; }
        }

        public Engine()
        {
            InitializeComponent();
            engine = this;
            canvas.Children.Add(new ImageSprite(Image.FromFile("perhaps.jpg")));
            canvas.Children.Add(new BackgroundSprite(Image.FromFile("hellbackground.jpg")));
            canvas.Children.Add(new AnimatedSprite());
            canvas.Children.Add(new ButtonSprite(Image.FromFile("Doot.jpg"), Engine.Form.ClientSize.Width - Engine.Form.ClientSize.Width / 6, Engine.Form.ClientSize.Height - Engine.Form.ClientSize.Height / 6, 50, 50));
            DoubleBuffered = true;
            Timer t = new Timer();
            t.Interval = 33;
            t.Tick += T_Tick;
            t.Start(); 
        }

        private void T_Tick(object sender, EventArgs e)
        {
            frameCount += 1;
            canvas.Update();
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            canvas.Paint(e.Graphics);
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
            ClickX = e.X;
            ClickY = e.Y;
        }

        private void Engine_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


    }
}
