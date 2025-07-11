﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace egzamin_dyplomowy
{
    public partial class KalendarzDzien : UserControl
    {
        public event Action<DateOnly> OnDateClicked;
        DateOnly _Date;
        bool _faded = false;
        bool _selected = false;
        Color defaultbackcolor;
        public KalendarzDzien(DateOnly date, bool faded = false)
        {
            InitializeComponent();
            _Date = date;
            _faded = faded;
            daylabel.Text = date.Day.ToString();
            defaultbackcolor = this.BackColor;

            if (_faded)
                this.ForeColor = Color.Gray;
        }
        public void ResetSelection() {
            _selected = false;
            this.BackColor = defaultbackcolor;
        }
        public void Select() {
            _selected = true;
            this.BackColor = Color.Orange;
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            if (!_faded) {
                OnDateClicked?.Invoke(_Date);
                _selected = true;
                base.BackColor = Color.Orange;
            }
        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.White;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //base.BackColor = Color.White;
        }

        private void daylabel_MouseEnter(object sender, EventArgs e)
        {
            if (!_faded)
                base.BackColor = Color.Red;
        }

        private void daylabel_MouseLeave(object sender, EventArgs e)
        {
            if (!_faded) {
                if (_selected)
                {
                    base.BackColor = Color.Orange;
                }
                else {
                    base.BackColor = defaultbackcolor;
                }
            }
                
        }

        private void daylabel_Click(object sender, EventArgs e)
        {
            panel1_Click(sender, e);
        }
    }
}
