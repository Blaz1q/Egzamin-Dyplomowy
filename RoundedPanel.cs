using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public class RoundedPanel : Panel
    {
        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.Gray;

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); UpdateRegion(); }
        }

        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }


        public RoundedPanel()
        {
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.Resize += (s, e) => UpdateRegion(); // Keep region in sync
        }

        private void UpdateRegion()
        {
            using (GraphicsPath path = GetFigurePath(ClientRectangle, borderRadius))
            {
                this.Region = new Region(path);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Prevent flicker
        }

       protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 2;

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (SolidBrush backgroundBrush = new SolidBrush(this.BackColor))
                using (Pen penSurface = new Pen(base.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    pevent.Graphics.FillPath(backgroundBrush, pathSurface);
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }
        protected GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            float curveSize = radius * 2F;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
