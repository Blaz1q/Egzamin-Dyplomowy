﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    
    public partial class main_panel : Form
    {
        private String token = "";
        public main_panel(string token)
        {
            InitializeComponent();
            this.token = token;
        }

        private void main_panel_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Show the main form again when the second form is closed
            Form1 mainForm = Application.OpenForms["Form1"] as Form1;
            if (mainForm != null)
            {
                mainForm.Close();
            }
        }
    }
}
