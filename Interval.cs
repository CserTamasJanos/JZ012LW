using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feladatok12
{
    public partial class Interval : Form
    {
        public Interval()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOperate_Click(object sender, EventArgs e)
        {
            int convertedNumberMin;
            int convertedNumberMax;
            int convertedGivenNumber;

            if (Int32.TryParse(textBoxLowerLimit.Text, out convertedNumberMin) &&
                Int32.TryParse(textBoxUpperLimit.Text,out convertedNumberMax) &&
                Int32.TryParse(textBoxGivenNumber.Text,out convertedGivenNumber))
            {
                labelResult.Text = convertedGivenNumber > convertedNumberMin && convertedGivenNumber < convertedNumberMax ?
                    "Benne van az intervallumban" : "Nincs benne az intervallumban";
            }
            else
            {
                MessageBox.Show("Bevilteli mező nem lehet üres, az intevallum számításához számot kell megadnia.");
            }
        }
    }
}
