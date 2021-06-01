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
    public partial class Smiley : Form
    {
        private int actualSmileyX;
        private int actualSmileyY;
        readonly Color PictureBoxBackColor;
        readonly Color TextBoxBackColor;
        private Random randomsmiley = new Random();
        private bool dissapeared = false; 

        public Smiley()
        {
            InitializeComponent();

            buttonDisapear.Enabled = true;
            buttonComeBack.Enabled = false;

            PictureBoxBackColor = pictureBoxContainer.BackColor;
            TextBoxBackColor = textBoxFavoriteText.BackColor;

            actualSmileyX = (pictureBoxContainer.Width / 2) - (OperationsForF12.Operations.BitmapSize / 2);
            actualSmileyY = (pictureBoxContainer.Height / 2) - (OperationsForF12.Operations.BitmapSize / 2);

            DrawSmiley(false,false);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxContainer_Click(object sender, EventArgs e)
        {
            actualSmileyX = randomsmiley.Next(0, pictureBoxContainer.Width - OperationsForF12.Operations.BitmapSize);
            actualSmileyY = randomsmiley.Next(0, pictureBoxContainer.Height - OperationsForF12.Operations.BitmapSize);

            DrawSmiley(false,false);
        }

        private void pictureBoxContainer_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.X >= actualSmileyX && e.X <= actualSmileyX + OperationsForF12.Operations.BitmapSize &&
                e.Y >= actualSmileyY && e.Y <= actualSmileyY + OperationsForF12.Operations.BitmapSize)
            {
                DrawSmiley(false,true);
            }
            else
            {
                DrawSmiley(false,false);
            }
        }

        private void DrawSmiley(bool clear,bool wink)
        {
            if(!dissapeared)
            {
                pictureBoxContainer.Image = OperationsForF12.Operations.DrawSmiley(clear, wink, PictureBoxBackColor,
                    actualSmileyX, actualSmileyY, pictureBoxContainer.Width, pictureBoxContainer.Height);
            }  
        }

        private void buttonDisapear_Click(object sender, EventArgs e)
        {
            DrawSmiley(true,false);
            buttonComeBack.Enabled = dissapeared = true;
            buttonDisapear.Enabled = !buttonComeBack.Enabled;
        }

        private void buttonComeBack_Click(object sender, EventArgs e)
        {
            buttonDisapear.Enabled = true;
            buttonComeBack.Enabled = dissapeared = !buttonDisapear.Enabled;
            DrawSmiley(false,false);
        }

        private void textBoxFavoriteText_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxFavoriteText.Text))
            {
                textBoxFavoriteText.BackColor = TextBoxBackColor;
            }
            else
            {
                textBoxFavoriteText.BackColor = Color.FromArgb(randomsmiley.Next(0, 256), randomsmiley.Next(0, 256), randomsmiley.Next(0, 256));
            }
        }
    }
}
