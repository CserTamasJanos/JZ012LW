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
    public partial class Operations : Form
    {
        const string basicResultText = "A művelet eredménye";

        public Operations()
        {
            InitializeComponent();

            buttonAdding.Click += Count_Clik;
            buttonAdding.Tag = 1;
            buttonSubstraction.Click += Count_Clik;
            buttonSubstraction.Tag = 2;
            buttonMultiplication.Click += Count_Clik;
            buttonMultiplication.Tag = 3;
            buttonDivision.Click += Count_Clik;
            buttonDivision.Tag = 4;

            textBoxFirstNumber.TextChanged += ClearResultTextBox;
            textBoxSecondNumber.TextChanged += ClearResultTextBox;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Count_Clik(object sender, EventArgs e)
        {
            Button actualButton = (Button)sender;
            Dictionary<int, string> resultTypes = new Dictionary<int, string>() { { 1, "Az összeadás" },
                                            { 2, "A kivonás" },{ 3, "A szorzás" }, { 4, "Az osztás" } };

            int convertedNumberOne = 0;
            int convertedNumberTwo = 0;

            if(Int32.TryParse(textBoxFirstNumber.Text, out convertedNumberOne) && Int32.TryParse(textBoxSecondNumber.Text,out convertedNumberTwo))
            {
                textBoxResult.Text = OperationsForF12.Operations.Counter(convertedNumberOne, convertedNumberTwo,
                                        Convert.ToInt32(actualButton.Tag)).ToString();
                labelResult.Text = $"{resultTypes[Convert.ToInt32(actualButton.Tag)]} eredménye:";
            }
            else
            {
                MessageBox.Show("Nem számot adott meg, nézze át a bevitt adatokat.");
            }
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            textBoxFirstNumber.Text = textBoxSecondNumber.Text = textBoxResult.Text = string.Empty;
            labelResult.Text = basicResultText;
        }

        private void ClearResultTextBox (object sender, EventArgs e)
        {
            textBoxResult.Text = string.Empty;
        }
    }
}
