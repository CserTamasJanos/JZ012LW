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
    public partial class HundredRandom : Form
    {
        public HundredRandom()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGenerateNumbers_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = string.Empty;
            const int NumberOfTurns = 100;
            int convertedNumberSmallest;
            int convertedNumberBiggest;
            Random randomNumber = new Random();

            if (Int32.TryParse(textBoxSmallest.Text, out convertedNumberSmallest) && Int32.TryParse(textBoxBiggest.Text,out convertedNumberBiggest))
            {
                for(int i = 0; i < NumberOfTurns; i++)
                {
                    if(i == 0)
                    {
                        textBoxResult.Text = randomNumber.Next(convertedNumberSmallest,convertedNumberBiggest).ToString();
                    }
                    else
                    {
                        textBoxResult.Text += $", {randomNumber.Next(convertedNumberSmallest,convertedNumberBiggest)}";
                    }
                }
            }
            else
            {
                MessageBox.Show("Nem számot adott meg, adjon meg számot.");
            }
        }
    }
}
