using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestShot
{
    public class TestShotDrawer
    {
        public TestShotDrawer(int width, int height, DateTime date, DateTime time)
        {
            init(width, height, date, time);
        }

        private class NotiBar
        {
            public NotiBar(Image notiBar, Font font, Point point, int color)
            {
                this.notiBar = notiBar;
                this.font = font;
                this.point = point;
                this.color = color;
            }

            public void draw(Graphics g, DateTime time)
            {
                Drawer.drawImage(g, notiBar, 0, 0);
                String dtString = time.ToString("tt") + " ";
                if (Int32.Parse(time.ToString("hh")) < 10)
                    dtString = "  " + dtString;
                dtString += time.ToString("h:mm");
                Drawer.drawString(g, dtString, font, color, point.X, point.Y);
            }

            private Image notiBar;
            private Font font;
            private Point point;
            private int color;
        }

        class NotiBarForm
        {
            public NotiBarForm(Font font, int fontColor, Image bg,
                    Image logo, Image sms, Image kakao, Image vib, Image lte,
                    Image batPer6, Image batPer12, Image batPer18, Image batPer24, Image batPer72,
                    Image bat6, Image bat12, Image bat18, Image bat24, Image bat72,
                    Image batCharging, Image antenna,
                    Image capture, Image cashslide)
            {
                this.font = font;
                this.color = fontColor;
                this.bg = bg;
                this.logo = logo;
                this.sms = sms;
                this.kakao = kakao;
                this.vib = vib;
                this.lte = lte;
                this.antenna = antenna;
                this.capture = capture;
                this.cashslide = cashslide;
                this.leftIcons = new Image[5];
                leftIcons[0] = logo;
                leftIcons[1] = sms;
                leftIcons[2] = capture;
                leftIcons[3] = kakao;
                leftIcons[4] = cashslide;
                this.batPer6 = batPer6;
                this.batPer12 = batPer12;
                this.batPer18 = batPer18;
                this.batPer24 = batPer24;
                this.batPer72 = batPer72;
                this.bat6 = bat6;
                this.bat12 = bat12;
                this.bat18 = bat18;
                this.bat24 = bat24;
                this.bat72 = bat72;
                this.bat = new Image[(int)BatPer.size];
                bat[0] = bat72;
                bat[1] = bat24;
                bat[2] = bat18;
                bat[3] = bat12;
                bat[4] = bat6;
                this.batPer = new Image[(int)BatPer.size];
                batPer[0] = batPer72;
                batPer[1] = batPer24;
                batPer[2] = batPer18;
                batPer[3] = batPer12;
                batPer[4] = batPer6;
                this.batCharging = batCharging;
            }

            public void draw(Graphics g, int icons, int batPerIndex, bool batCharge, DateTime time) {
                Drawer.drawImage(g, bg, 0, 0, 1080, 75);
                int c = 0;
                for (int i = 0; i < leftIcons.Length; ++i)
                {
                    if ((icons & 1 << i) != 0)
                        Drawer.drawImageCenter(g, leftIcons[i], 51 + c++ * 72, 39, 72, 75);
                }
                c = 0;
                if (batCharge)
                    Drawer.drawImageCenter(g, batCharging, 909, 39, 72, 75);
                else
                    Drawer.drawImageCenter(g, bat[batPerIndex], 909, 39, 72, 75);

                if ((icons & (int)Icons.batPer) != 0)
                    Drawer.drawImageCenter(g, batPer[batPerIndex], 846 - c++ * 72, 39, 72, 75);
                if ((icons & (int)Icons.antenna) != 0)
                    Drawer.drawImageCenter(g, antenna, 846 - c++ * 72, 39, 72, 75);
                if ((icons & (int)Icons.lte) != 0)
                    Drawer.drawImageCenter(g, lte, 846 - c++ * 72, 39, 72, 75);
                if ((icons & (int)Icons.vib) != 0)
                    Drawer.drawImageCenter(g, vib, 846 - c++ * 72, 39, 72, 75);
                /*
                String dtString = time.ToString("tt") + " ";
                if (Int32.Parse(time.ToString("hh")) < 10)
                    dtString = "  " + dtString;
                dtString += time.ToString("h:mm");
                */
                String dtString = time.ToString("hh:mm");
                Drawer.drawString(g, dtString, font, color, 950, 9);
            }

            private Font font;
            private int color;
            private Image bg;
            private Image logo;
            private Image sms;
            private Image kakao;
            private Image vib;
            private Image lte;
            private Image antenna;
            private Image capture;
            private Image cashslide;

            private Image[] leftIcons;

            private Image batPer6;
            private Image batPer12;
            private Image batPer18;
            private Image batPer24;
            private Image batPer72;
            private Image bat6;
            private Image bat12;
            private Image bat18;
            private Image bat24;
            private Image bat72;
            private Image[] bat;
            private Image[] batPer;
            private Image batCharging;
        }

        public class AdBulletin
        {
            public class BulletinText
            {
                public BulletinText(int x, int y, Font font, string text, int color = 0xFFFFFF)
                {
                    this.x = x;
                    this.y = y;
                    this.font = font;
                    this.text = text;
                    this.color = color;
                    this.center = false;
                    this.visible = true;
                }
                public BulletinText(int x, int y, Font font, string text, bool center, int color = 0xFFFFFF)
                {
                    this.x = x;
                    this.y = y;
                    this.font = font;
                    this.text = text;
                    this.color = color;
                    this.center = center;
                    this.visible = true;
                }
                public void setCoord(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                }
                public void setText(string text)
                {
                    this.text = text;
                }
                public void setFont(Font font)
                {
                    this.font = font;
                }
                public void draw(Graphics g)
                {
                    if (visible)
                    {
                        StringFormat format = new StringFormat();
                        if (center)
                            Drawer.drawStringCenter(g, text, font, x, y);
                        else
                            Drawer.drawString(g, text, font, x, y);
                    }
                }
                public void setVisibility(bool visible)
                {
                    this.visible = visible;
                }

                private int x, y;
                private Font font;
                private string text;
                private bool center;
                private int color;
                private bool visible;
            }
            public class BulletinImage
            {
                public BulletinImage(int x, int y, int width, int height, Image image, bool center = false)
                {
                    this.x = x;
                    this.y = y;
                    this.width = width;
                    this.height = height;
                    this.image = image;
                    this.center = center;
                }
                public BulletinImage(int x, int y, Image image)
                {
                    this.x = x;
                    this.y = y;
                    this.width = image.Width;
                    this.height = image.Height;
                    this.image = image;
                }
                public void setCoord(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                }
                public void setSize(int width, int height)
                {
                    this.width = width;
                    this.height = height;
                }
                public void setImage(Image image)
                {
                    this.image = image;
                }
                public void draw(Graphics g)
                {
                    try {
                        Drawer.drawImage(g, image, x, y, width, height);
                    } catch (Exception e) {
                        throw e;
                    }
                }

                private int x, y;
                private int width, height;
                private Image image;
                private bool center;
            }

            public AdBulletin()
            {
                texts = new ArrayList();
                images = new ArrayList();
            }

            public void addText(BulletinText text)
            {
                texts.Add(text);
            }
            public void addImage(BulletinImage image)
            {
                images.Add(image);
            }
            public void draw(Graphics g)
            {
                try {
                    foreach (BulletinImage image in images)
                    {
                        image.draw(g);
                    }
                    foreach (BulletinText text in texts)
                    {
                        text.draw(g);
                    }
                } catch (Exception e)
                {
                    throw e;
                }
            }

            private ArrayList texts;
            private ArrayList images;
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
            PresetLoader.loadPreset();
            try
            {
                arrowDown = new Bitmap(@"img/arrow_down.png");
                arrowUp = new Bitmap(@"img/arrow_up.png");
                gradientBar = new Bitmap(@"img/gradient_copy.png");
                gradientTop = new Bitmap(@"img/gradient_top.png");
                gradientBottom = new Bitmap(@"img/gradient_bottom.png");
                iconContents = new Bitmap(@"img/icon_contents.png");
                iconDownload = new Bitmap(@"img/icon_download.png");
                iconFacebook = new Bitmap(@"img/icon_facebook.png");
                iconUnlock = new Bitmap(@"img/icon_unlock.png");
                iconWeb = new Bitmap(@"img/icon_web.png");
                button = new Bitmap(@"img/button.png");
                adShadow = new Bitmap(@"img/shadow_1015.png");
                indicator = new Bitmap(@"img/btn_indicator.png");

                notiBg = new Bitmap(@"img/skt_statusbar_icon/bg.png");
                notiLogoSkt = new Bitmap(@"img/skt_statusbar_icon/noti_skt.png");
                notiSms = new Bitmap(@"img/skt_statusbar_icon/noti_sms.png");
                notiKakao = new Bitmap(@"img/skt_statusbar_icon/noti_kakao.png");
                notiVib = new Bitmap(@"img/skt_statusbar_icon/noti_vibrate.png");
                notiLte = new Bitmap(@"img/skt_statusbar_icon/noti_lte.png");
                notiBatPer6 = new Bitmap(@"img/skt_statusbar_icon/battery_per_6.png");
                notiBatPer12 = new Bitmap(@"img/skt_statusbar_icon/battery_per_12.png");
                notiBatPer18 = new Bitmap(@"img/skt_statusbar_icon/battery_per_18.png");
                notiBatPer24 = new Bitmap(@"img/skt_statusbar_icon/battery_per_24.png");
                notiBatPer72 = new Bitmap(@"img/skt_statusbar_icon/battery_per_72.png");
                notiBat6 = new Bitmap(@"img/skt_statusbar_icon/battery_6.png");
                notiBat12 = new Bitmap(@"img/skt_statusbar_icon/battery_12.png");
                notiBat18 = new Bitmap(@"img/skt_statusbar_icon/battery_18.png");
                notiBat24 = new Bitmap(@"img/skt_statusbar_icon/battery_24.png");
                notiBat72 = new Bitmap(@"img/skt_statusbar_icon/battery_72.png");
                notiBatCharging = new Bitmap(@"img/skt_statusbar_icon/battery_charging.png");
                notiAntenna = new Bitmap(@"img/skt_statusbar_icon/noti_antenna.png");
                notiCapture = new Bitmap(@"img/skt_statusbar_icon/noti_capture.png");
                notiCashslide = new Bitmap(@"img/skt_statusbar_icon/noti_cashslide.png");
                //notiBarSkt = new NotiBarForm(new Font(fontCollection.Families[0], 35.0f), unchecked((int)0xFFBCBCBC),
                notiBarSkt = new NotiBarForm(new Font("SamsungKorean", 35.0f), unchecked((int)0xFFBCBCBC),
                    notiBg, notiLogoSkt, notiSms, notiKakao, notiVib, notiLte, notiBatPer6, notiBatPer12,
                    notiBatPer18, notiBatPer24, notiBatPer72, notiBat6, notiBat12, notiBat18,
                    notiBat24, notiBat72, notiBatCharging, notiAntenna, notiCapture, notiCashslide);
                
                adBulletin = new AdBulletin();

                List<PresetLoader.ImageLayoutPreset> imagePresets = PresetLoader.getImagePresets();
                bulletinAdImage = new AdBulletin.BulletinImage(
                    imagePresets[0].x, imagePresets[0].y, imagePresets[0].width, imagePresets[0].height, adImage);
                bulletinGradientTop = new AdBulletin.BulletinImage(
                    imagePresets[1].x, imagePresets[1].y, imagePresets[1].width, imagePresets[1].height, gradientTop);
                bulletinGradientBottom = new AdBulletin.BulletinImage(
                    imagePresets[2].x, imagePresets[2].y, imagePresets[2].width, imagePresets[2].height, gradientBottom);
                bulletinArrowUp = new AdBulletin.BulletinImage(
                    imagePresets[3].x, imagePresets[3].y, imagePresets[3].width, imagePresets[3].height, arrowUp);
                bulletinArrowDown = new AdBulletin.BulletinImage(
                    imagePresets[4].x, imagePresets[4].y, imagePresets[4].width, imagePresets[4].height, arrowDown);
                bulletinActiveIcon = new AdBulletin.BulletinImage(
                    imagePresets[5].x, imagePresets[5].y, imagePresets[5].width, imagePresets[5].height, iconContents);
                bulletinIconUnlock = new AdBulletin.BulletinImage(
                    imagePresets[6].x, imagePresets[6].y, imagePresets[6].width, imagePresets[6].height, iconUnlock);
                bulletinButton = new AdBulletin.BulletinImage(
                    imagePresets[7].x, imagePresets[7].y, imagePresets[7].width, imagePresets[7].height, button);
                bulletinIndicator = new AdBulletin.BulletinImage(
                    imagePresets[8].x, imagePresets[8].y, imagePresets[8].width, imagePresets[8].height, indicator);
                adBulletin.addImage(bulletinAdImage);
                adBulletin.addImage(bulletinGradientTop);
                adBulletin.addImage(bulletinGradientBottom);
                adBulletin.addImage(bulletinArrowUp);
                adBulletin.addImage(bulletinArrowDown);
                adBulletin.addImage(bulletinButton);
                adBulletin.addImage(bulletinIconUnlock);
                adBulletin.addImage(bulletinActiveIcon);
                adBulletin.addImage(bulletinIndicator);

                List<PresetLoader.TextLayoutPreset> textPresets = PresetLoader.getTextPresets();
                String dtString;
                dtString = time.ToString("h:mm");
                bulletinTime = new AdBulletin.BulletinText(
                    textPresets[0].x, textPresets[0].y, new Font(textPresets[0].fontName, textPresets[0].fontSize), dtString);
                dtString = time.ToString("tt", new CultureInfo("en-US"));
                //if (Int32.Parse(time.ToString("hh")) < 10)
                bulletin1_9AMPM = new AdBulletin.BulletinText(
                    textPresets[1].x, textPresets[1].y, new Font(textPresets[1].fontName, textPresets[1].fontSize), dtString);
                bulletin10_12AMPM = new AdBulletin.BulletinText(
                    textPresets[2].x, textPresets[2].y, new Font(textPresets[2].fontName, textPresets[2].fontSize), dtString);
                if (Int32.Parse(time.ToString("hh")) < 10)
                    bulletin10_12AMPM.setVisibility(false);
                else
                    bulletin1_9AMPM.setVisibility(false);
                    //dtString = date.Month + "." + date.Day;
                    dtString = date.ToString("MM.dd");
                if (date.Month < 10)
                    bulletinDate = new AdBulletin.BulletinText(
                        textPresets[3].x, textPresets[3].y, new Font(textPresets[3].fontName, textPresets[3].fontSize), dtString);
                else
                    bulletinDate = new AdBulletin.BulletinText(
                        textPresets[3].x, textPresets[3].y, new Font(textPresets[3].fontName, textPresets[3].fontSize), dtString);
                dtString = "(" + date.ToString("ddd") + ")";
                bulletinDay = new AdBulletin.BulletinText(
                    textPresets[4].x, textPresets[4].y, new Font(textPresets[4].fontName, textPresets[4].fontSize), dtString);
                //if (leftCost > 0)
                bulletinLeftCost = new AdBulletin.BulletinText(
                    textPresets[5].x, textPresets[5].y, new Font(textPresets[5].fontName, textPresets[5].fontSize), "+" + leftCost, true);
                //if (rightCost > 0)
                bulletinRightCost = new AdBulletin.BulletinText(
                    textPresets[6].x, textPresets[6].y, new Font(textPresets[6].fontName, textPresets[6].fontSize), "+" + rightCost, true);
                adBulletin.addText(bulletinTime);
                adBulletin.addText(bulletin1_9AMPM);
                adBulletin.addText(bulletin10_12AMPM);
                adBulletin.addText(bulletinDate);
                adBulletin.addText(bulletinDay);
                adBulletin.addText(bulletinLeftCost);
                adBulletin.addText(bulletinRightCost);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + e.StackTrace + "\n리소스를 불러오는데에 실패했습니다.");
            }
        }

        public AdBulletin getAdBulletin()
        {
            return adBulletin;
        }

        public void setAdImage(Bitmap adImage)
        {
            this.adImage = adImage;
            bulletinAdImage.setImage(adImage);
        }

        public void setDate(DateTime date) {
            this.date = date;
            String dtString = date.ToString("MM.dd");
            bulletinDate.setText(dtString);
        }

        public void setTime(DateTime time)
        {
            this.time = time;
            String dtString = time.ToString("h:mm");
            bulletinTime.setText(dtString);
            if (Int32.Parse(time.ToString("hh")) < 10)
            {
                bulletin10_12AMPM.setVisibility(false);
                bulletin1_9AMPM.setVisibility(true);
            }
            else
            {
                bulletin10_12AMPM.setVisibility(true);
                bulletin1_9AMPM.setVisibility(false);
            }
        }

        public void setLeftCost(int lCost)
        {
            leftCost = lCost;
            String dtString = "+" + lCost;
            if (leftCost != 0)
                bulletinLeftCost.setText(dtString);
            else
                bulletinLeftCost.setText("");
        }

        public void setRightCost(int rCost)
        {
            rightCost = rCost;
            String dtString = "+" + rCost;
            if (rightCost != 0)
                bulletinRightCost.setText(dtString);
            else
                bulletinRightCost.setText("");
        }

        public void setAdType(int adType)
        {
            this.adType = adType;
            switch (adType)
            {
                case (int)AdType.Contents:
                    bulletinActiveIcon.setImage(iconContents);
                    break;
                case (int)AdType.Download:
                    bulletinActiveIcon.setImage(iconDownload);
                    break;
                case (int)AdType.Web:
                    bulletinActiveIcon.setImage(iconWeb);
                    break;
                case (int)AdType.Facebook:
                    bulletinActiveIcon.setImage(iconFacebook);
                    break;
            }
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
                            adBulletin.draw(g);
                            notiBarSkt.draw(g, showingIcons, batIndex, batCharge, time);
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

        public void setShowingIcons(int showingIcons)
        {
            this.showingIcons = showingIcons;
        }

        public void setBatPer(int batPerIndex, bool batCharge)
        {
            this.batIndex = batPerIndex;
            this.batCharge = batCharge;
        }

        public void setBulletinTime(int x, int y, Font font)
        {
            bulletinTime.setCoord(x, y);
            bulletinTime.setFont(font);
        }

        public void setBulletin1_9AMPM(int x, int y, Font font)
        {
            bulletin1_9AMPM.setCoord(x, y);
            bulletin1_9AMPM.setFont(font);
        }

        public void setBulletin10_12AMPM(int x, int y, Font font)
        {
            bulletin10_12AMPM.setCoord(x, y);
            bulletin10_12AMPM.setFont(font);
        }

        public void setBulletinDate(int x, int y, Font font)
        {
            bulletinDate.setCoord(x, y);
            bulletinDate.setFont(font);
        }

        public void setBulletinDay(int x, int y, Font font)
        {
            bulletinDay.setCoord(x, y);
            bulletinDay.setFont(font);
        }

        public void setBulletinLeftCost(int x, int y, Font font)
        {
            bulletinLeftCost.setCoord(x, y);
            bulletinLeftCost.setFont(font);
        }

        public void setBulletinRightCost(int x, int y, Font font)
        {
            bulletinRightCost.setCoord(x, y);
            bulletinRightCost.setFont(font);
        }

        public void setBulletinAdImage(int x, int y, int width, int height)
        {
            bulletinAdImage.setCoord(x, y);
            bulletinAdImage.setSize(width, height);
        }

        public void setBulletinArrowDown(int x, int y, int width, int height)
        {
            bulletinArrowDown.setCoord(x, y);
            bulletinArrowDown.setSize(width, height);
        }

        public void setBulletinArrowUp(int x, int y, int width, int height)
        {
            bulletinArrowUp.setCoord(x, y);
            bulletinArrowUp.setSize(width, height);
        }

        public void setBulletinGradientTop(int x, int y, int width, int height)
        {
            bulletinGradientTop.setCoord(x, y);
            bulletinGradientTop.setSize(width, height);
        }

        public void setBulletinGradientBottom(int x, int y, int width, int height)
        {
            bulletinGradientBottom.setCoord(x, y);
            bulletinGradientBottom.setSize(width, height);
        }

        public void setBulletinActiveIcon(int x, int y, int width, int height)
        {
            bulletinActiveIcon.setCoord(x, y);
            bulletinActiveIcon.setSize(width, height);
        }

        public void setBulletinIconUnlock(int x, int y, int width, int height)
        {
            bulletinIconUnlock.setCoord(x, y);
            bulletinIconUnlock.setSize(width, height);
        }

        public void setBulletinButton(int x, int y, int width, int height)
        {
            bulletinButton.setCoord(x, y);
            bulletinButton.setSize(width, height);
        }

        public void setBulletinIndicator(int x, int y, int width, int height)
        {
            bulletinIndicator.setCoord(x, y);
            bulletinIndicator.setSize(width, height);
        }

        enum AdType
        {
            Contents = 0,
            Download,
            Web,
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

        private Image arrowDown;
        private Image arrowUp;
        private Image gradientBar;
        private Image gradientTop;
        private Image gradientBottom;
        private Image iconContents;
        private Image iconDownload;
        private Image iconFacebook;
        private Image iconUnlock;
        private Image iconWeb;
        private Image button;
        private Image adShadow;
        private Image indicator;
        private AdBulletin.BulletinImage bulletinAdImage;
        private AdBulletin.BulletinImage bulletinArrowDown;
        private AdBulletin.BulletinImage bulletinArrowUp;
        private AdBulletin.BulletinImage bulletinGradientTop;
        private AdBulletin.BulletinImage bulletinGradientBottom;
        private AdBulletin.BulletinImage bulletinActiveIcon;
        private AdBulletin.BulletinImage bulletinIconUnlock;
        private AdBulletin.BulletinImage bulletinButton;
        private AdBulletin.BulletinImage bulletinIndicator;
        private AdBulletin.BulletinText bulletinDate;
        private AdBulletin.BulletinText bulletinDay;
        private AdBulletin.BulletinText bulletinTime;
        private AdBulletin.BulletinText bulletin1_9AMPM;
        private AdBulletin.BulletinText bulletin10_12AMPM;
        private AdBulletin.BulletinText bulletinLeftCost;
        private AdBulletin.BulletinText bulletinRightCost;

        public static readonly int TextNum = 7;
        public static readonly int ImageNum = 9;

        private NotiBarForm notiBarSkt;
        private AdBulletin adBulletin;
        private int showingIcons = 1;
        private int batIndex = 0;
        private bool batCharge = false;

        private Image notiLogoSkt;
        private Image notiBg;
        private Image notiKakao;
        private Image notiSms;
        private Image notiVib;
        private Image notiLte;
        private Image notiBatPer6;
        private Image notiBatPer12;
        private Image notiBatPer18;
        private Image notiBatPer24;
        private Image notiBatPer72;
        private Image notiBat6;
        private Image notiBat12;
        private Image notiBat18;
        private Image notiBat24;
        private Image notiBat72;
        private Image notiBatCharging;
        private Image notiAntenna;
        private Image notiCapture;
        private Image notiCashslide;

        public enum Icons
        {
            logo = 1,
            sms = 2,
            capture = 4,
            kakao = 8,
            cashslide = 16,
            vib = 32,
            lte = 64,
            antenna = 128,
            batPer = 256,
            all = logo | sms | capture | kakao | cashslide | vib | lte | antenna | batPer,
        };

        public enum BatPer
        {
            bat72 = 0,
            bat24 = 1,
            bat18 = 2,
            bat12 = 3,
            bat6 = 4,
            size,
        };
    }
}
