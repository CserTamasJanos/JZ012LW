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
    public partial class Feladatok12 : Form
    {
        public Feladatok12()
        {
            InitializeComponent();
        }

        private void ButtonHelloWorld_Click(object sender, EventArgs e)
        {
            HelloWorld helloWorld = new HelloWorld();

            helloWorld.ShowDialog();
        }

        private void ButtonEvents_Click(object sender, EventArgs e)
        {
            ButtonEvents buttonEvents = new ButtonEvents();

            buttonEvents.ShowDialog();
        }

        private void buttonColorer_Click(object sender, EventArgs e)
        {
            Colorer colorer = new Colorer();
            colorer.ShowDialog();
        }

        private void buttonTextFormat_Click(object sender, EventArgs e)
        {
            TextFormat textFormat = new TextFormat();
            textFormat.ShowDialog();
        }

        private void buttonCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOperations_Click(object sender, EventArgs e)
        {
            Operations operation = new Operations();
            operation.ShowDialog();
        }

        private void buttonInterval_Click(object sender, EventArgs e)
        {
            Interval interval = new Interval();
            interval.ShowDialog();
        }

        private void buttonDice_Click(object sender, EventArgs e)
        {
            Dice dice = new Dice();
            dice.ShowDialog();
        }

        private void buttonStonePaperScissors_Click(object sender, EventArgs e)
        {
            StonePaperScissors stonePaperScissors = new StonePaperScissors();
            stonePaperScissors.ShowDialog();
        }

        private void buttonDividers_Click(object sender, EventArgs e)
        {
            Dividers dividers = new Dividers();
            dividers.ShowDialog();
        }

        private void buttonListBox_Click(object sender, EventArgs e)
        {
            ListBox listbox = new ListBox();
            listbox.ShowDialog();

        }

        private void buttonHundredRandom_Click(object sender, EventArgs e)
        {
            HundredRandom hundredRandom = new HundredRandom();
            hundredRandom.ShowDialog();
        }

        private void buttonDissertation_Click(object sender, EventArgs e)
        {
            Dissertation dissertation = new Dissertation();
            dissertation.ShowDialog();
        }

        private void buttonQuadraticEquation_Click(object sender, EventArgs e)
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            quadraticEquation.ShowDialog();
        }

        private void buttonPythagorean_Click(object sender, EventArgs e)
        {
            Pythagorean pythagorean = new Pythagorean();
            pythagorean.ShowDialog();
        }

        private void buttonSmiley_Click(object sender, EventArgs e)
        {
            Smiley smiley = new Smiley();
            smiley.ShowDialog();
        }
    }
}
