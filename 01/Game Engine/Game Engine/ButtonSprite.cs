using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Game_Engine
{
    public class ButtonSprite : Sprite
    {

        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private Image image;
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        public ButtonSprite(Image image, int x, int y, int width, int height) : base(0,0)
        {
            this.image = image;
            this.width = width;
            this.height = height;
            this.X = x;
            this.Y = y;
        }


        public override void Draw(Graphics g)
        {
            if (Engine.IsMouseDown == false)
            {
                g.DrawImage(Image, X, Y, 50, 50);
            }
            else if (Engine.IsMouseDown == true && Contains(Engine.ClickX, Engine.ClickY))
            {
            }
        }


    }
}