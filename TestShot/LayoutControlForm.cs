using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestShot
{
    public partial class LayoutControlForm : Form
    {
        public LayoutControlForm(Form1 form1, TestShotDrawer drawer)
        {
            InitializeComponent();
            this.form1 = form1;
            this.drawer = drawer;
            init();
        }

        public void init()
        {
            List<PresetLoader.TextLayoutPreset> textPresets = PresetLoader.getTextPresets();
            put(textLayoutTime, textPresets[0]);
            put(textLayout1_9AMPM, textPresets[1]);
            put(textLayout10_12AMPM, textPresets[2]);
            put(textLayoutDate, textPresets[3]);
            put(textLayoutDay, textPresets[4]);
            put(textLayoutLeftCost, textPresets[5]);
            put(textLayoutRightCost, textPresets[6]);
            this.textLayoutTime.OnChange = new EventHandler(this.textLayoutTime_OnChange);
            this.textLayout1_9AMPM.OnChange = new EventHandler(this.textLayout1_9AMPM_OnChange);
            this.textLayout10_12AMPM.OnChange = new EventHandler(this.textLayout10_12AMPM_OnChange);
            this.textLayoutDate.OnChange = new EventHandler(this.textLayoutDate_OnChange);
            this.textLayoutDay.OnChange = new EventHandler(this.textLayoutDay_OnChange);
            this.textLayoutLeftCost.OnChange = new EventHandler(this.textLayoutLeftCost_OnChange);
            this.textLayoutRightCost.OnChange = new EventHandler(this.textLayoutRightCost_OnChange);

            List<PresetLoader.ImageLayoutPreset> imagePresets = PresetLoader.getImagePresets();
            put(imageLayoutAdImage, imagePresets[0]);
            put(imageLayoutGradientTop, imagePresets[1]);
            put(imageLayoutGradientBottom, imagePresets[2]);
            put(imageLayoutArrowUp, imagePresets[3]);
            put(imageLayoutArrowDown, imagePresets[4]);
            put(imageLayoutActiveIcon, imagePresets[5]);
            put(imageLayoutIconUnlock, imagePresets[6]);
            put(imageLayoutButton, imagePresets[7]);
            put(imageLayoutIndicator, imagePresets[8]);
            this.imageLayoutAdImage.OnChange = new EventHandler(this.imageLayoutAdImage_OnChange);
            this.imageLayoutArrowUp.OnChange = new EventHandler(this.imageLayoutArrowUp_OnChange);
            this.imageLayoutArrowDown.OnChange = new EventHandler(this.imageLayoutArrowDown_OnChange);
            this.imageLayoutGradientTop.OnChange = new EventHandler(this.imageLayoutGradientTop_OnChange);
            this.imageLayoutGradientBottom.OnChange = new EventHandler(this.imageLayoutGradientBottom_OnChange);
            this.imageLayoutActiveIcon.OnChange = new EventHandler(this.imageLayoutActiveIcon_OnChange);
            this.imageLayoutIconUnlock.OnChange = new EventHandler(this.imageLayoutIconUnlock_OnChange);
            this.imageLayoutButton.OnChange = new EventHandler(this.imageLayoutButton_OnChange);
            this.imageLayoutIndicator.OnChange = new EventHandler(this.imageLayoutIndicator_OnChange);
        }

        private void put(TestShotImageLayoutControl imageLayout, PresetLoader.ImageLayoutPreset imagePreset)
        {
            imageLayout.X = imagePreset.x;
            imageLayout.Y = imagePreset.y;
            imageLayout.SizeWidth = imagePreset.width;
            imageLayout.SizeHeight = imagePreset.height;
        }

        private void put(PresetLoader.ImageLayoutPreset imagePreset, TestShotImageLayoutControl imageLayout)
        {
            imagePreset.x = imageLayout.X;
            imagePreset.y = imageLayout.Y;
            imagePreset.width = imageLayout.SizeWidth;
            imagePreset.height = imageLayout.SizeHeight;
        }

        private void put(TestShotTextLayoutControl textLayout, PresetLoader.TextLayoutPreset textPreset)
        {
            textLayout.X = textPreset.x;
            textLayout.Y = textPreset.y;
            textLayout.FontName = textPreset.fontName;
            textLayout.FontSize = textPreset.fontSize;
            textLayout.updateFontText();
        }

        private void put(PresetLoader.TextLayoutPreset textPreset, TestShotTextLayoutControl textLayout)
        {
            textPreset.x = textLayout.X;
            textPreset.y = textLayout.Y;
            textPreset.fontName = textLayout.FontName;
            textPreset.fontSize = textLayout.FontSize;
        }

        private Font getFont(TestShotTextLayoutControl textLayout)
        {
            Font font = new Font(textLayout.FontName, textLayout.FontSize);
            return font;
        }

        private Form1 form1;
        private TestShotDrawer drawer;
        
        private void textLayoutTime_OnChange(object sender, EventArgs e)
        {
            Font font = getFont(textLayoutTime);
            drawer.setBulletinTime(textLayoutTime.X, textLayoutTime.Y, font);
            form1.refreshImage();
        }

        private void textLayout1_9AMPM_OnChange(object sender, EventArgs e)
        {
            Font font = getFont(textLayout1_9AMPM);
            drawer.setBulletin1_9AMPM(textLayout1_9AMPM.X, textLayout1_9AMPM.Y, font);
            form1.refreshImage();
        }

        private void textLayout10_12AMPM_OnChange(object sender, EventArgs e)
        {
            Font font = getFont(textLayout10_12AMPM);
            drawer.setBulletin10_12AMPM(textLayout10_12AMPM.X, textLayout10_12AMPM.Y, font);
            form1.refreshImage();
        }

        private void textLayoutDate_OnChange(object sender, EventArgs e)
        {
            Font font = getFont(textLayoutDate);
            drawer.setBulletinDate(textLayoutDate.X, textLayoutDate.Y, font);
            form1.refreshImage();
        }

        private void textLayoutDay_OnChange(object sender, EventArgs e)
        {
            Font font = getFont(textLayoutDay);
            drawer.setBulletinDay(textLayoutDay.X, textLayoutDay.Y, font);
            form1.refreshImage();
        }

        private void textLayoutLeftCost_OnChange(object sender, EventArgs e)
        {
            Font font = getFont(textLayoutLeftCost);
            drawer.setBulletinLeftCost(textLayoutLeftCost.X, textLayoutLeftCost.Y, font);
            form1.refreshImage();
        }

        private void textLayoutRightCost_OnChange(object sender, EventArgs e)
        {
            Font font = getFont(textLayoutRightCost);
            drawer.setBulletinRightCost(textLayoutRightCost.X, textLayoutRightCost.Y, font);
            form1.refreshImage();
        }

        private void imageLayoutAdImage_OnChange(object sender, EventArgs e)
        {
            if (imageLayoutAdImage.Width != 0 && imageLayoutAdImage.Height != 0)
                drawer.setBulletinAdImage(imageLayoutAdImage.X, imageLayoutAdImage.Y,
                    imageLayoutAdImage.SizeWidth, imageLayoutAdImage.SizeHeight);
            form1.refreshImage();
        }

        private void imageLayoutArrowUp_OnChange(object sender, EventArgs e)
        {
            if (imageLayoutArrowUp.Width != 0 && imageLayoutArrowUp.Height != 0)
                drawer.setBulletinArrowUp(imageLayoutArrowUp.X, imageLayoutArrowUp.Y,
                    imageLayoutArrowUp.SizeWidth, imageLayoutArrowUp.SizeHeight);
            form1.refreshImage();
        }

        private void imageLayoutArrowDown_OnChange(object sender, EventArgs e)
        {
            if (imageLayoutArrowDown.Width != 0 && imageLayoutArrowDown.Height != 0)
                drawer.setBulletinArrowDown(imageLayoutArrowDown.X, imageLayoutArrowDown.Y,
                    imageLayoutArrowDown.SizeWidth, imageLayoutArrowDown.SizeHeight);
            form1.refreshImage();
        }

        private void imageLayoutGradientTop_OnChange(object sender, EventArgs e)
        {
            if (imageLayoutGradientTop.Width != 0 && imageLayoutGradientTop.Height != 0)
                drawer.setBulletinGradientTop(imageLayoutGradientTop.X, imageLayoutGradientTop.Y,
                    imageLayoutGradientTop.SizeWidth, imageLayoutGradientTop.SizeHeight);
            form1.refreshImage();
        }

        private void imageLayoutGradientBottom_OnChange(object sender, EventArgs e)
        {
            if (imageLayoutGradientBottom.Width != 0 && imageLayoutGradientBottom.Height != 0)
                drawer.setBulletinGradientBottom(imageLayoutGradientBottom.X, imageLayoutGradientBottom.Y,
                    imageLayoutGradientBottom.SizeWidth, imageLayoutGradientBottom.SizeHeight);
            form1.refreshImage();
        }

        private void imageLayoutActiveIcon_OnChange(object sender, EventArgs e)
        {
            if (imageLayoutActiveIcon.Width != 0 && imageLayoutActiveIcon.Height != 0)
                drawer.setBulletinActiveIcon(imageLayoutActiveIcon.X, imageLayoutActiveIcon.Y,
                    imageLayoutActiveIcon.SizeWidth, imageLayoutActiveIcon.SizeHeight);
            form1.refreshImage();
        }

        private void imageLayoutIconUnlock_OnChange(object sender, EventArgs e)
        {
            if (imageLayoutIconUnlock.Width != 0 && imageLayoutIconUnlock.Height != 0)
                drawer.setBulletinIconUnlock(imageLayoutIconUnlock.X, imageLayoutIconUnlock.Y,
                    imageLayoutIconUnlock.SizeWidth, imageLayoutIconUnlock.SizeHeight);
            form1.refreshImage();
        }

        private void imageLayoutButton_OnChange(object sender, EventArgs e)
        {
            if (imageLayoutButton.Width != 0 && imageLayoutButton.Height != 0)
                drawer.setBulletinButton(imageLayoutButton.X, imageLayoutButton.Y,
                    imageLayoutButton.SizeWidth, imageLayoutButton.SizeHeight);
            form1.refreshImage();
        }

        private void imageLayoutIndicator_OnChange(object sender, EventArgs e)
        {
            if (imageLayoutIndicator.Width != 0 && imageLayoutIndicator.Height != 0)
                drawer.setBulletinIndicator(imageLayoutIndicator.X, imageLayoutIndicator.Y,
                    imageLayoutIndicator.SizeWidth, imageLayoutIndicator.SizeHeight);
            form1.refreshImage();
        }

        private void presetSaveButton_Click(object sender, EventArgs e)
        {
            List<PresetLoader.TextLayoutPreset> textPresets = PresetLoader.getTextPresets();
            put(textPresets[0], textLayoutTime);
            put(textPresets[1], textLayout1_9AMPM);
            put(textPresets[2], textLayout10_12AMPM);
            put(textPresets[3], textLayoutDate);
            put(textPresets[4], textLayoutDay);
            put(textPresets[5], textLayoutLeftCost);
            put(textPresets[6], textLayoutRightCost);

            List<PresetLoader.ImageLayoutPreset> imagePresets = PresetLoader.getImagePresets();
            put(imagePresets[0], imageLayoutAdImage);
            put(imagePresets[1], imageLayoutGradientTop);
            put(imagePresets[2], imageLayoutGradientBottom);
            put(imagePresets[3], imageLayoutArrowUp);
            put(imagePresets[4], imageLayoutArrowDown);
            put(imagePresets[5], imageLayoutActiveIcon);
            put(imagePresets[6], imageLayoutIconUnlock);
            put(imagePresets[7], imageLayoutButton);
            put(imagePresets[8], imageLayoutIndicator);

            PresetLoader.savePresets();
        }
    }
}
