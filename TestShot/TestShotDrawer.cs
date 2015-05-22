using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestShot
{
    class TestShotDrawer
    {
        public TestShotDrawer(int width, int height, DateTime date, DateTime time)
        {
            init(width, height, date, time);
        }
        private void init(int width, int height, DateTime date, DateTime time)
        {
            try
            {
                imageWidth = width;
                imageHeight = height;
                target = new Bitmap(width, height);
                this.date = date;
                this.time = time;
                leftCost = 5;
                rightCost = 4;
            }
            catch (Exception e)
            {
                throw new Exception("비트맵을 초기화 하는데에 실패했습니다.");
            }
            try
            {
                bg = new Bitmap(@"img/bg.png");
                arrowDown = new Bitmap(@"img/arrow_down.png");
                arrowUp = new Bitmap(@"img/arrow_up.png");
                gradientBar = new Bitmap(@"img/gradient_copy.png");
                iconContents = new Bitmap(@"img/icon_contents.png");
                iconDownload = new Bitmap(@"img/icon_download.png");
                iconFacebook = new Bitmap(@"img/icon_facebook.png");
                iconUnlock = new Bitmap(@"img/icon_unlock.png");
                iconVideo = new Bitmap(@"img/icon_video.png");
                iconWeb = new Bitmap(@"img/icon_web.png");
                button = new Bitmap(@"img/button.png");
                adShadow = new Bitmap(@"img/shadow_1015.png");
                notiBar = new Bitmap(@"img/noti_bar.png");
                indicator = new Bitmap(@"img/btn_indicator.png");
            }
            catch (Exception e)
            {
                throw new Exception(e.StackTrace + "\n이미지 리소스를 불러오는데에 실패했습니다.");
            }
        }

        public void setAdImage(Bitmap adImage)
        {
            this.adImage = adImage;
        }

        public void setDate(DateTime date) {
            this.date = date;
        }

        public void setTime(DateTime time)
        {
            this.time = time;
        }

        public void setLeftCost(int lCost)
        {
            leftCost = lCost;
        }

        public void setRightCost(int rCost)
        {
            rightCost = rCost;
        }

        public void setAdType(int adType)
        {
            this.adType = adType;
        }

        public void setArrowUpVisible(bool visible)
        {
            this.showArrowUp = visible;
        }

        public void draw()
        {
            try
            {
                using (Graphics g = Graphics.FromImage(target))
                {
                    g.TextRenderingHint = TextRenderingHint.AntiAlias;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    g.Clear(Color.White);
                    try
                    {
                        if (adImage == null)
                            throw new Exception("adImage 가 null 입니다");
                        else
                        {
                            drawImage(g, bg, 0, 50);
                            drawImage(g, adImage, 47, 163, 626, 1069);
                            drawImage(g, adShadow, 41, 157);
                            drawImage(g, gradientBar, 47, 1011);
                            //drawImage(adShadow, 41, 107);
                            //drawImage(g, adShadow, 600, 1100);
                            //drawImage(g, test, 0, 0);
                            if (showArrowUp)
                                drawImageCenter(g, arrowUp, 360, 139);
                            drawImageCenter(g, arrowDown, 360, 1257);
                            drawImageCenter(g, button, 360, 1130);
                            drawImageCenter(g, iconUnlock, 584, 1130);
                            switch (adType)
                            {
                                case (int)AdType.Contents:
                                    drawImageCenter(g, iconContents, 135, 1130);
                                    break;
                                case (int)AdType.Download:
                                    drawImageCenter(g, iconDownload, 135, 1130);
                                    break;
                                case (int)AdType.Web:
                                    drawImageCenter(g, iconWeb, 135, 1130);
                                    break;
                                case (int)AdType.Video:
                                    drawImageCenter(g, iconVideo, 135, 1130);
                                    break;
                                case (int)AdType.Facebook:
                                    drawImageCenter(g, iconFacebook, 135, 1130);
                                    break;
                            }
                            //drawImageCenter(g, )
                            //drawString(g, "12:34", new Font("Futura Std Medium", 90), 38, 12);
                            //drawString(g, "AM", new Font("나눔고딕", 32, FontStyle.Bold), 250, 32);
                            String dtString;
                            dtString = time.ToString("hh:mm");
                            drawString(g, dtString, new Font("Futura Std Medium", 60), 32, 62);
                            dtString = time.ToString("tt", new CultureInfo("en-US"));
                            drawString(g, dtString, new Font("나눔고딕 ExtraBold", 23), 265, 82);
                            dtString = date.Month + "." + date.Day;
                            drawString(g, dtString, new Font("Futura Std Medium", 25), 500, 82);
                            dtString = date.ToString("ddd") + "요일";
                            drawString(g, dtString, new Font("나눔고딕 ExtraBold", 22.5f), 576, 85);
                            if (leftCost > 0)
                                drawStringCenter(g, "+" + leftCost, new Font("Futura Std Medium", 19), 135, 1188);
                            if (rightCost > 0)
                                drawStringCenter(g, "+" + rightCost, new Font("Futura Std Medium", 19), 584, 1188);

                            drawImage(g, indicator, 678, 982);
                            drawImage(g, notiBar, 0, 0);
                            dtString = time.ToString("tt") + " " + time.ToString("hh:mm");
                            drawString(g, dtString, new Font("Droid Sans Fallback", 22.8f), unchecked((int)0xFFDFDFDF), 560, 5);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
        }

        public Image getTestShot()
        {
            return new Bitmap(target);
        }

        public const int SHOT_WIDTH = 720;
        public const int SHOT_HEIGHT = 1280;

        private void drawImage(Graphics graphics, Image image, int x, int y)
        {
            int cX, cY;
            Rectangle dest;
            cX = getX(x);
            cY = getY(y);
            dest = new Rectangle(cX, cY, getX(image.Width), getY(image.Height));
            graphics.DrawImage(image, dest);
        }
        private void drawImage(Graphics graphics, Image image, int x, int y, int width, int height)
        {
            int cX, cY;
            Rectangle dest;
            cX = getX(x);
            cY = getY(y);
            dest = new Rectangle(cX, cY, getX(width), getY(height));
            graphics.DrawImage(image, dest);
        }
        private void drawImageCenter(Graphics graphics, Image image, int x, int y)
        {
            Rectangle dest;
            dest = new Rectangle(getX(x - image.Width / 2), getY(y - image.Height / 2), getX(image.Width), getY(image.Height));
            graphics.DrawImage(image, dest);
        }
        private void drawString(Graphics graphics, String str, Font font, int x, int y)
        {
            graphics.DrawString(str, font, Brushes.White, new Point(getX(x), getY(y)));
        }
        private void drawStringCenter(Graphics graphics, String str, Font font, int x, int y)
        {
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            graphics.DrawString(str, font, Brushes.White, new Point(getX(x), getY(y)), format);
        }
        private void drawString(Graphics graphics, String str, Font font, int color, int x, int y)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(color));
            graphics.DrawString(str, font, brush, new Point(getX(x), getY(y)));
        }
        private int getX(int x)
        {
            //return (int)((float)x * imageWidth / SHOT_WIDTH);
            return x;
        }
        private int getY(int y)
        {
            //return (int)((float)y * imageHeight / SHOT_HEIGHT);
            return y;
        }

        enum AdType
        {
            Contents = 0,
            Download,
            Web,
            Video,
            Facebook,
        };

        private Bitmap adImage = null;
        private Image target;
        private int imageWidth;
        private int imageHeight;

        private int adType = (int)AdType.Contents;
        private DateTime date;
        private DateTime time;
        private int leftCost;
        private int rightCost;
        private bool showArrowUp = false;

        private Image bg;
        private Image arrowDown;
        private Image arrowUp;
        private Image gradientBar;
        private Image iconContents;
        private Image iconDownload;
        private Image iconFacebook;
        private Image iconUnlock;
        private Image iconVideo;
        private Image iconWeb;
        private Image button;
        private Image adShadow;
        private Image notiBar;
        private Image indicator;
        private Image test;
    }
}
