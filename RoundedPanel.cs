using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjectAkhirPPLG
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 25;
        public Color BorderColor { get; set; } = Color.LightGray;
        public int BorderSize { get; set; } = 1;

        public RoundedPanel()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            ResizeRedraw = true;
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y,
                diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter,
                rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter,
                diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                BorderSize,
                BorderSize,
                Width - BorderSize * 2 - 1,
                Height - BorderSize * 2 - 1
            );

            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            {
                using (Pen pen = new Pen(BorderColor, BorderSize))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            using (GraphicsPath path = GetRoundedPath(
                ClientRectangle, BorderRadius))
            {
                Region = new Region(path);
            }
        }
    }
}