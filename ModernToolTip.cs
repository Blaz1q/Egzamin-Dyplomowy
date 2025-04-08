using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzamin_dyplomowy
{
    public class ModernTooltip : Form
    {
        private Label tooltipLabel;
        private System.Windows.Forms.Timer fadeTimer;
        private bool fadingIn;
        private int fadeDuration = 5;
        private int targetOpacity = 90; // percent
        private int borderSize = 2;
        private int borderRadius = 5;
        private Color borderColor = Color.FromArgb(50, 47, 53);
        private Color bgColor = Color.FromArgb(50, 47, 53);        
        public ModernTooltip()
        {
            tooltipLabel = new Label
            {
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold), // Bolder text
                Padding = new Padding(10),
                MaximumSize = new Size(200, 0),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
            };

            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            TopMost = true;
            DoubleBuffered = true;
            Opacity = 0;
            BackColor = bgColor;

            Controls.Add(tooltipLabel);
            Padding = new Padding(2); // for a little border spacing

            // Rounded corners
            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = fadeDuration;
            fadeTimer.Tick += FadeTimer_Tick;
        }

        public void ShowTooltip(string text, Point anchorScreenLocation, Size anchorSize)
        {
            tooltipLabel.Text = text;
            Size = tooltipLabel.PreferredSize + new Size(12, 5); // Add padding/margin

            // Position to the right of the control
            int x = anchorScreenLocation.X + anchorSize.Width + 20; // 20px margin
            int y = anchorScreenLocation.Y + (anchorSize.Height - Height) / 2;

            Location = new Point(x, y);

            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            fadingIn = true;
            Opacity = 0;
            Show();
            fadeTimer.Start();
        }


        public void HideTooltip()
        {
            fadingIn = false;
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (fadingIn)
            {
                if (Opacity < targetOpacity / 100.0)
                    Opacity += 0.2;
                else
                    fadeTimer.Stop();
            }
            else
            {
                if (Opacity > 0)
                    Opacity -= 0.3;
                else
                {
                    fadeTimer.Stop();
                    Hide();
                }
            }
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
                using (Pen penSurface = new Pen(bgColor, smoothSize))
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

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
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
