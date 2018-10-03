using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Game_Engine
{

    public class ImageSprite : Sprite
    {

        static ImageSprite imagesprite;
        public static ImageSprite Form
        {
            get { return imagesprite; }
        }

        private Image image;
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public ImageSprite(Image image) : base(0,0)
        {
            this.image = image;
        }
        public void Hide()
        {
            Visible = false;
        }


        public override void Draw(Graphics g)
        {
            g.DrawImage(Image, 0, 0, Engine.Form.ClientSize.Width, Engine.Form.ClientSize.Height);
        }

    }
}