using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public class TagButton : RoundedButton
    {
        protected bool hoveringClose = false;
        private Rectangle closeRect;

        [Category("Tag Button")]
        public event EventHandler CloseClicked;
        public bool isHoveringClose() {
            return this.hoveringClose;
        }
        public TagButton()
        {
            Text = "Rock Alone";
            AutoSize = true;
            BorderSize = 0;
            BorderRadius = 12;
            BackgroundColor = Color.FromArgb(44, 44, 44);
            HoverColor = Color.FromArgb(70, 70, 70);
            TextColor = Color.White;

            Padding = new Padding(10, 5, 10, 5);

            MouseMove += TagButton_MouseMove;
            MouseLeave += (s, e) => { hoveringClose = false; Invalidate(); };
            MouseClick += TagButton_MouseClick;
        }

        private void TagButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (hoveringClose && closeRect.Contains(e.Location))
            {
                CloseClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void TagButton_MouseMove(object sender, MouseEventArgs e)
        {
            bool newHoveringClose = closeRect.Contains(e.Location);
            if (newHoveringClose != hoveringClose)
            {
                hoveringClose = newHoveringClose;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var bgColor = hoveringClose ? Color.Red : (ClientRectangle.Contains(PointToClient(Cursor.Position)) ? HoverColor : BackgroundColor);
            using (var brush = new SolidBrush(bgColor))
            {
                using (GraphicsPath path = GetFigurePath(ClientRectangle, BorderRadius))
                {
                    g.FillPath(brush, path);
                }
            }

            // Use bold font for "×"
            Font closeFont = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            string closeChar = "✕";
            var closeSize = TextRenderer.MeasureText(closeChar, closeFont, Size, TextFormatFlags.NoPadding);

            // Stick "×" to the right edge
            int closeX = Width - closeSize.Width - Padding.Right;
            int closeY = (Height - closeSize.Height) / 2;
            closeRect = new Rectangle(closeX, closeY, closeSize.Width, closeSize.Height);

            var closeColor = TextColor;
            TextRenderer.DrawText(g, closeChar, closeFont, new Point(closeX, closeY), closeColor, TextFormatFlags.NoPadding);

            // Draw text aligned left of "×"
            var textSize = TextRenderer.MeasureText(Text, Font, Size, TextFormatFlags.NoPadding);
            int textX = Padding.Left;
            int textY = (Height - textSize.Height) / 2;
            TextRenderer.DrawText(g, Text, Font, new Point(textX, textY), TextColor, TextFormatFlags.NoPadding);
        }

    }
}
