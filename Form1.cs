using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected short Days = 0;
        protected short Months = 0;
        protected short Years = 0;

        protected TimeSpan ts = TimeSpan.Zero;

        private void CalculateAge()
        {
            DateTime CurrentDate = dtCurrentDate.Value;
            DateTime DateOfBirth = dtBirthDate.Value;

            short _Years = (short)CurrentDate.Year;
            short _Months = (short)CurrentDate.Month;
            short _Days = (short)CurrentDate.Day;

            while (_Days < DateOfBirth.Day)
            {
                _Months -= 1;
                _Days += 30;
            }

            _Months = (short)(_Months < 0 ? 0 : _Months);

            _Days = (short)(_Days - DateOfBirth.Day);

            while (_Months < DateOfBirth.Month)
            {
                _Years -= 1;
                _Months += 12;
            }

            _Years = (short)(_Years < 0 ? 0 : _Years);

            _Months = (short)(_Months - DateOfBirth.Month);
            _Years = (short)(_Years - DateOfBirth.Year);

            Days = _Days;
            Months = _Months;
            Years = _Years;

            ts = (dtCurrentDate.Value - dtBirthDate.Value);
        }
        private void UpdateAgeInfo()
        {
            lblYears.Text = Years.ToString();
            lblMonths.Text = Months.ToString();
            lblDays.Text = Days.ToString();

            lblTotalDays.Text = Convert.ToInt32(ts.TotalDays).ToString();
            lblTotalHours.Text = Convert.ToInt32(ts.TotalHours).ToString();
            lblTotalMinutes.Text = Convert.ToInt32(ts.TotalMinutes).ToString();
            lblTotalSeconds.Text = Convert.ToInt32(ts.TotalSeconds).ToString();
        }

        private void ResetAgeInfo()
        {
            Days = 0;
            Months = 0;
            Years = 0;

            ts = TimeSpan.Zero;

            lblYears.Text = "0";
            lblMonths.Text = "0";
            lblDays.Text = "0";

            lblTotalDays.Text = "0";
            lblTotalHours.Text = "0";
            lblTotalMinutes.Text = "0";
            lblTotalSeconds.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtCurrentDate.Value = DateTime.Now;
            dtCurrentDate.MinDate = DateTime.Now;

            dtBirthDate.MaxDate = DateTime.Now;
            dtBirthDate.Value = DateTime.Now;
        }

        private void ResetButtonsDefault()
        {
            chkCustomDate.Checked = false;
        }

        private void chkCustomDate_CheckedChanged(object sender, EventArgs e)
        {
            dtCurrentDate.Enabled = chkCustomDate.Checked;
            dtCurrentDate.TabStop = chkCustomDate.Checked;

            if (chkCustomDate.Checked)
            {
                dtCurrentDate.MinDate = dtBirthDate.Value;
                dtCurrentDate.Value = dtCurrentDate.MinDate;
            }

            else
            {
                dtBirthDate.MaxDate = DateTime.Now;
                dtBirthDate.Value = DateTime.Now;

                dtCurrentDate.Value = DateTime.Now;
                dtCurrentDate.MinDate = DateTime.Now;
            }

        }

        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (chkCustomDate.Checked)
            {
                dtCurrentDate.MinDate = dtBirthDate.Value;
                dtCurrentDate.Value = dtCurrentDate.MinDate;
            }
        }

        private void btnCaluculate_Click(object sender, EventArgs e)
        {
            if (dtBirthDate.Value > dtCurrentDate.Value)
            {
                errorProvider1.SetIconAlignment(dtBirthDate, ErrorIconAlignment.MiddleRight);

                errorProvider1.SetError(this.dtBirthDate, "Invaled date!");
            }

            else
            {
                CalculateAge();
                UpdateAgeInfo();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetAgeInfo();
            ResetButtonsDefault();
        }

    }
}
