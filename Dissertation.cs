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
    public partial class Dissertation : Form
    {
        public Dissertation()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            int convertedNumber;
            if(Int32.TryParse(textBoxPoints.Text, out convertedNumber) && !String.IsNullOrEmpty(textBoxName.Text))
            {
                listBox1.Items.Add(textBoxName.Text + " - " + textBoxPoints.Text);
                textBoxName.Text = string.Empty;
                textBoxPoints.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ha kell számot adjon meg, vagy ne hagyjon szövegmezőt üresen.");
            }
        }

        private void buttonAvg_Click(object sender, EventArgs e)
        {
            double avg = 0;
            for(int i = 0; i < listBox1.Items.Count;i++)
            {
                string[] split = listBox1.Items[i].ToString().Split('-');
                avg += Convert.ToDouble(split[1].Trim());
            }
            labelAverage.Text = (avg / listBox1.Items.Count).ToString();
        }
    }
}
