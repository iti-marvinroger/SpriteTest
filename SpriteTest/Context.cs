using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteTest
{
    class Context
    {
        public const int BallAxisSpeed = 5;

        public Point BallPos = new Point(30, 30);
        public Point BallSpeed = new Point(BallAxisSpeed, BallAxisSpeed);
        public const int BallSize = 50;
        public bool Paused = false;
    }
}
