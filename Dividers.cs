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
    public partial class Dividers : Form
    {
        public Dividers()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShowDividers_Click(object sender, EventArgs e)
        {
            listBoxDividers.Items.Clear();
            int convertedNumber;
            if (Int32.TryParse(textBoxNumber.Text,out convertedNumber))
            {
                bool minus = convertedNumber < 0;
                int counter = 1;
                while(counter < Math.Abs(convertedNumber)+1)
                {
                    if(convertedNumber % counter == 0)
                    {
                        int number = 
                        listBoxDividers.Items.Add(minus ? counter*-1 : counter);
                    }
                    counter++;
                }
            }
            else
            {
                MessageBox.Show("Nem számot adott meg. Adjon meg számot.");
            }
        }
    }
}
