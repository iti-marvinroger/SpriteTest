using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpriteTest
{
    public partial class Window : Form
    {
        Context _ctx;
        GameControl _gc;

        public Window()
        {
            InitializeComponent();

            _ctx = new Context();

            _gc = new GameControl(_ctx, ClientSize.Width, ClientSize.Height);
            this.Controls.Add(_gc);

            Timer GameTimer = new Timer();
            GameTimer.Interval = 20;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);
            GameTimer.Start();

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                _ctx.BallSpeed.X = -Context.BallAxisSpeed;
            else if (e.KeyCode == Keys.Right)
                _ctx.BallSpeed.X = Context.BallAxisSpeed;
            else if (e.KeyCode == Keys.Up)
                _ctx.BallSpeed.Y = -Context.BallAxisSpeed;
            else if (e.KeyCode == Keys.Down)
                _ctx.BallSpeed.Y = Context.BallAxisSpeed;
            else if (e.KeyCode == Keys.Space)
                _ctx.Paused = !_ctx.Paused;
        }

        void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!_ctx.Paused)
            {
                _ctx.BallPos.X += _ctx.BallSpeed.X;
                _ctx.BallPos.Y += _ctx.BallSpeed.Y;
            }

            _gc.Invalidate();
        }
    }
}