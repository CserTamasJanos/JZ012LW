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
    public partial class TextFormat : Form
    {
        private const string BasicText = "Igazítandó szöveg.";
        private readonly Color BasicBackgroundColor;
        private readonly Color BasicForeColor;
        private Font basiclFont;
        private float actualFontSize;

        public TextFormat()
        {
            InitializeComponent();
            labelAdjust.Text = BasicText;
            BasicBackgroundColor = this.BackColor;
            BasicForeColor = labelAdjust.ForeColor;
            basiclFont = labelAdjust.Font;
            actualFontSize = labelAdjust.Font.Size;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            labelAdjust.Text = string.Empty;
        }

        private void buttonBlueLetter_Click(object sender, EventArgs e)
        {
            labelAdjust.ForeColor = Color.Blue;
        }

        private void buttonWhiteBackground_Click(object sender, EventArgs e)
        {
            labelAdjust.BackColor = Color.White;
        }

        private void buttonLeftCenter_Click(object sender, EventArgs e)
        {
            labelAdjust.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void buttonCenterCenter_Click(object sender, EventArgs e)
        {
            labelAdjust.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void buttonRightCenter_Click(object sender, EventArgs e)
        {
            labelAdjust.TextAlign = ContentAlignment.MiddleRight;
        }

        private void buttonBigLetter_Click(object sender, EventArgs e)
        {
            labelAdjust.Text = labelAdjust.Text.ToUpper();
        }

        private void buttonEncrease_Click(object sender, EventArgs e)
        {
            labelAdjust.Font = new Font(basiclFont.FontFamily,actualFontSize++);
        }

        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            labelAdjust.Font = new Font(basiclFont.FontFamily,actualFontSize--);
        }

        private void buttonBasicState_Click(object sender, EventArgs e)
        {
            labelAdjust.Font = basiclFont;
            labelAdjust.BackColor = BasicBackgroundColor;
            labelAdjust.TextAlign = ContentAlignment.TopLeft;
            labelAdjust.ForeColor = BasicForeColor;
            labelAdjust.Text = BasicText;
        }
    }
}
