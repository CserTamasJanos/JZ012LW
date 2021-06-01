using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OperationsForF12
{
    public class Operations
    {
        private static Graphics graphics;
        private readonly static Color lineColor = Color.Black;
        private readonly static Color smileyBodyColor = Color.Yellow;
        private const float PenWidth = 3;
        private const float EyeSize = 6;
        private const float CircleRadius = 75;
        public const int BitmapSize = 76;

        public static float Counter(int numberOne, int numberTwo, int counterType)
        {
            switch (counterType)
            {
                case 1:
                    return numberOne + numberTwo;
                    break;
                case 2:
                    return numberOne - numberTwo;
                    break;
                case 3:
                    return numberOne * numberTwo;
                    break;
                case 4:
                    return numberOne / numberTwo;
                    break;
                default:
                    return float.MinValue;
            }
        }

        public static double[] QuadraticEquation(long a, long b, long c)
        {
            double[] result = new double[2];
            result[0] = ((b * -1) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2*a);
            result[1] = ((b * -1) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2*a);

            return result;
        }

        public static string Pythagorean(long aLeg, long hypothenuse, int question, out bool suspicious)
        {
            string result = "A számítás sikeretelen lett.";
            double countResult;

            if(question == 1)
            {
                countResult = Math.Sqrt(Math.Pow(hypothenuse, 2) + Math.Pow(aLeg, 2));
            }
            else
            {
                countResult = Math.Sqrt(Math.Pow(hypothenuse, 2) - Math.Pow(aLeg, 2));
            }
                                
            switch (question)
            {
                case 1:
                    result = $"a= {aLeg}, b= {hypothenuse}, *c= {countResult}";
                    break;
                case 2:
                    result = $"a= {aLeg}, *b= {countResult} c= {hypothenuse} ";
                    break;
                case 3:
                    result = $"*a= {countResult}, b= {aLeg} c= {hypothenuse}";
                    break;
            }
            suspicious = double.IsNaN(countResult) || countResult == 0;
            return result;
        }

        public static Bitmap DrawSmiley(bool clear, bool wink,Color backColor, float randomX, float randomY, int bitmapWidth, int bitmapHeight)
        {
            Bitmap smiley = new Bitmap(bitmapWidth,bitmapHeight);
            graphics = Graphics.FromImage(smiley);
            Pen penForSmiley = new Pen(lineColor,PenWidth);

            if(clear)
            {
                graphics.FillRectangle(new SolidBrush(backColor),0,0,bitmapWidth,bitmapHeight);
            }
            else
            {
                //Body
                graphics.DrawEllipse(penForSmiley, randomX, randomY, CircleRadius, CircleRadius);
                graphics.FillEllipse(new SolidBrush(smileyBodyColor), randomX + 1, randomY + 1, CircleRadius - 2, CircleRadius - 2);

                //Eyes
                if (wink)
                {
                    graphics.DrawLine(penForSmiley, randomX + (CircleRadius / 4) - 3, randomY + (CircleRadius / 4),
                                                   randomX + (CircleRadius / 4) + 5, randomY + (CircleRadius / 4));
                }
                else
                {
                    graphics.DrawEllipse(penForSmiley, randomX + (CircleRadius / 4) - 3, randomY + (CircleRadius / 4) - 3, EyeSize, EyeSize);
                    graphics.FillEllipse(new SolidBrush(lineColor), randomX + (CircleRadius / 4) - 3, randomY + (CircleRadius / 4) - 3, EyeSize, EyeSize);
                }
                graphics.DrawEllipse(penForSmiley, randomX + ((CircleRadius / 4) * 3) - 3, randomY + (CircleRadius / 4) - 3, EyeSize, EyeSize);
                graphics.FillEllipse(new SolidBrush(lineColor), randomX + ((CircleRadius / 4) * 3) - 3, randomY + (CircleRadius / 4) - 3, EyeSize, EyeSize);

                //Mouth
                graphics.DrawBezier(penForSmiley, randomX + (CircleRadius / 4), randomY + (CircleRadius / 2),
                                                 randomX + (CircleRadius / 4) + (CircleRadius / 8), randomY + (CircleRadius / 2) + (CircleRadius / 8),
                                                 randomX + (CircleRadius / 4) * 3 - (CircleRadius / 8), randomY + (CircleRadius / 2) + (CircleRadius / 8),
                                                 randomX + (CircleRadius / 4) * 3, randomY + CircleRadius / 2);
            }
            return smiley;
        }
    }
}
