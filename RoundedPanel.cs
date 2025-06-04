using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzamin_dyplomowy
{
    public class RoundedPanel : Panel
    {
        private int _cornerRadius = 10;

        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = value;
                UpdateRegion();
            }
        }

        public RoundedPanel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                   ControlStyles.ResizeRedraw |
                   ControlStyles.UserPaint, true);
            UpdateRegion();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            using (var path = CreateRoundPath(ClientRectangle))
            {
                Region = new Region(path);
            }
        }

        private GraphicsPath CreateRoundPath(Rectangle rect)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(rect.Right - CornerRadius, rect.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(rect.Right - CornerRadius, rect.Bottom - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = CreateRoundPath(ClientRectangle))
            using (var brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }
    }
}