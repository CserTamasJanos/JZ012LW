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
    public partial class Colorer : Form
    {
        private readonly Color genuineBackgroundColor;
        private Random randomColor = new Random();

        public Colorer()
        {
            InitializeComponent();

            genuineBackgroundColor = this.BackColor;

            foreach(object apB in this.Controls)
            {
                if(apB is PictureBox)
                {
                    (apB as PictureBox).BackColor = Color.FromArgb(randomColor.Next(1, 256), randomColor.Next(1,256), randomColor.Next(1,256));
                    (apB as PictureBox).Click += ChangeColor;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBasicState_Click(object sender, EventArgs e)
        {
            this.BackColor = genuineBackgroundColor;
        }

        private void ChangeColor (object sender, EventArgs e)
        {
            if(sender is PictureBox)
            {
                this.BackColor = (sender as PictureBox).BackColor;
            }
        }
    }
}
