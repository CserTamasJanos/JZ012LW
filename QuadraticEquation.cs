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
    public partial class QuadraticEquation : Form
    {
        public QuadraticEquation()
        {
            InitializeComponent();
        }

        private void QuadraticEquation_Load(object sender, EventArgs e)
        {

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            long convertedA;
            long convertedB;
            long convertedC;

            if(Int64.TryParse(textBoxA.Text, out convertedA) && Int64.TryParse(textBoxB.Text, out convertedB) && Int64.TryParse(textBoxC.Text, out convertedC))
            {
                double[] result = OperationsForF12.Operations.QuadraticEquation(convertedA, convertedB, convertedC);
                labelResultX1.Text = Double.IsNaN(result[0]) ? "Az eredmény nem szám" : result[0].ToString();
                labelResultX2.Text = Double.IsNaN(result[1]) ? "Az eredmény nem szám" : result[1].ToString();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
