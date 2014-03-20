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

        public static Bitmap bracketImage = new Bitmap(1920, 1080);
        public static Bitmap offImage = new Bitmap(3840, 2160);

        private static int matchHeight;
        private static int matchWidth; 
        private static int boxHeight;
        private static int boxWidth; 
        private static int paddingVertical; 
        private static int paddingHorizontal;
        private static int theTeamCount;
        private static int noRounds;

        private static Pen pen = new Pen(Color.Black, 2.0f);

        public delegate void ViewSetter();
        public static ViewSetter viewSetter = setFullView;

        public static void initBracket(int teamCount)
        {
            theTeamCount = teamCount;
            noRounds = (int)Math.Ceiling(Math.Log(teamCount, 2));
            matches = new Match[noRounds, (int)(teamCount / 2)];
            matchHeight = 2 * offImage.Height / matches.GetLength(1);
            matchWidth = offImage.Width / (2 + (int)Math.Log(teamCount/2, 2) * 2);
            boxHeight = matchHeight / 2 - 3;
            boxWidth = matchWidth;
            paddingVertical = boxHeight / 4;
            paddingHorizontal = 4;
        }

        public static void createBracketBox()
        {
            Graphics g = Graphics.FromImage(offImage);
            int ms = 0;
            g.DrawRectangle(pen, 0, 0, offImage.Width, offImage.Height);
            int yoff = 0;
            for (int round = 0; round < matches.GetLength(0) - 1; round++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int i = 0; i < Math.Pow(2, matches.GetLength(0) - round - 2); i++)
                    {
                        int boxX = round * matchWidth + j * offImage.Width - j * 2 * (round) * matchWidth - j * matchWidth + paddingHorizontal;
                        int boxY = i * offImage.Height / (int)Math.Pow(2, noRounds - round - 2) + yoff;
                        g.FillRectangle(Brushes.White,
                            boxX,
                            boxY,
                            boxWidth - paddingHorizontal,
                            boxHeight);
                        g.FillRectangle(Brushes.White,
                            boxX,
                            boxY + boxHeight,
                            boxWidth - paddingHorizontal,
                            boxHeight); 
                        g.DrawRectangle(pen,
                            boxX,
                            boxY,
                            boxWidth - paddingHorizontal,
                            boxHeight * 2);
                        g.DrawRectangle(pen,
                            boxX,
                            boxY + boxHeight,
                            boxWidth - paddingHorizontal,
                            boxHeight);

                        ms++;
                    }
                }
                yoff += offImage.Height / (int)Math.Pow(2, noRounds - round - 2) - (offImage.Height / (int)Math.Pow(2, noRounds - round - 2))/2;
            }
            g.FillRectangle(Brushes.White,
                offImage.Width / 2 - boxWidth + paddingHorizontal,
                offImage.Height / 2 - boxHeight / 2,
                boxWidth,
                boxHeight);
            g.FillRectangle(Brushes.White,
                offImage.Width / 2,
                offImage.Height / 2 - boxHeight / 2,
                boxWidth,
                boxHeight);
            g.DrawRectangle(pen,
                offImage.Width / 2 - boxWidth,
                offImage.Height / 2 - boxHeight / 2,
                boxWidth,
                boxHeight);
            g.DrawRectangle(pen,
                offImage.Width / 2,
                offImage.Height / 2 - boxHeight / 2,
                boxWidth,
                boxHeight);

            bracketImage = new Bitmap(offImage, bracketImage.Width, bracketImage.Height);
            bracketView.bracketBox.Image = bracketImage;

        }

        public static void updateBracketBox()
        {
            Graphics g = Graphics.FromImage(offImage);
            Font font = new Font("Verdana", boxHeight - paddingVertical, FontStyle.Regular, GraphicsUnit.Pixel);
            int yoff = 0;
            for (int round = 0; round < matches.GetLength(0) - 1; round++)
            {
                int mId = 0;
                for (int j = 0; j < 2; j++)
                {
                    for (int i = 0; i < Math.Pow(2, matches.GetLength(0) - round - 2); i++)
                    {
                        if (matches[round, mId] != null && matches[round, mId].needRender)
                        {
                            
                            int boxX = round * matchWidth + j * offImage.Width - j * 2 * (round) * matchWidth - j * matchWidth + paddingHorizontal;
                            int boxY = i * offImage.Height / (int)Math.Pow(2, noRounds - round - 2) + yoff;
                            if (matches[round, mId].team1 != null)
                            {
                                Font team1Font = new Font(font.Name, font.Size, FontStyle.Regular, GraphicsUnit.Pixel);
                                StringFormat format = new StringFormat(StringFormatFlags.NoWrap);
                                SizeF fontSize = g.MeasureString(matches[round, mId].team1,
                                    team1Font,
                                    new Point(0, 0),
                                    format);
                                while (fontSize.Width > boxWidth + paddingHorizontal)
                                {
                                    team1Font = new Font(font.Name, team1Font.Size - 1, FontStyle.Regular, GraphicsUnit.Pixel);
                                    fontSize = g.MeasureString(matches[round, mId].team1,
                                    team1Font,
                                    new Point(0, 0),
                                    format);
                                }
                                g.DrawString(matches[round, mId].team1,
                                    team1Font,
                                    Brushes.Black,
                                    boxX,
                                    boxY + boxHeight / 2 - fontSize.Height / 2);
                                
                            }
                            if (matches[round, mId].team2 != null)
                            {
                                Font team1Font = new Font(font.Name, font.Size, FontStyle.Regular, GraphicsUnit.Pixel);
                                StringFormat format = new StringFormat(StringFormatFlags.NoWrap);
                                SizeF fontSize = g.MeasureString(matches[round, mId].team2,
                                    team1Font,
                                    new Point(0, 0),
                                    format);
                                while (fontSize.Width > boxWidth + paddingHorizontal)
                                {
                                    team1Font = new Font(font.Name, team1Font.Size - 1, FontStyle.Regular, GraphicsUnit.Pixel);
                                    fontSize = g.MeasureString(matches[round, mId].team2,
                                    team1Font,
                                    new Point(0, 0),
                                    format);
                                }
                                g.DrawString(matches[round, mId].team2,
                                    team1Font,
                                    Brushes.Black,
                                    boxX,
                                    boxY + boxHeight + boxHeight / 2 - fontSize.Height / 2);
                                
                            }
                            mId++;
                        }
                    }
                }
                yoff += offImage.Height / (int)Math.Pow(2, noRounds - round - 2) - (offImage.Height / (int)Math.Pow(2, noRounds - round - 2)) / 2;
            }
            viewSetter();
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

        public static void setFullView()
        {
            viewSetter = setFullView;
            bracketImage = new Bitmap(offImage, bracketImage.Width, bracketImage.Height);
            bracketView.bracketBox.Image = bracketImage;
        }

        public static void setTopLeftView()
        {
            viewSetter = setTopLeftView;
            bracketImage = offImage.Clone(new Rectangle(0, 0, offImage.Width / 2, offImage.Height / 2), offImage.PixelFormat);
            bracketView.bracketBox.Image = bracketImage;
        }

        public static void setTopRightView()
        {
            viewSetter = setTopRightView;
            bracketImage = offImage.Clone(new Rectangle(offImage.Width / 2, 0, offImage.Width / 2, offImage.Height / 2), offImage.PixelFormat);
            bracketView.bracketBox.Image = bracketImage;
        }

        public static void setBottomLeftView()
        {
            viewSetter = setBottomLeftView;
            bracketImage = offImage.Clone(new Rectangle(0, offImage.Height / 2, offImage.Width / 2, offImage.Height / 2), offImage.PixelFormat);
            bracketView.bracketBox.Image = bracketImage;
        }

        public static void setBottomRightView()
        {
            viewSetter = setBottomRightView;
            bracketImage = offImage.Clone(new Rectangle(offImage.Width / 2, offImage.Height / 2, offImage.Width / 2, offImage.Height / 2), offImage.PixelFormat);
            bracketView.bracketBox.Image = bracketImage;
        }

        public static void setSemiView()
        {
            viewSetter = setSemiView;
            bracketImage = offImage.Clone(new Rectangle((noRounds - 2) * matchWidth, offImage.Height / 2 - 9 * matchWidth / 8, 4 * matchWidth, 9 * matchWidth / 4), offImage.PixelFormat);
            bracketView.bracketBox.Image = bracketImage;
        }

        public static int getNoRounds()
        {
            return noRounds;
        }
    }
}
