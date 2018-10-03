using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Game_Engine
{
    public class AnimatedSprite : Sprite
    {

        public AnimatedSprite():base(Engine.Form.ClientSize.Width/2, Engine.Form.ClientSize.Height/2)
        {

        }

        public override void Act()
        {
            int xplace = (int)Y;
            int yplace = (int)X;
            X = (int)((Engine.Form.ClientSize.Width/2) * Math.Cos(Engine.FrameCount/75.0));
            Y = (int)((Engine.Form.ClientSize.Height/2) * Math.Sin(Engine.FrameCount/75.0));
            /*Y = 100;
            X = 100;
            Angle = Engine.FrameCount;
            */
        }

        public override void Draw(Graphics g)
        {
            if (Engine.IsMouseDown == true)
            {
                g.FillRectangle(new SolidBrush(Color.Red), Engine.Form.ClientSize.Width / 2, Engine.Form.ClientSize.Height / 2, 100, 100);

            }
        }
    }
}