using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzamin_dyplomowy
{
    public class RoundLabel : Label
    {
        int borderRadius = 0;
        Color backColor = Color.Pink;
        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }
        [Browsable(true)]
        public Color _BackColor
        {
            get { 
                return backColor;
            }
            set { 
                this.backColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public RoundLabel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rectSurface = this.ClientRectangle;
            if (this.borderRadius > 0)
            {
                using (var graphicsPath = _getRoundRectangle(this.ClientRectangle))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using (var brush = new SolidBrush(_BackColor))
                        e.Graphics.FillPath(brush, graphicsPath);
                    using (var pen = new Pen(_BackColor, 1.0f))
                        e.Graphics.DrawPath(pen, graphicsPath);
                    TextRenderer.DrawText(e.Graphics, Text, this.Font, this.ClientRectangle, this.ForeColor);
                }
            }
            else {

                Region = new Region(rectSurface);
                using (Pen penBorder = new Pen(base.BackColor, 0))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                }
            }
            
        }

        private GraphicsPath _getRoundRectangle(Rectangle rectangle)
        {
            int diminisher = 1;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(rectangle.X + rectangle.Width - BorderRadius - diminisher, rectangle.Y, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(rectangle.X + rectangle.Width - BorderRadius - diminisher, rectangle.Y + rectangle.Height - BorderRadius - diminisher, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - BorderRadius - diminisher, BorderRadius, BorderRadius, 90, 90);
            path.CloseAllFigures();
            return path;
        }
    }
}
