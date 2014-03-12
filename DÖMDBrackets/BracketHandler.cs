using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace DÖMDBrackets
{
    class BracketHandler
    {
        public static BracketView bracketView;
        public static Match[,] matches;

        public static Bitmap bracketImage = new Bitmap(1000, 1000);

        private static int matchHeight;
        private static int matchWidth; 
        private static int boxHeight;
        private static int boxWidth; 
        private static int paddingVertical; 
        private static int paddingHorizontal;

        private static Pen pen = new Pen(Color.Black, 2.0f);

        public static void initBracket(int teamCount)
        {
            matches = new Match[(int)Math.Ceiling(Math.Log(teamCount, 2)), (int)(teamCount / 2)];
            matchHeight = 2 * bracketImage.Height / matches.GetLength(1);
            matchWidth = bracketImage.Width / (matches.GetLength(0) +1);
            boxHeight = matchHeight / 2 - 3;
            boxWidth = matchWidth;
            paddingVertical = boxHeight / 4;
            paddingHorizontal = 3;
        }

        public static void createBracketBox()
        {
            Graphics g = Graphics.FromImage(bracketImage);
            int ms = 0;
            g.DrawRectangle(pen, 0, 0, bracketImage.Width, bracketImage.Height);
            int yoff = 0;
            for (int round = 0; round < matches.GetLength(0) - 1; round++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int i = 0; i < Math.Pow(2, matches.GetLength(0) - round - 2); i++)
                    {
                        /*g.FillRectangle(Brushes.Red,
                            round * matchWidth + j * bracketImage.Width - j * 2 * (round + 1) * matchWidth + paddingHorizontal,
                            i * matchHeight + i * round * matchHeight + round * matchHeight / 2 + paddingVertical,
                            boxWidth - paddingHorizontal,
                            boxHeight);
                        g.FillRectangle(Brushes.Blue,
                            round * matchWidth + j * bracketImage.Width - j * 2 * (round + 1) * matchWidth + paddingHorizontal,
                            i * matchHeight + i * round * matchHeight + round * matchHeight / 2 + paddingVertical + boxHeight,
                            boxWidth - paddingHorizontal,
                            boxHeight);
                        g.DrawRectangle(pen,
                            round * matchWidth + j * bracketImage.Width - j * 2 * (round + 1) * matchWidth + paddingHorizontal,
                            i * matchHeight + i * round * matchHeight + round * matchHeight / 2 + paddingVertical,
                            boxWidth - paddingHorizontal,
                            boxHeight);
                        g.DrawRectangle(pen,
                            round * matchWidth + j * bracketImage.Width - j * 2 * (round + 1) * matchWidth + paddingHorizontal,
                            i * matchHeight + i * round * matchHeight + round * matchHeight / 2 + paddingVertical + boxHeight,
                            boxWidth - paddingHorizontal,
                            boxHeight);*/
                        g.FillRectangle(Brushes.Red,
                            round * matchWidth + j * bracketImage.Width - j * 2 * (round + 1) * matchWidth + paddingHorizontal,
                            i * bracketImage.Height / (int)Math.Pow(2, 7 - round - 2) + paddingVertical + yoff,
                            boxWidth - paddingHorizontal,
                            boxHeight);
                        g.FillRectangle(Brushes.Blue,
                            round * matchWidth + j * bracketImage.Width - j * 2 * (round + 1) * matchWidth + paddingHorizontal,
                           i * bracketImage.Height / (int)Math.Pow(2, 7 - round - 2) + paddingVertical + boxHeight + yoff,
                            boxWidth - paddingHorizontal,
                            boxHeight);
                        g.DrawRectangle(pen,
                            round * matchWidth + j * bracketImage.Width - j * 2 * (round + 1) * matchWidth + paddingHorizontal,
                           i * bracketImage.Height / (int)Math.Pow(2, 7 - round - 2) + paddingVertical + yoff,
                            boxWidth - paddingHorizontal,
                            boxHeight);
                        g.DrawRectangle(pen,
                            round * matchWidth + j * bracketImage.Width - j * 2 * (round + 1) * matchWidth + paddingHorizontal,
                           i * bracketImage.Height / (int)Math.Pow(2, 7 - round - 2) + paddingVertical + boxHeight + yoff,
                            boxWidth - paddingHorizontal,
                            boxHeight);
                        
                        ms++;
                    }
                }
                yoff += bracketImage.Height / (int)Math.Pow(2, 7 - round - 2) - (bracketImage.Height / (int)Math.Pow(2, 7 - round - 2))/2;
            }
            MessageBox.Show("Boxes: " + ms);
        }

        public static void updateBracketBox()
        {
            
            

            Bitmap newBitmap = new Bitmap(bracketImage);

            for (int round = 0; round < matches.GetLength(0); round++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int i = 0; i < Math.Pow(2, matches.GetLength(0) - round + 1); i++)
                    {

                    }
                }
            }

        }

        public static void showBracketView(Screen screen)
        {
            bracketView.Left = screen.Bounds.Left;
            bracketView.Top = screen.Bounds.Top;
            bracketView.Location = screen.Bounds.Location;
            bracketView.Width = screen.Bounds.Width;
            bracketView.Height = screen.Bounds.Height;
            bracketView.Show();
        }
    }
}
