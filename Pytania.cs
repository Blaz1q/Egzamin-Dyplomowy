using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace egzamin_dyplomowy
{
    public partial class Pytania : UserControl
    {
        private List<Pytanie> wszystkiePytania = Dane.Pytania.getPytania();
        private RoundedButton mojRoundedButton;
        public event Action<Pytanie> OnEdytuj;
        public event Action OnDodaj;
        public Pytania()
        {
            InitializeComponent();
            UstawPytania();
           
            mojRoundedButton = new RoundedButton
            {
                Width = 140,
                Height = 40,
                Location = new Point(306, 70),
                Text = "Dodaj pytanie",
                BorderRadius = 20,
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White
            };

            mojRoundedButton.Click += (s, e) => OnDodaj?.Invoke();

            this.Controls.Add(mojRoundedButton);


            comboKierunki.SelectedIndexChanged += comboKierunki_SelectedIndexChanged;
        }

        public void UstawPytania()
        {
            comboKierunki.Items.Clear();
            comboKierunki.Items.AddRange(wszystkiePytania
                .Select(p => p.Kierunek)
                .Distinct()
                .ToArray());
        }

        private void comboKierunki_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybrany = comboKierunki.SelectedItem.ToString();
            var filtrowane = wszystkiePytania.Where(p => p.Kierunek == wybrany).ToList();
            flowLayoutPanel1.Controls.Clear();

            foreach (var pytanie in filtrowane)
            {
                flowLayoutPanel1.Controls.Add(StworzPanelPytania(pytanie));
            }
        }

        private Panel StworzPanelPytania(Pytanie pytanie)
        {
            var panel = new Panel
            {
                Height = 50,
                Width = flowLayoutPanel1.Width - 30,
                BackColor = Color.LightGray,
                Margin = new Padding(5),
                BorderStyle = BorderStyle.None
            };

            var lbl = new Label
            {
                Text = $"{pytanie.Id}. {pytanie.GetTresc()}",
                AutoSize = false,
                Width = panel.Width - 100,
                Height = panel.Height,
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new Point(10, 0),
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            var btnEdytuj = new Button
            {
                Width = 40,
                Height = 30,
                Location = new Point(panel.Width - 50, 10),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                Image = Properties.Resources.Icon,
                ImageAlign = ContentAlignment.MiddleCenter,
                Text = ""
            };

            btnEdytuj.Click += (object sender, EventArgs e) =>
            {
                OnEdytuj?.Invoke(pytanie);
            };

            panel.Controls.Add(lbl);
            panel.Controls.Add(btnEdytuj);
            ZaokraglijRogi(panel, 15);
            return panel;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Pytania_Load(object sender, EventArgs e)
        {
        }
        private void openEdytujPytaniak(object sender, EventArgs e) { 
        
        }
        private void ZaokraglijRogi(Control control, int promien)
        {
            GraphicsPath path = new GraphicsPath();
            int arcSize = promien * 2;

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, arcSize, arcSize), 180, 90);
            path.AddArc(new Rectangle(control.Width - arcSize, 0, arcSize, arcSize), 270, 90);
            path.AddArc(new Rectangle(control.Width - arcSize, control.Height - arcSize, arcSize, arcSize), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - arcSize, arcSize, arcSize), 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboKierunki_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}