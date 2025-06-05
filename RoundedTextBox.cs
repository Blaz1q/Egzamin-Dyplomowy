using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace egzamin_dyplomowy;

[DefaultEvent("_TextChanged")]
public partial class RoundedTextBox : UserControl
{
    //─ Fields ──────────────────────────────────────────────────────────
    private Color borderColor = Color.MediumSlateBlue;
    private Color borderFocusColor = Color.HotPink;
    private Color invalidBorderColor = Color.Red;
    private Color invalidBorderFocusColor = Color.Orange;
    private int borderSize = 2;
    private bool underlinedStyle = false;
    private bool isFocused = false;
    public bool isValid = true;

    private int borderRadius = 0;
    private Color placeholderColor = Color.DarkGray;
    private string placeholderText = "";
    private bool isPlaceholder = false;
    private System.Windows.Forms.TextBox textBox1;
    private bool isPasswordChar = false;

    //─ Constructor ─────────────────────────────────────────────────────
    public RoundedTextBox()
    {
        InitializeComponent();
    }

    //─ Private methods ─────────────────────────────────────────────────
    private void SetPlaceholder()
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
        {
            isPlaceholder = true;
            textBox1.Text = placeholderText;
            textBox1.ForeColor = placeholderColor;
            if (isPasswordChar)
                textBox1.UseSystemPasswordChar = false;
        }
    }

    private void RemovePlaceholder()
    {
        if (isPlaceholder && placeholderText != "")
        {
            isPlaceholder = false;
            textBox1.Text = "";
            textBox1.ForeColor = this.ForeColor;
            if (isPasswordChar)
                textBox1.UseSystemPasswordChar = true;
        }
    }

    private GraphicsPath GetFigurePath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float curveSize = radius * 2F;
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }

    private void SetTextBoxRoundedRegion()
    {
        GraphicsPath pathTxt;
        if (Multiline)
        {
            pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
            textBox1.Region = new Region(pathTxt);
        }
        else
        {
            pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
            textBox1.Region = new Region(pathTxt);
        }
        pathTxt.Dispose();
    }

    private void UpdateControlHeight()
    {
        if (textBox1.Multiline == false)
        {
            int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
            textBox1.Multiline = true;
            textBox1.MinimumSize = new Size(0, txtHeight);
            textBox1.Multiline = false;
            this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
        }
    }

    //─ Properties ──────────────────────────────────────────────────────
    [Category("RJ Code Advance")]
    public Color BorderColor
    {
        get => borderColor;
        set { borderColor = value; Invalidate(); }
    }
    public override Color BackColor
    {
        get
        {
            return base.BackColor;
        }
        set
        {
            base.BackColor = value;
            textBox1.BackColor = value;
        }
    }

    public override Color ForeColor
    {
        get
        {
            return base.ForeColor;
        }
        set
        {
            base.ForeColor = value;
            textBox1.ForeColor = value;
        }
    }
    [Category("RJ Code Advance")]
    public Color BorderFocusColor
    {
        get => borderFocusColor;
        set => borderFocusColor = value;
    }
    [Category("RJ Code Advance")]
    public Color InvalidBorderFocusColor
    {
        get => invalidBorderFocusColor;
        set => invalidBorderFocusColor = value;
    }
    [Category("RJ Code Advance")]
    public Color InvalidBorderColor
    {
        get => invalidBorderColor;
        set => invalidBorderColor = value;
    }


    [Category("RJ Code Advance")]
    public int BorderSize
    {
        get => borderSize;
        set { if (value >= 1) { borderSize = value; Invalidate(); } }
    }

    [Category("RJ Code Advance")]
    public bool UnderlinedStyle
    {
        get => underlinedStyle;
        set { underlinedStyle = value; Invalidate(); }
    }
    [Category("RJ Code Advance")]
    public string Texts
    {
        get
        {
            if (isPlaceholder) return "";
            return textBox1.Text;
        }
        set
        {
            textBox1.Text = value;
            SetPlaceholder();
        }
    }
    [Category("RJ Code Advance")]
    public bool PasswordChar
    {
        get => isPasswordChar;
        set
        {
            isPasswordChar = value;
            if (!isPlaceholder) textBox1.UseSystemPasswordChar = value;
        }
    }

    [Category("RJ Code Advance")]
    public bool Multiline
    {
        get => textBox1.Multiline;
        set => textBox1.Multiline = value;
    }

    [Category("RJ Code Advance")]
    public override Font Font
    {
        get => base.Font;
        set { base.Font = value; textBox1.Font = value; if (this.DesignMode) UpdateControlHeight(); }
    }
    [Category("RJ Code Advance")]
    public int BorderRadius
    {
        get => borderRadius;
        set { if (value >= 0) { borderRadius = value; Invalidate(); } }
    }

    [Category("RJ Code Advance")]
    public Color PlaceholderColor
    {
        get => placeholderColor;
        set { placeholderColor = value; if (isPlaceholder) textBox1.ForeColor = value; }
    }

    [Category("RJ Code Advance")]
    public string PlaceholderText
    {
        get => placeholderText;
        set { placeholderText = value; textBox1.Text = ""; SetPlaceholder(); }
    }

    // --- NEW: Expose the internal TextBox's KeyDown event ---
    [Category("RJ Code Advance")]
    public event KeyEventHandler _KeyDown;


    //─ Overridden methods ─────────────────────────────────────────────
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        if (this.DesignMode) UpdateControlHeight();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        UpdateControlHeight();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graph = e.Graphics;
        graph.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rectBorder = this.ClientRectangle;
        int smoothSize = borderSize > 0 ? borderSize : 1;
        Color BorderColor = isValid ? borderColor : invalidBorderColor;
        using (Pen penSmooth = new Pen(this.Parent.BackColor, smoothSize))
        using (Pen penBorder = new Pen(BorderColor, borderSize))
        {
            penBorder.Alignment = PenAlignment.Center;
            if (isFocused && isValid)
            {
                penBorder.Color = borderFocusColor;
            }
            else if (isFocused && !isValid)
            {
                penBorder.Color = invalidBorderFocusColor;
            }


            if (borderRadius > 1) // Rounded TextBox
            {
                Rectangle rectBorderInflated = Rectangle.Inflate(rectBorder, -borderSize, -borderSize);

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorder, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorderInflated, borderRadius - borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    graph.DrawPath(penSmooth, pathBorderSmooth);

                    if (underlinedStyle)
                    {
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.SmoothingMode = SmoothingMode.AntiAlias;
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }

                if (borderRadius > 15)
                    SetTextBoxRoundedRegion();
            }
            else // Square corners
            {
                this.Region = new Region(rectBorder); // Reset region for normal rectangle
                if (underlinedStyle)
                {
                    graph.SmoothingMode = SmoothingMode.None;
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else
                {
                    graph.SmoothingMode = SmoothingMode.None;
                    using (Pen penBorderInset = new Pen(penBorder.Color, borderSize))
                    {
                        penBorderInset.Alignment = PenAlignment.Inset;
                        graph.DrawRectangle(penBorderInset, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
    }


    //─ Event hook-ups ──────────────────────────────────────────────────
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        _TextChanged?.Invoke(sender, e);
    }

    private void textBox1_Enter(object sender, EventArgs e)
    {
        isFocused = true; this.Invalidate(); RemovePlaceholder();
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
        isFocused = false;
        this.Invalidate();
        SetPlaceholder();
    }

    private void textBox1_Click(object sender, EventArgs e)
    {
        this.OnClick(e);
    }
    private void textBox1_MouseEnter(object sender, EventArgs e) => OnMouseEnter(e);
    private void textBox1_MouseLeave(object sender, EventArgs e) => OnMouseLeave(e);

    private void InitializeComponent()
    {
        textBox1 = new System.Windows.Forms.TextBox();
        SuspendLayout();
        //
        // textBox1
        //
        textBox1.BackColor = SystemColors.ControlLightLight;
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Dock = DockStyle.Fill;
        textBox1.Location = new Point(7, 7);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(236, 20);
        textBox1.TabIndex = 0;
        textBox1.Enter += textBox1_Enter;
        textBox1.Leave += textBox1_Leave;
        textBox1.KeyDown += textBox1_KeyPress;  //dla entera
        //
        // RoundedTextBox
        //
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(textBox1);
        Name = "RoundedTextBox";
        Padding = new Padding(7);
        Size = new Size(250, 30);
        ResumeLayout(false);
        PerformLayout();
    }

    //enter
    private void textBox1_KeyPress(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true; // By windows nie krzyczał jak klikasz enter
            _KeyDown?.Invoke(this, e); 
        }
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e) => OnKeyPress(e);

    //─ Default TextChanged event ─────────────────────────────────────
    public event EventHandler _TextChanged;

}