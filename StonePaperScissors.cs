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
    public partial class StonePaperScissors : Form
    {
        private List<Button> buttons = new List<Button>();
        private int playerResult = 0;
        private int computerResult = 0;
        private readonly Color basicBackolor;
        public StonePaperScissors()
        {
            InitializeComponent();

            basicBackolor = buttonStone.BackColor;

            buttonStone.Click += GamerButtonClicked;
            buttons.Add(buttonStone);
            buttonPaper.Click += GamerButtonClicked;
            buttons.Add(buttonPaper);
            buttonScissors.Click += GamerButtonClicked;
            buttons.Add(buttonScissors);
            buttonCStone.Enabled = buttonCPaper.Enabled = buttonCScissors.Enabled = false;

            buttons.Add(buttonCStone);
            buttons.Add(buttonCPaper);
            buttons.Add(buttonCScissors);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsolStyle_Click(object sender, EventArgs e)
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string ConsoleKPO = @"/k " + strWorkPath.Remove(strWorkPath.Length - 10, 10) + @"\F016FrameWork\F016FrameWork\bin\Debug\F016FrameWork.exe";
            System.Diagnostics.Process.Start(@"cmd.exe", ConsoleKPO);
        }

        private void GamerButtonClicked(object sender, EventArgs e)
        {
            Random play = new Random();
            int computerTurn = play.Next(4,7);
            int actualPlayerTag = 0;
            
            if(sender is Button)
            {
                Button actualPlayerButton = (Button)sender;
                actualPlayerTag = Convert.ToInt32(actualPlayerButton.Tag);
                buttons.FirstOrDefault(x => Convert.ToInt32(x.Tag) == actualPlayerTag).BackColor = Color.Green;
            }

            buttons.FirstOrDefault(x => Convert.ToInt32(x.Tag) == computerTurn).BackColor = Color.Green;

            if(actualPlayerTag == 1 && computerTurn == 5 ||
               actualPlayerTag == 2 && computerTurn == 6 ||
               actualPlayerTag == 3 && computerTurn == 4)
            {
                computerResult++;
                labelComputerPoints.Text = computerResult.ToString();
                TurnIsOver(2);
            }
            else if(actualPlayerTag == 1 && computerTurn == 6 ||
                    actualPlayerTag == 2 && computerTurn == 4 ||
                    actualPlayerTag == 3 && computerTurn == 5)
            {
                playerResult++;
                labelGamerPoints.Text = playerResult.ToString();
                TurnIsOver(3);
            }
            else
            {
                TurnIsOver(1);
            }
        }

        private void TurnIsOver(int result)
        {  
            MessageBox.Show(result < 2 ? "A kör eredménye Döntetlen" :
                        result > 1 && result < 3 ? "A kört a számítógép nyerte" : "A kört játékos nyerte");

            foreach(Button aButton in buttons)
            {
                aButton.BackColor = basicBackolor;
            }
        }
    }
}
