using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperationsForF12;

namespace Feladatok12
{
    public partial class Pythagorean : Form
    {
        private int actualCountWay = 0;
        private long convertedNumber1;
        private long convertedNumber2;

        private bool TextBoxCheck()        
        {
            if(!string.IsNullOrEmpty(textBoxClamp1.Text) && !string.IsNullOrEmpty(textBoxClamp2.Text) && !string.IsNullOrEmpty(textBoxHypotenuse.Text))
            {
                actualCountWay = -1;
                return false;
            }
            else if (Int64.TryParse(textBoxClamp1.Text, out convertedNumber1) && Int64.TryParse(textBoxClamp2.Text, out convertedNumber2))
            {
                actualCountWay = 1;
                return true;
            }
            else if (Int64.TryParse(textBoxClamp1.Text, out convertedNumber1) && Int64.TryParse(textBoxHypotenuse.Text, out convertedNumber2))
            {
                actualCountWay = 2;
                return true;
            }
            else if(Int64.TryParse(textBoxClamp2.Text, out convertedNumber1) && Int64.TryParse(textBoxHypotenuse.Text, out convertedNumber2))
            {
                actualCountWay = 3;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pythagorean()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            bool hypothenuseIsProbablyWrong;
            if (TextBoxCheck())
            {
                listBoxResult.Items.Add(OperationsForF12.Operations.Pythagorean(convertedNumber1,convertedNumber2,
                                            actualCountWay,out hypothenuseIsProbablyWrong));
                if(hypothenuseIsProbablyWrong && actualCountWay > 1)
                {
                    MessageBox.Show("Az átfogómérete amit megadott lehet, hogy nem jó, nézze át a számokat.");
                }
            }
            else
            {                
                MessageBox.Show(actualCountWay == -1 ? "Ha mind a három mezőt kitölti, akkor mit szeretne kiszámolni?" :
                                                "Számot kell megadni, két mezőnek kitöltve kell lennie");
            }
        }
    }
}
