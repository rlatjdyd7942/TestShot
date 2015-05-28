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
            drawer = new TestShotDrawer(720, 1280, dateTimePicker.Value, timePicker.Value);
            examplePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            setImage(@"img/adImage.png");
            loadCompany();
            loadLeftCost();
            loadRightCost();
            List<String> adTypeSource = new List<String> {
                "Contents",
                "Download",
                "Web",
                "Video",
                "Facebook"
            };
            adTypeList.DataSource = adTypeSource;
            adTypeList.DisplayMember = "Contents";
            //adTypeList.ValueMember = "Contents";
            drawer.setArrowUpVisible(false);
        }

        private void refreshImage()
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
        private Bitmap target;
        private Bitmap adImage;
        private String adFileName;
        private String[] adFileNames;

        private const int targetWidth = 720;
        private const int targetHeight = 1280;

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

        private void loadCompany()
        {
            if (SktRadioButton.Checked)
                drawer.setCompany(0);
            else if (KtRadioButton.Checked)
                drawer.setCompany(1);
            else
                drawer.setCompany(2);
            refreshImage();
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
                for (int i = 0; i < adFileNames.Length; ++i)
                {
                    imageName = adFileNames[i];
                    drawer.setDate(date);
                    drawer.setTime(time);
                    setImage(imageName);
                    resultName = saveMultiFileDialog.SelectedPath + "\\Screenshot_" + date.ToString("yyyy-MM-dd") + "-" + time.ToString("hh-mm-ss") + ".png";
                    Console.WriteLine(resultName);
                    save(resultName);
                    date = date.AddMinutes(15);
                    time = time.AddMinutes(15);
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

        private void SktRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            loadCompany();
        }

        private void KtRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            loadCompany();
        }

        private void LgRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            loadCompany();
        }
    }
}
