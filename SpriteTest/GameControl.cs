using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteTest
{
    class GameControl : System.Windows.Forms.UserControl
    {
        Context _ctx;

        internal GameControl(Context ctx, int width, int height)
        {
            _ctx = ctx;

            this.Width = width;
            this.Height = height;

            //this.SetStyle(
            //ControlStyles.UserPaint |
            //ControlStyles.AllPaintingInWmPaint |
            //ControlStyles.DoubleBuffer, true);
            this.DoubleBuffered = true;
            //this.UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // e.Graphics.DrawImage(SpriteTest.Properties.Resources.bg, 0, 0);
            e.Graphics.DrawImage(SpriteTest.Properties.Resources.mario, _ctx.BallPos.X, _ctx.BallPos.Y);
        }
    }
}
