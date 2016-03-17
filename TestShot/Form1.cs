using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TestShot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(this.Form1_DragEnter);
            this.DragDrop += new DragEventHandler(this.Form1_DragDrop);
            //target = new Bitmap(1080, 1850);
            target = new Bitmap(targetWidth, targetHeight);
            //drawer = new TestShotDrawer(1080, 1845);
            drawer = new TestShotDrawer(targetWidth, targetHeight, dateTimePicker.Value, timePicker.Value);
            examplePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            setImage(@"img/adImage.png");
            loadLeftCost();
            loadRightCost();
            List<String> batPerSource = new List<String> {
                "72",
                "24",
                "18",
                "12",
                "6"
            };
            batPerList.DataSource = batPerSource;
            drawer.setArrowUpVisible(false);
            iconsChanged();
            List<String> adTypeSource = new List<String> {
                "Contents",
                "Download",
                "Web",
                "Facebook"
            };
            adTypeList.DataSource = adTypeSource;
            adTypeList.DisplayMember = "Contents";
            //adTypeList.ValueMember = "Contents";

            ////
            adBulletin = drawer.getAdBulletin();
        }

        public void refreshImage()
        {
            drawer.draw();
            examplePictureBox.Image = drawer.getTestShot();
        }

        private void setImage(String fileName)
        {
            adFileName = fileName;
            adImage = new Bitmap(adFileName);
            drawer.setAdImage(adImage);
            drawer.draw();
            this.refreshImage();
        }

        private TestShotDrawer drawer;
        private TestShotDrawer.AdBulletin adBulletin;
        private Bitmap target;
        private Bitmap adImage;
        private String adFileName;
        private String[] adFileNames;

        private const int targetWidth = 1080;
        private const int targetHeight = 1920;

        private void save(String fileName)
        {
            using (Graphics g = Graphics.FromImage(target))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                Image img = drawer.getTestShot();
                g.DrawImage(img, new Rectangle(0, 0, targetWidth, targetHeight));
                target.Save(fileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            DateTime time = timePicker.Value;
            String newFileName = "Screenshot_" + date.ToString("yyyy-MM-dd") + "-" + time.ToString("hh-mm-ss") + ".png";
            saveFileDialog.FileName = newFileName;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (checkRandomIcon.Checked)
                {
                    iconRandomize();
                    refreshImage();
                }
                save(saveFileDialog.FileName);
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                setImage(openFileDialog.FileName);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1)
            {
                setImage(files[0]);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            drawer.setDate(date);
            this.refreshImage();
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime time = timePicker.Value;
            drawer.setTime(time);
            this.refreshImage();
        }

        private void leftCostTextBox_TextChanged(object sender, EventArgs e)
        {
            loadLeftCost();
        }

        private void rightCostTextBox_TextChanged(object sender, EventArgs e)
        {
            loadRightCost();
        }

        private void loadLeftCost()
        {
            int cost = 0;
            if (Int32.TryParse(leftCostTextBox.Text, out cost))
                drawer.setLeftCost(cost);
            else
                drawer.setLeftCost(0);
            refreshImage();
        }

        private void loadRightCost()
        {
            int cost = 0;
            if (Int32.TryParse(rightCostTextBox.Text, out cost))
                drawer.setRightCost(cost);
            else
                drawer.setRightCost(0);
            refreshImage();
        }

        private void adTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawer.setAdType(adTypeList.SelectedIndex);
            refreshImage();
        }

        private void showArrowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            drawer.setArrowUpVisible(showArrowCheckBox.Checked);
            refreshImage();
        }

        private void saveMultiFileButton_Click(object sender, EventArgs e)
        {
            if (saveMultiFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DateTime date = dateTimePicker.Value;
                DateTime time = timePicker.Value;
                String imageName = null;
                String resultName = null;
                if (checkRandomIcon.Checked)
                    iconRandomize();
                for (int i = 0; i < adFileNames.Length; ++i)
                {
                    imageName = adFileNames[i];
                    drawer.setDate(date);
                    drawer.setTime(time);
                    setImage(imageName);
                    resultName = saveMultiFileDialog.SelectedPath + "\\Screenshot_" + date.ToString("yyyy-MM-dd") + "-" + time.ToString("hh-mm-ss") + ".png";
                    Console.WriteLine(resultName);
                    save(resultName);
                    //date = date.AddMinutes(15);
                    //time = time.AddMinutes(15);
                    date = date.AddSeconds(20);
                    time = time.AddSeconds(20);
                }
            }
        }

        private void openMultiFileButton_Click(object sender, EventArgs e)
        {
            if (openMultiFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                adFileNames = openMultiFileDialog.FileNames;
                Console.WriteLine("adFileName.Length : " + adFileNames.Length);
            }
        }

        private void iconRandomize()
        {
            Random r = new Random();
            int icons = 1;
            if (checkIconSms.Checked)
                icons |= (int)TestShotDrawer.Icons.sms;
            if (checkIconCapture.Checked)
                icons |= (int)TestShotDrawer.Icons.capture;
            if (checkIconKakao.Checked)
                icons |= (int)TestShotDrawer.Icons.kakao;
            if (checkIconVib.Checked)
                icons |= (int)TestShotDrawer.Icons.vib;
            if (checkIconCashslide.Checked)
                icons |= (int)TestShotDrawer.Icons.cashslide;
            if (checkIconLte.Checked)
                icons |= (int)TestShotDrawer.Icons.lte;
            if (checkIconAntenna.Checked)
                icons |= (int)TestShotDrawer.Icons.antenna;
            if (checkIconBatPer.Checked)
                icons |= (int)TestShotDrawer.Icons.batPer;
            icons |= r.Next((int)TestShotDrawer.Icons.all + 1);
            drawer.setShowingIcons(icons);
            drawer.setBatPer(r.Next(batPerList.Items.Count), r.Next(2) == 1 ? true : false);
        }

        private void iconsChanged()
        {
            int showingIcons = 1;
            if (checkIconSms.Checked)
                showingIcons |= (int)TestShotDrawer.Icons.sms;
            if (checkIconCapture.Checked)
                showingIcons |= (int)TestShotDrawer.Icons.capture;
            if (checkIconKakao.Checked)
                showingIcons |= (int)TestShotDrawer.Icons.kakao;
            if (checkIconVib.Checked)
                showingIcons |= (int)TestShotDrawer.Icons.vib;
            if (checkIconCashslide.Checked)
                showingIcons |= (int)TestShotDrawer.Icons.cashslide;
            if (checkIconLte.Checked)
                showingIcons |= (int)TestShotDrawer.Icons.lte;
            if (checkIconAntenna.Checked)
                showingIcons |= (int)TestShotDrawer.Icons.antenna;
            if (checkIconBatPer.Checked)
                showingIcons |= (int)TestShotDrawer.Icons.batPer;
            drawer.setShowingIcons(showingIcons);
            drawer.setBatPer(batPerList.SelectedIndex, chargeCheck.Checked);
            refreshImage();
        }

        private void checkIconSms_CheckedChanged(object sender, EventArgs e)
        {
            iconsChanged();
        }

        private void checkIconCapture_CheckedChanged(object sender, EventArgs e)
        {
            iconsChanged();
        }

        private void checkIconKakao_CheckedChanged(object sender, EventArgs e)
        {
            iconsChanged();
        }

        private void checkIconVib_CheckedChanged(object sender, EventArgs e)
        {
            iconsChanged();
        }

        private void checkIconLte_CheckedChanged(object sender, EventArgs e)
        {
            iconsChanged();
        }

        private void checkIconAntenna_CheckedChanged(object sender, EventArgs e)
        {
            iconsChanged();
        }

        private void checkIconBatPer_CheckedChanged(object sender, EventArgs e)
        {
            iconsChanged();
        }

        private void batPerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            iconsChanged();
        }

        private void chargeCheck_CheckedChanged(object sender, EventArgs e)
        {
            iconsChanged();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void layoutFormButton_Click(object sender, EventArgs e)
        {
            LayoutControlForm form = new LayoutControlForm(this, drawer);
            form.Show();
        }
    }
}
