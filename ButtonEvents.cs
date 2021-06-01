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
    public partial class ButtonEvents : Form
    {
        Random randomColor = new Random();
        readonly Color buttonQenuineColor;
        public ButtonEvents()
        {
            InitializeComponent();

            buttonQenuineColor = buttonForPractice.BackColor;
        }

        private void buttonForPractice_Click(object sender, EventArgs e)
        {
            buttonForPractice.Text = buttonForPractice.Text.ToUpper();
        }

        private void buttonForPractice_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(randomColor.Next(1, 256), randomColor.Next(1, 256), randomColor.Next(1 ,256));
        }

        private void buttonForPractice_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $" Egér koordinátái: X: {e.X} Y :{e.Y}";
        }

        private void buttonForPractice_MouseLeave(object sender, EventArgs e)
        {
            buttonForPractice.Text = buttonForPractice.Text.ToLower();
            this.BackColor = buttonQenuineColor;
        }
    }
}
