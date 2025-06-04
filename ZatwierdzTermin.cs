using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class ZatwierdzTermin : Form
    {
        private readonly OperacjeNaTerminach _operacje = Dane.Terminy;
        private readonly TerminarzControl _terminarz; // To refresh the main calendar view

        public ZatwierdzTermin(TerminarzControl terminarz)
        {
            InitializeComponent();
            _terminarz = terminarz;
            LoadPendingTerms(); // Load terms when the form is initialized
        }

        private void LoadPendingTerms()
        {
            flpPendingTerms.Controls.Clear(); // Clear existing controls

            // Get terms that are pending approval, ordered by date and time
            var pendingTerms = _operacje.getTerminy()
                                        .Where(t => t.Status == "OczekujeNaZatwierdzenie")
                                        .OrderBy(t => t.Data)
                                        .ThenBy(t => t.Godzina)
                                        .ToList();

            if (!pendingTerms.Any())
            {
                // Display a message if there are no pending terms
                var lbl = new Label
                {
                    Text = "Brak terminów do zatwierdzenia.",
                    AutoSize = true,
                    Margin = new Padding(5)
                };
                flpPendingTerms.Controls.Add(lbl);
            }

            foreach (var termin in pendingTerms)
            {
                // Create a rounded panel for each pending term
                var panelTermin = new RoundedPanel
                {
                    Width = flpPendingTerms.Width - 10, // Adjust width dynamically
                    Height = 70,
                    BackColor = Color.LightGray,
                    Margin = new Padding(3),
                    CornerRadius = 20
                };

                // Label to display term details
                var lblInfo = new Label
                {
                    Text = $"Data: {termin.Data.ToShortDateString()}, Godzina: {termin.Godzina.ToString("HH:mm")}\nStatus: {termin.Status}",
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                panelTermin.Controls.Add(lblInfo);

                // "Approve" button
                var btnApprove = new Button
                {
                    Text = "Zatwierdź",
                    Tag = termin, // Store the Termin object for easy access in click handler
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(panelTermin.Width - 180, 20),
                    Size = new Size(80, 30)
                };
                btnApprove.Click += BtnApprove_Click;
                panelTermin.Controls.Add(btnApprove);

                // "Reject" button
                var btnReject = new Button
                {
                    Text = "Odrzuć",
                    Tag = termin, // Store the Termin object
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(panelTermin.Width - 90, 20),
                    Size = new Size(80, 30)
                };
                btnReject.Click += BtnReject_Click;
                panelTermin.Controls.Add(btnReject);

                flpPendingTerms.Controls.Add(panelTermin);
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Termin termin)
            {
                termin.Status = "Zatwierdzony"; // Change status to Approved
                _operacje.ZaktualizujTerminStatus(termin); // Update the term in your operations class
                
                MessageBox.Show($"Termin {termin.Data.ToShortDateString()} {termin.Godzina.ToString("HH:mm")} został zatwierdzony.", "Zatwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LoadPendingTerms(); // Reload the list to remove the approved term
                _terminarz.initTerminy();

            }
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Termin termin)
            {
                
                termin.Status = "Odrzucony"; // Change status to Rejected
                _operacje.ZaktualizujTerminStatus(termin); // Update the term in your operations class
                
                MessageBox.Show($"Termin {termin.Data.ToShortDateString()} {termin.Godzina.ToString("HH:mm")} został odrzucony.", "Odrzucenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LoadPendingTerms(); // Reload the list to remove the rejected term
                _terminarz.initTerminy();

            }
        }
    }
}