using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(aAmount.Text);

            if (aFromCombo1.SelectedItem == "RUB" && aToCombo2.SelectedItem == "USD")
            {
                double conver = i / 88; // Курс рубля к доллару
                aDisplay.Text = "Converted Amount : " + conver + "\t USD";
            }
            if (aFromCombo1.SelectedItem == "USD" && aToCombo2.SelectedItem == "RUB")
            {
                double conver = i * 88; // Курс доллара к рублю
                aDisplay.Text = "Converted Amount : " + conver + "\t RUB";
            }

            

        }
    }
}

