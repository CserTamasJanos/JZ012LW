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
    public partial class Dice : Form
    {
        public Dice()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThrow_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = string.Empty;
            int convertedNumber;
            Random randNum = new Random();

            if(Int32.TryParse(textBoxGivenNumber.Text, out convertedNumber) && convertedNumber > 0 && convertedNumber <= 100) 
            {
                for (int i = 0; i < convertedNumber; i++)
                {
                    if(i == 0)
                    {
                        textBoxResult.Text = randNum.Next(1,6).ToString();
                    }
                    else
                    {
                        textBoxResult.Text += $", {randNum.Next(1,6).ToString()}";
                    }
                }
            }
            else
            {
                MessageBox.Show("A dobásokhoz számot kell megadnia, a szám nagyobb kell, hogy legyenmint nulla és 100-nál kissebb legyen.");
            }
        }
    }
}
