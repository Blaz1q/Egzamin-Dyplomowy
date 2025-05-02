using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace egzamin_dyplomowy
{
    public class RoundedButton : Button
    {
        // Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;
        private Color backgroundColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color hoverColor = Color.Transparent;
        private string tooltipText;
        private static ModernTooltip tooltip = new ModernTooltip();

        private bool isHovering = false;

        // Properties
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }
        
        [Category("RJ Code Advance")]
        public string TooltipText
        {
            get => tooltipText;
            set => tooltipText = value;
        }
        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                if (!isHovering)
                    this.BackColor = value;
                Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color HoverColor
        {
            get { return hoverColor; }
            set { 
                hoverColor = value;
                if(hoverColor!=Color.Transparent)
                this.FlatAppearance.MouseOverBackColor = this.hoverColor;
                Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.ForeColor = value;
                Invalidate();
            }
        }

        // Constructor
        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);

            BackColor = backgroundColor;
            ForeColor = textColor;

            Resize += Button_Resize;
        }
        
        // Events

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (Parent != null)
                Parent.BackColorChanged += Container_BackColorChanged;
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height)
                borderRadius = Height;
        }

        // Paint
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
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
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
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (!string.IsNullOrEmpty(TooltipText))
            {
                Point screenLocation = this.PointToScreen(Point.Empty);
                tooltip.ShowTooltip(TooltipText, screenLocation, this.Size);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            tooltip.HideTooltip();
        }
    }
}
