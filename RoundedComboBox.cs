using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public class RoundedComboBox : ComboBox
    {
        private int _cornerRadius = 8;
        private string _placeholder = "sigma";
        private Color _borderColor = Color.FromArgb(220, 220, 220);
        private Color _activeBorderColor = Color.DodgerBlue;
        private Color _arrowColor = Color.FromArgb(100, 100, 100);
        private int _borderThickness = 1;
        private Color _fillColor = Color.White;

        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; UpdateRegionAndInvalidate(); }
        }

        public string Placeholder
        {
            get => _placeholder;
            set { _placeholder = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public Color ActiveBorderColor
        {
            get => _activeBorderColor;
            set { _activeBorderColor = value; Invalidate(); }
        }

        public Color ArrowColor
        {
            get => _arrowColor;
            set { _arrowColor = value; Invalidate(); }
        }

        public int BorderThickness
        {
            get => _borderThickness;
            set { _borderThickness = value; Invalidate(); }
        }

        public Color FillColor
        {
            get => _fillColor;
            set { _fillColor = value; Invalidate(); }
        }

        public RoundedComboBox()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.UserPaint |
                    ControlStyles.SupportsTransparentBackColor, true); 

            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateRegionAndInvalidate();
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            bool isItemSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Kolor tła
            using (var backBrush = new SolidBrush(isItemSelected ? Color.DodgerBlue : Color.White))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            // Kolor tekstu
            Color textColor = isItemSelected ? Color.White : ForeColor;

            // Tekst elementu
            string text = GetItemText(Items[e.Index]);
            using (var textBrush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds,
                    new StringFormat { LineAlignment = StringAlignment.Center });
            }

            e.DrawFocusRectangle();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Usunięto base.OnPaint(e)!
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // Tło
            using (var path = CreateRoundPath(ClientRectangle))
            using (var brush = new SolidBrush(_fillColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Ramka
            using (var path = CreateRoundPath(ClientRectangle))
            using (var pen = new Pen(Focused ? _activeBorderColor : _borderColor, _borderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // Strzałka
            DrawCustomArrow(e.Graphics);

            // Tekst
            DrawText(e.Graphics);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
           //tak ma być bo tak
        }

        private void DrawCustomArrow(Graphics g)
        {
            Rectangle arrowRect = new Rectangle(Width - 25, 0, 20, Height);
            Point[] arrowPoints = {
                new Point(arrowRect.X + 7, arrowRect.Y + Height/2 - 2),
                new Point(arrowRect.X + 13, arrowRect.Y + Height/2 - 2),
                new Point(arrowRect.X + 10, arrowRect.Y + Height/2 + 3)
            };

            using (var brush = new SolidBrush(_arrowColor))
            {
                g.FillPolygon(brush, arrowPoints);
            }
        }

        private void DrawText(Graphics g)
        {
            Rectangle textRect = new Rectangle(
                8,
                3,
                Width - 30,
                Height - 6
            );

            if (SelectedIndex == -1 && !string.IsNullOrEmpty(_placeholder))
            {
                TextRenderer.DrawText(g, _placeholder, Font, textRect, Color.Gray, TextFormatFlags.VerticalCenter);
            }
            else if (SelectedItem != null)
            {
                TextRenderer.DrawText(g, GetItemText(SelectedItem), Font, textRect, ForeColor, TextFormatFlags.VerticalCenter);
            }
        }

        private GraphicsPath CreateRoundPath(Rectangle rect)
        {
            var path = new GraphicsPath();
            int diameter = _cornerRadius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void UpdateRegionAndInvalidate()
        {
            if (Width > 0 && Height > 0)
            {
                using (var path = CreateRoundPath(ClientRectangle))
                {
                    Region = new Region(path);
                }
            }
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegionAndInvalidate();
        }

        protected override void OnDropDown(EventArgs e)
        {
            UpdateRegionAndInvalidate();
            base.OnDropDown(e);
        }

        protected override void OnDropDownClosed(EventArgs e)
        {
            UpdateRegionAndInvalidate();
            base.OnDropDownClosed(e);
        }
    }
}