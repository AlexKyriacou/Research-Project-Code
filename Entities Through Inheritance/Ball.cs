using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class Ball : DynamicEntity
    {
        public Ball(int x, int y, int dx, int dy) : base(x,y,dx,dy)
        {
        }

        private Color color = Color.Blue;

        public override void Collide()
        {
            if (x >= SplashKit.CurrentWindowWidth() || x <= 0)
            {
                dx = -dx;
            }
            else if (y >= SplashKit.CurrentWindowHeight() || y <= 0)
            {
                dy = -dy;
            }
        }

        public override void Render()
        {
            SplashKit.FillCircle(color, x, y, 5);
        }

        public override void Update()
        {
            x += dx;
            y += dy;
        }
    }
}
