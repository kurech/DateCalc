using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalc
{
    public partial class Form1 : Form
    {
        public string dayswithoutyears = "";
        public int result = 0;
        public int result1 = 0;
        public int Days;
        public int Years;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindDay_Click(object sender, EventArgs e)
        {
            try
            {
                DateCalculate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DateCalculate()
        {
            try
            {
                TimeSpan ts = new TimeSpan();
                DateTime date1 = DateTime.Parse(cmbDate1Year.Text + " " + cmbDate1Month.Text + " " + cmbDate1Day.Text + " ");
                DateTime date2 = DateTime.Parse(cmbDate2Year.Text + " " + cmbDate2Month.Text + " " + cmbDate2Day.Text + " ");
                if(date1 < date2)
                {
                    ts = date2.Subtract(date1);
                }
                if(date1 > date2)
                {
                    ts = date1.Subtract(date2);
                }
                result = int.Parse(ts.ToString("dd"));
                if (((date1.Year * 365 + date1.DayOfYear) - (date2.Year * 365 + date2.DayOfYear)) >= 0)
                {
                    Days = (date1.Year * 365 + date1.DayOfYear) - (date2.Year * 365 + date2.DayOfYear);
                    Years = Days / 365;
                    dayswithoutyears = (((date1.Year * 365 + date1.DayOfYear) - (date2.Year * 365 + date2.DayOfYear)) % 365).ToString();
                }
                if (((date1.Year * 365 + date1.DayOfYear) - (date2.Year * 365 + date2.DayOfYear)) < 0)
                {
                    Days = (date2.Year * 365 + date2.DayOfYear) - (date1.Year * 365 + date1.DayOfYear);
                    Years = Days / 365;
                    dayswithoutyears = (((date2.Year * 365 + date2.DayOfYear) - (date1.Year * 365 + date1.DayOfYear)) % 365).ToString();
                }

                label4.Text = Years + ", " + dayswithoutyears;
                label7.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDate1Year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmbDate1Year.Text = DateTime.Now.ToString("yyyy");
            cmbDate1Month.Text = DateTime.Now.ToString("MM");
            cmbDate1Day.Text = DateTime.Now.ToString("dd");
        }

        private void cmbDate2Day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
