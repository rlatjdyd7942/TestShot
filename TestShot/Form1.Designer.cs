namespace TestShot
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.leftCostTextBox = new System.Windows.Forms.TextBox();
            this.rightCostTextBox = new System.Windows.Forms.TextBox();
            this.adTypeList = new System.Windows.Forms.ComboBox();
            this.showArrowCheckBox = new System.Windows.Forms.CheckBox();
            this.saveMultiFileButton = new System.Windows.Forms.Button();
            this.openMultiFileButton = new System.Windows.Forms.Button();
            this.openMultiFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveMultiFileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBatFixed = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chargeCheck = new System.Windows.Forms.CheckBox();
            this.batPerList = new System.Windows.Forms.ComboBox();
            this.checkIconCashslide = new System.Windows.Forms.CheckBox();
            this.checkIconLte = new System.Windows.Forms.CheckBox();
            this.checkIconBatPer = new System.Windows.Forms.CheckBox();
            this.checkIconAntenna = new System.Windows.Forms.CheckBox();
            this.checkIconVib = new System.Windows.Forms.CheckBox();
            this.checkRandomIcon = new System.Windows.Forms.CheckBox();
            this.checkIconCapture = new System.Windows.Forms.CheckBox();
            this.checkIconSms = new System.Windows.Forms.CheckBox();
            this.checkIconKakao = new System.Windows.Forms.CheckBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.examplePictureBox = new System.Windows.Forms.PictureBox();
            this.layoutFormButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(340, 387);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Tag = "openFileButton";
            this.openFileButton.Text = "파일 열기";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(340, 416);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Tag = "saveButton";
            this.saveButton.Text = "저장";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(258, 252);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(156, 21);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Tag = "dateTimePicker";
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(258, 279);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(156, 21);
            this.timePicker.TabIndex = 5;
            this.timePicker.Tag = "timePicker";
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Tag = "saveFileDialog";
            // 
            // leftCostTextBox
            // 
            this.leftCostTextBox.Location = new System.Drawing.Point(258, 333);
            this.leftCostTextBox.Name = "leftCostTextBox";
            this.leftCostTextBox.Size = new System.Drawing.Size(74, 21);
            this.leftCostTextBox.TabIndex = 6;
            this.leftCostTextBox.Text = "5";
            this.leftCostTextBox.TextChanged += new System.EventHandler(this.leftCostTextBox_TextChanged);
            // 
            // rightCostTextBox
            // 
            this.rightCostTextBox.Location = new System.Drawing.Point(340, 333);
            this.rightCostTextBox.Name = "rightCostTextBox";
            this.rightCostTextBox.Size = new System.Drawing.Size(74, 21);
            this.rightCostTextBox.TabIndex = 7;
            this.rightCostTextBox.Text = "4";
            this.rightCostTextBox.TextChanged += new System.EventHandler(this.rightCostTextBox_TextChanged);
            // 
            // adTypeList
            // 
            this.adTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adTypeList.FormattingEnabled = true;
            this.adTypeList.Location = new System.Drawing.Point(257, 307);
            this.adTypeList.Name = "adTypeList";
            this.adTypeList.Size = new System.Drawing.Size(157, 20);
            this.adTypeList.TabIndex = 8;
            this.adTypeList.SelectedIndexChanged += new System.EventHandler(this.adTypeList_SelectedIndexChanged);
            // 
            // showArrowCheckBox
            // 
            this.showArrowCheckBox.AutoSize = true;
            this.showArrowCheckBox.Location = new System.Drawing.Point(258, 364);
            this.showArrowCheckBox.Name = "showArrowCheckBox";
            this.showArrowCheckBox.Size = new System.Drawing.Size(128, 16);
            this.showArrowCheckBox.TabIndex = 9;
            this.showArrowCheckBox.Tag = "showArrowCheckBox";
            this.showArrowCheckBox.Text = "위쪽 화살표 보이기";
            this.showArrowCheckBox.UseVisualStyleBackColor = true;
            this.showArrowCheckBox.CheckedChanged += new System.EventHandler(this.showArrowCheckBox_CheckedChanged);
            // 
            // saveMultiFileButton
            // 
            this.saveMultiFileButton.Location = new System.Drawing.Point(259, 416);
            this.saveMultiFileButton.Name = "saveMultiFileButton";
            this.saveMultiFileButton.Size = new System.Drawing.Size(75, 23);
            this.saveMultiFileButton.TabIndex = 10;
            this.saveMultiFileButton.Tag = "saveMultiFileButton";
            this.saveMultiFileButton.Text = "여러개저장";
            this.saveMultiFileButton.UseVisualStyleBackColor = true;
            this.saveMultiFileButton.Click += new System.EventHandler(this.saveMultiFileButton_Click);
            // 
            // openMultiFileButton
            // 
            this.openMultiFileButton.Location = new System.Drawing.Point(259, 387);
            this.openMultiFileButton.Name = "openMultiFileButton";
            this.openMultiFileButton.Size = new System.Drawing.Size(75, 23);
            this.openMultiFileButton.TabIndex = 11;
            this.openMultiFileButton.Tag = "openMultiFileButton";
            this.openMultiFileButton.Text = "여러개열기";
            this.openMultiFileButton.UseVisualStyleBackColor = true;
            this.openMultiFileButton.Click += new System.EventHandler(this.openMultiFileButton_Click);
            // 
            // openMultiFileDialog
            // 
            this.openMultiFileDialog.FileName = "openMultiFileDialog";
            this.openMultiFileDialog.Multiselect = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBatFixed);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.checkIconCashslide);
            this.groupBox2.Controls.Add(this.checkIconLte);
            this.groupBox2.Controls.Add(this.checkIconBatPer);
            this.groupBox2.Controls.Add(this.checkIconAntenna);
            this.groupBox2.Controls.Add(this.checkIconVib);
            this.groupBox2.Controls.Add(this.checkRandomIcon);
            this.groupBox2.Controls.Add(this.checkIconCapture);
            this.groupBox2.Controls.Add(this.checkIconSms);
            this.groupBox2.Controls.Add(this.checkIconKakao);
            this.groupBox2.Location = new System.Drawing.Point(259, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 234);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "아이콘";
            // 
            // checkBatFixed
            // 
            this.checkBatFixed.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBatFixed.Location = new System.Drawing.Point(9, 92);
            this.checkBatFixed.Name = "checkBatFixed";
            this.checkBatFixed.Size = new System.Drawing.Size(138, 25);
            this.checkBatFixed.TabIndex = 24;
            this.checkBatFixed.Text = "배터리 고정";
            this.checkBatFixed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBatFixed.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chargeCheck);
            this.groupBox1.Controls.Add(this.batPerList);
            this.groupBox1.Location = new System.Drawing.Point(9, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "배터리";
            // 
            // chargeCheck
            // 
            this.chargeCheck.AutoSize = true;
            this.chargeCheck.Location = new System.Drawing.Point(9, 46);
            this.chargeCheck.Name = "chargeCheck";
            this.chargeCheck.Size = new System.Drawing.Size(88, 16);
            this.chargeCheck.TabIndex = 23;
            this.chargeCheck.Text = "충전 아이콘";
            this.chargeCheck.UseVisualStyleBackColor = true;
            this.chargeCheck.CheckedChanged += new System.EventHandler(this.chargeCheck_CheckedChanged);
            // 
            // batPerList
            // 
            this.batPerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.batPerList.FormattingEnabled = true;
            this.batPerList.Items.AddRange(new object[] {
            "72",
            "24",
            "18",
            "12",
            "6"});
            this.batPerList.Location = new System.Drawing.Point(9, 20);
            this.batPerList.Name = "batPerList";
            this.batPerList.Size = new System.Drawing.Size(123, 20);
            this.batPerList.TabIndex = 0;
            this.batPerList.SelectedIndexChanged += new System.EventHandler(this.batPerList_SelectedIndexChanged);
            // 
            // checkIconCashslide
            // 
            this.checkIconCashslide.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIconCashslide.BackgroundImage = global::TestShot.Properties.Resources.noti_cashslide;
            this.checkIconCashslide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkIconCashslide.Checked = true;
            this.checkIconCashslide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIconCashslide.Enabled = false;
            this.checkIconCashslide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkIconCashslide.Location = new System.Drawing.Point(117, 20);
            this.checkIconCashslide.Name = "checkIconCashslide";
            this.checkIconCashslide.Size = new System.Drawing.Size(30, 30);
            this.checkIconCashslide.TabIndex = 22;
            this.checkIconCashslide.UseVisualStyleBackColor = true;
            // 
            // checkIconLte
            // 
            this.checkIconLte.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIconLte.BackgroundImage = global::TestShot.Properties.Resources.noti_lte;
            this.checkIconLte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkIconLte.Location = new System.Drawing.Point(45, 56);
            this.checkIconLte.Name = "checkIconLte";
            this.checkIconLte.Size = new System.Drawing.Size(30, 30);
            this.checkIconLte.TabIndex = 21;
            this.checkIconLte.UseVisualStyleBackColor = true;
            this.checkIconLte.CheckedChanged += new System.EventHandler(this.checkIconLte_CheckedChanged);
            // 
            // checkIconBatPer
            // 
            this.checkIconBatPer.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIconBatPer.BackgroundImage = global::TestShot.Properties.Resources.battery_per_72;
            this.checkIconBatPer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkIconBatPer.Location = new System.Drawing.Point(117, 56);
            this.checkIconBatPer.Name = "checkIconBatPer";
            this.checkIconBatPer.Size = new System.Drawing.Size(30, 30);
            this.checkIconBatPer.TabIndex = 20;
            this.checkIconBatPer.UseVisualStyleBackColor = true;
            this.checkIconBatPer.CheckedChanged += new System.EventHandler(this.checkIconBatPer_CheckedChanged);
            // 
            // checkIconAntenna
            // 
            this.checkIconAntenna.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIconAntenna.BackgroundImage = global::TestShot.Properties.Resources.noti_antenna;
            this.checkIconAntenna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkIconAntenna.Checked = true;
            this.checkIconAntenna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIconAntenna.Enabled = false;
            this.checkIconAntenna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkIconAntenna.Location = new System.Drawing.Point(81, 56);
            this.checkIconAntenna.Name = "checkIconAntenna";
            this.checkIconAntenna.Size = new System.Drawing.Size(30, 30);
            this.checkIconAntenna.TabIndex = 19;
            this.checkIconAntenna.UseVisualStyleBackColor = true;
            this.checkIconAntenna.CheckedChanged += new System.EventHandler(this.checkIconAntenna_CheckedChanged);
            // 
            // checkIconVib
            // 
            this.checkIconVib.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIconVib.BackgroundImage = global::TestShot.Properties.Resources.noti_vibrate;
            this.checkIconVib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkIconVib.Location = new System.Drawing.Point(9, 56);
            this.checkIconVib.Name = "checkIconVib";
            this.checkIconVib.Size = new System.Drawing.Size(30, 30);
            this.checkIconVib.TabIndex = 18;
            this.checkIconVib.UseVisualStyleBackColor = true;
            this.checkIconVib.CheckedChanged += new System.EventHandler(this.checkIconVib_CheckedChanged);
            // 
            // checkRandomIcon
            // 
            this.checkRandomIcon.AutoSize = true;
            this.checkRandomIcon.Location = new System.Drawing.Point(11, 212);
            this.checkRandomIcon.Name = "checkRandomIcon";
            this.checkRandomIcon.Size = new System.Drawing.Size(116, 16);
            this.checkRandomIcon.TabIndex = 17;
            this.checkRandomIcon.Text = "아이콘 랜덤 사용";
            this.checkRandomIcon.UseVisualStyleBackColor = true;
            // 
            // checkIconCapture
            // 
            this.checkIconCapture.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIconCapture.BackgroundImage = global::TestShot.Properties.Resources.noti_capture;
            this.checkIconCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkIconCapture.Location = new System.Drawing.Point(45, 20);
            this.checkIconCapture.Name = "checkIconCapture";
            this.checkIconCapture.Size = new System.Drawing.Size(30, 30);
            this.checkIconCapture.TabIndex = 14;
            this.checkIconCapture.UseVisualStyleBackColor = true;
            this.checkIconCapture.CheckedChanged += new System.EventHandler(this.checkIconCapture_CheckedChanged);
            // 
            // checkIconSms
            // 
            this.checkIconSms.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIconSms.BackgroundImage = global::TestShot.Properties.Resources.noti_sms;
            this.checkIconSms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkIconSms.Location = new System.Drawing.Point(9, 20);
            this.checkIconSms.Name = "checkIconSms";
            this.checkIconSms.Size = new System.Drawing.Size(30, 30);
            this.checkIconSms.TabIndex = 13;
            this.checkIconSms.UseVisualStyleBackColor = true;
            this.checkIconSms.CheckedChanged += new System.EventHandler(this.checkIconSms_CheckedChanged);
            // 
            // checkIconKakao
            // 
            this.checkIconKakao.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIconKakao.BackgroundImage = global::TestShot.Properties.Resources.noti_kakao;
            this.checkIconKakao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkIconKakao.Location = new System.Drawing.Point(81, 20);
            this.checkIconKakao.Name = "checkIconKakao";
            this.checkIconKakao.Size = new System.Drawing.Size(30, 30);
            this.checkIconKakao.TabIndex = 15;
            this.checkIconKakao.UseVisualStyleBackColor = true;
            this.checkIconKakao.CheckedChanged += new System.EventHandler(this.checkIconKakao_CheckedChanged);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(288, 497);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(1080, 1920);
            this.imagePictureBox.TabIndex = 1;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Tag = "imagePictureBox";
            this.imagePictureBox.Visible = false;
            // 
            // examplePictureBox
            // 
            this.examplePictureBox.Location = new System.Drawing.Point(12, 12);
            this.examplePictureBox.Name = "examplePictureBox";
            this.examplePictureBox.Size = new System.Drawing.Size(240, 427);
            this.examplePictureBox.TabIndex = 0;
            this.examplePictureBox.TabStop = false;
            this.examplePictureBox.Tag = "examplePictureBox";
            // 
            // layoutFormButton
            // 
            this.layoutFormButton.Location = new System.Drawing.Point(421, 12);
            this.layoutFormButton.Name = "layoutFormButton";
            this.layoutFormButton.Size = new System.Drawing.Size(25, 427);
            this.layoutFormButton.TabIndex = 18;
            this.layoutFormButton.Text = "레이아웃변경";
            this.layoutFormButton.UseVisualStyleBackColor = true;
            this.layoutFormButton.Click += new System.EventHandler(this.layoutFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 449);
            this.Controls.Add(this.layoutFormButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.openMultiFileButton);
            this.Controls.Add(this.saveMultiFileButton);
            this.Controls.Add(this.showArrowCheckBox);
            this.Controls.Add(this.adTypeList);
            this.Controls.Add(this.rightCostTextBox);
            this.Controls.Add(this.leftCostTextBox);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.examplePictureBox);
            this.Name = "Form1";
            this.Text = "TestShot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox examplePictureBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox leftCostTextBox;
        private System.Windows.Forms.TextBox rightCostTextBox;
        private System.Windows.Forms.ComboBox adTypeList;
        private System.Windows.Forms.CheckBox showArrowCheckBox;
        private System.Windows.Forms.Button saveMultiFileButton;
        private System.Windows.Forms.Button openMultiFileButton;
        private System.Windows.Forms.OpenFileDialog openMultiFileDialog;
        private System.Windows.Forms.FolderBrowserDialog saveMultiFileDialog;
        private System.Windows.Forms.CheckBox checkIconSms;
        private System.Windows.Forms.CheckBox checkIconCapture;
        private System.Windows.Forms.CheckBox checkIconKakao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkRandomIcon;
        private System.Windows.Forms.CheckBox checkIconBatPer;
        private System.Windows.Forms.CheckBox checkIconAntenna;
        private System.Windows.Forms.CheckBox checkIconVib;
        private System.Windows.Forms.CheckBox checkIconLte;
        private System.Windows.Forms.CheckBox checkIconCashslide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox batPerList;
        private System.Windows.Forms.CheckBox chargeCheck;
        private System.Windows.Forms.CheckBox checkBatFixed;
        private System.Windows.Forms.Button layoutFormButton;
    }
}

