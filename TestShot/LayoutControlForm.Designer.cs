namespace TestShot
{
    partial class LayoutControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.imagePage = new System.Windows.Forms.TabPage();
            this.imageLayoutIndicator = new TestShot.TestShotImageLayoutControl();
            this.imageLayoutButton = new TestShot.TestShotImageLayoutControl();
            this.imageLayoutIconUnlock = new TestShot.TestShotImageLayoutControl();
            this.imageLayoutActiveIcon = new TestShot.TestShotImageLayoutControl();
            this.imageLayoutGradientBottom = new TestShot.TestShotImageLayoutControl();
            this.imageLayoutGradientTop = new TestShot.TestShotImageLayoutControl();
            this.imageLayoutArrowDown = new TestShot.TestShotImageLayoutControl();
            this.imageLayoutArrowUp = new TestShot.TestShotImageLayoutControl();
            this.imageLayoutAdImage = new TestShot.TestShotImageLayoutControl();
            this.textPage = new System.Windows.Forms.TabPage();
            this.textLayoutRightCost = new TestShot.TestShotTextLayoutControl();
            this.textLayoutLeftCost = new TestShot.TestShotTextLayoutControl();
            this.textLayoutDay = new TestShot.TestShotTextLayoutControl();
            this.textLayoutDate = new TestShot.TestShotTextLayoutControl();
            this.textLayoutAMPM = new TestShot.TestShotTextLayoutControl();
            this.textLayoutTime = new TestShot.TestShotTextLayoutControl();
            this.presetSaveButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.imagePage.SuspendLayout();
            this.textPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.imagePage);
            this.tabControl.Controls.Add(this.textPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(597, 555);
            this.tabControl.TabIndex = 0;
            // 
            // imagePage
            // 
            this.imagePage.AutoScroll = true;
            this.imagePage.Controls.Add(this.imageLayoutIndicator);
            this.imagePage.Controls.Add(this.imageLayoutButton);
            this.imagePage.Controls.Add(this.imageLayoutIconUnlock);
            this.imagePage.Controls.Add(this.imageLayoutActiveIcon);
            this.imagePage.Controls.Add(this.imageLayoutGradientBottom);
            this.imagePage.Controls.Add(this.imageLayoutGradientTop);
            this.imagePage.Controls.Add(this.imageLayoutArrowDown);
            this.imagePage.Controls.Add(this.imageLayoutArrowUp);
            this.imagePage.Controls.Add(this.imageLayoutAdImage);
            this.imagePage.Location = new System.Drawing.Point(4, 22);
            this.imagePage.Name = "imagePage";
            this.imagePage.Padding = new System.Windows.Forms.Padding(3);
            this.imagePage.Size = new System.Drawing.Size(589, 529);
            this.imagePage.TabIndex = 0;
            this.imagePage.Text = "이미지";
            this.imagePage.UseVisualStyleBackColor = true;
            // 
            // imageLayoutIndicator
            // 
            this.imageLayoutIndicator.Location = new System.Drawing.Point(384, 338);
            this.imageLayoutIndicator.Name = "imageLayoutIndicator";
            this.imageLayoutIndicator.Size = new System.Drawing.Size(182, 160);
            this.imageLayoutIndicator.SizeHeight = 0;
            this.imageLayoutIndicator.SizeWidth = 0;
            this.imageLayoutIndicator.TabIndex = 9;
            this.imageLayoutIndicator.Text = "인디케이터";
            this.imageLayoutIndicator.X = 0;
            this.imageLayoutIndicator.Y = 0;
            // 
            // imageLayoutButton
            // 
            this.imageLayoutButton.Location = new System.Drawing.Point(196, 338);
            this.imageLayoutButton.Name = "imageLayoutButton";
            this.imageLayoutButton.Size = new System.Drawing.Size(182, 160);
            this.imageLayoutButton.SizeHeight = 0;
            this.imageLayoutButton.SizeWidth = 0;
            this.imageLayoutButton.TabIndex = 8;
            this.imageLayoutButton.Text = "버튼";
            this.imageLayoutButton.X = 0;
            this.imageLayoutButton.Y = 0;
            // 
            // imageLayoutIconUnlock
            // 
            this.imageLayoutIconUnlock.Location = new System.Drawing.Point(8, 338);
            this.imageLayoutIconUnlock.Name = "imageLayoutIconUnlock";
            this.imageLayoutIconUnlock.Size = new System.Drawing.Size(182, 160);
            this.imageLayoutIconUnlock.SizeHeight = 0;
            this.imageLayoutIconUnlock.SizeWidth = 0;
            this.imageLayoutIconUnlock.TabIndex = 7;
            this.imageLayoutIconUnlock.Text = "해제아이콘";
            this.imageLayoutIconUnlock.X = 0;
            this.imageLayoutIconUnlock.Y = 0;
            // 
            // imageLayoutActiveIcon
            // 
            this.imageLayoutActiveIcon.Location = new System.Drawing.Point(384, 172);
            this.imageLayoutActiveIcon.Name = "imageLayoutActiveIcon";
            this.imageLayoutActiveIcon.Size = new System.Drawing.Size(182, 160);
            this.imageLayoutActiveIcon.SizeHeight = 0;
            this.imageLayoutActiveIcon.SizeWidth = 0;
            this.imageLayoutActiveIcon.TabIndex = 6;
            this.imageLayoutActiveIcon.Text = "실행아이콘";
            this.imageLayoutActiveIcon.X = 0;
            this.imageLayoutActiveIcon.Y = 0;
            // 
            // imageLayoutGradientBottom
            // 
            this.imageLayoutGradientBottom.Location = new System.Drawing.Point(196, 172);
            this.imageLayoutGradientBottom.Name = "imageLayoutGradientBottom";
            this.imageLayoutGradientBottom.Size = new System.Drawing.Size(182, 160);
            this.imageLayoutGradientBottom.SizeHeight = 0;
            this.imageLayoutGradientBottom.SizeWidth = 0;
            this.imageLayoutGradientBottom.TabIndex = 5;
            this.imageLayoutGradientBottom.Text = "아래쪽그림자";
            this.imageLayoutGradientBottom.X = 0;
            this.imageLayoutGradientBottom.Y = 0;
            // 
            // imageLayoutGradientTop
            // 
            this.imageLayoutGradientTop.Location = new System.Drawing.Point(8, 172);
            this.imageLayoutGradientTop.Name = "imageLayoutGradientTop";
            this.imageLayoutGradientTop.Size = new System.Drawing.Size(182, 160);
            this.imageLayoutGradientTop.SizeHeight = 0;
            this.imageLayoutGradientTop.SizeWidth = 0;
            this.imageLayoutGradientTop.TabIndex = 4;
            this.imageLayoutGradientTop.Text = "위쪽그림자";
            this.imageLayoutGradientTop.X = 0;
            this.imageLayoutGradientTop.Y = 0;
            // 
            // imageLayoutArrowDown
            // 
            this.imageLayoutArrowDown.Location = new System.Drawing.Point(384, 6);
            this.imageLayoutArrowDown.Name = "imageLayoutArrowDown";
            this.imageLayoutArrowDown.Size = new System.Drawing.Size(182, 160);
            this.imageLayoutArrowDown.SizeHeight = 0;
            this.imageLayoutArrowDown.SizeWidth = 0;
            this.imageLayoutArrowDown.TabIndex = 3;
            this.imageLayoutArrowDown.Text = "아래쪽화살표";
            this.imageLayoutArrowDown.X = 0;
            this.imageLayoutArrowDown.Y = 0;
            // 
            // imageLayoutArrowUp
            // 
            this.imageLayoutArrowUp.Location = new System.Drawing.Point(196, 6);
            this.imageLayoutArrowUp.Name = "imageLayoutArrowUp";
            this.imageLayoutArrowUp.Size = new System.Drawing.Size(182, 160);
            this.imageLayoutArrowUp.SizeHeight = 0;
            this.imageLayoutArrowUp.SizeWidth = 0;
            this.imageLayoutArrowUp.TabIndex = 2;
            this.imageLayoutArrowUp.Text = "위쪽화살표";
            this.imageLayoutArrowUp.X = 0;
            this.imageLayoutArrowUp.Y = 0;
            // 
            // imageLayoutAdImage
            // 
            this.imageLayoutAdImage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imageLayoutAdImage.Location = new System.Drawing.Point(8, 6);
            this.imageLayoutAdImage.Name = "imageLayoutAdImage";
            this.imageLayoutAdImage.Size = new System.Drawing.Size(182, 160);
            this.imageLayoutAdImage.SizeHeight = 0;
            this.imageLayoutAdImage.SizeWidth = 0;
            this.imageLayoutAdImage.TabIndex = 0;
            this.imageLayoutAdImage.Text = "광고이미지";
            this.imageLayoutAdImage.X = 0;
            this.imageLayoutAdImage.Y = 0;
            // 
            // textPage
            // 
            this.textPage.AutoScroll = true;
            this.textPage.Controls.Add(this.textLayoutRightCost);
            this.textPage.Controls.Add(this.textLayoutLeftCost);
            this.textPage.Controls.Add(this.textLayoutDay);
            this.textPage.Controls.Add(this.textLayoutDate);
            this.textPage.Controls.Add(this.textLayoutAMPM);
            this.textPage.Controls.Add(this.textLayoutTime);
            this.textPage.Location = new System.Drawing.Point(4, 22);
            this.textPage.Name = "textPage";
            this.textPage.Padding = new System.Windows.Forms.Padding(3);
            this.textPage.Size = new System.Drawing.Size(589, 529);
            this.textPage.TabIndex = 1;
            this.textPage.Text = "텍스트";
            this.textPage.UseVisualStyleBackColor = true;
            // 
            // textLayoutRightCost
            // 
            this.textLayoutRightCost.Location = new System.Drawing.Point(384, 172);
            this.textLayoutRightCost.Name = "textLayoutRightCost";
            this.textLayoutRightCost.Size = new System.Drawing.Size(182, 160);
            this.textLayoutRightCost.TabIndex = 6;
            this.textLayoutRightCost.Text = "해제적립금";
            this.textLayoutRightCost.X = 0;
            this.textLayoutRightCost.Y = 0;
            // 
            // textLayoutLeftCost
            // 
            this.textLayoutLeftCost.Location = new System.Drawing.Point(196, 172);
            this.textLayoutLeftCost.Name = "textLayoutLeftCost";
            this.textLayoutLeftCost.Size = new System.Drawing.Size(182, 160);
            this.textLayoutLeftCost.TabIndex = 3;
            this.textLayoutLeftCost.Text = "실행적립금";
            this.textLayoutLeftCost.X = 0;
            this.textLayoutLeftCost.Y = 0;
            // 
            // textLayoutDay
            // 
            this.textLayoutDay.Location = new System.Drawing.Point(8, 172);
            this.textLayoutDay.Name = "textLayoutDay";
            this.textLayoutDay.Size = new System.Drawing.Size(182, 160);
            this.textLayoutDay.TabIndex = 5;
            this.textLayoutDay.Text = "요일";
            this.textLayoutDay.X = 0;
            this.textLayoutDay.Y = 0;
            // 
            // textLayoutDate
            // 
            this.textLayoutDate.Location = new System.Drawing.Point(384, 6);
            this.textLayoutDate.Name = "textLayoutDate";
            this.textLayoutDate.Size = new System.Drawing.Size(182, 160);
            this.textLayoutDate.TabIndex = 4;
            this.textLayoutDate.Text = "날짜";
            this.textLayoutDate.X = 0;
            this.textLayoutDate.Y = 0;
            // 
            // textLayoutAMPM
            // 
            this.textLayoutAMPM.Location = new System.Drawing.Point(196, 6);
            this.textLayoutAMPM.Name = "textLayoutAMPM";
            this.textLayoutAMPM.Size = new System.Drawing.Size(182, 160);
            this.textLayoutAMPM.TabIndex = 2;
            this.textLayoutAMPM.Text = "AMPM";
            this.textLayoutAMPM.X = 0;
            this.textLayoutAMPM.Y = 0;
            // 
            // textLayoutTime
            // 
            this.textLayoutTime.Location = new System.Drawing.Point(8, 6);
            this.textLayoutTime.Name = "textLayoutTime";
            this.textLayoutTime.Size = new System.Drawing.Size(182, 160);
            this.textLayoutTime.TabIndex = 1;
            this.textLayoutTime.Text = "시간";
            this.textLayoutTime.X = 0;
            this.textLayoutTime.Y = 0;
            // 
            // presetSaveButton
            // 
            this.presetSaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.presetSaveButton.Location = new System.Drawing.Point(0, 524);
            this.presetSaveButton.Name = "presetSaveButton";
            this.presetSaveButton.Size = new System.Drawing.Size(597, 31);
            this.presetSaveButton.TabIndex = 1;
            this.presetSaveButton.Text = "프리셋 저장";
            this.presetSaveButton.UseVisualStyleBackColor = true;
            this.presetSaveButton.Click += new System.EventHandler(this.presetSaveButton_Click);
            // 
            // LayoutControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 555);
            this.Controls.Add(this.presetSaveButton);
            this.Controls.Add(this.tabControl);
            this.Name = "LayoutControlForm";
            this.Text = "LayoutControlForm";
            this.tabControl.ResumeLayout(false);
            this.imagePage.ResumeLayout(false);
            this.textPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage imagePage;
        private System.Windows.Forms.TabPage textPage;
        private TestShotTextLayoutControl textLayoutDay;
        private TestShotTextLayoutControl textLayoutDate;
        private TestShotTextLayoutControl textLayoutAMPM;
        private TestShotTextLayoutControl textLayoutTime;
        private TestShotTextLayoutControl textLayoutRightCost;
        private TestShotTextLayoutControl textLayoutLeftCost;
        private TestShotImageLayoutControl imageLayoutAdImage;
        private TestShotImageLayoutControl imageLayoutIndicator;
        private TestShotImageLayoutControl imageLayoutButton;
        private TestShotImageLayoutControl imageLayoutIconUnlock;
        private TestShotImageLayoutControl imageLayoutActiveIcon;
        private TestShotImageLayoutControl imageLayoutGradientBottom;
        private TestShotImageLayoutControl imageLayoutGradientTop;
        private TestShotImageLayoutControl imageLayoutArrowDown;
        private TestShotImageLayoutControl imageLayoutArrowUp;
        private System.Windows.Forms.Button presetSaveButton;
    }
}