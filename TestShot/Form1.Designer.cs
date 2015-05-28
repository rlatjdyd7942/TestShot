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
            this.examplePictureBox = new System.Windows.Forms.PictureBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LgRadioButton = new System.Windows.Forms.RadioButton();
            this.KtRadioButton = new System.Windows.Forms.RadioButton();
            this.SktRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LgRadioButton);
            this.groupBox1.Controls.Add(this.KtRadioButton);
            this.groupBox1.Controls.Add(this.SktRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(259, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "통신사";
            // 
            // LgRadioButton
            // 
            this.LgRadioButton.AutoSize = true;
            this.LgRadioButton.Location = new System.Drawing.Point(30, 73);
            this.LgRadioButton.Name = "LgRadioButton";
            this.LgRadioButton.Size = new System.Drawing.Size(39, 16);
            this.LgRadioButton.TabIndex = 2;
            this.LgRadioButton.Tag = "LgRadioButton";
            this.LgRadioButton.Text = "LG";
            this.LgRadioButton.UseVisualStyleBackColor = true;
            this.LgRadioButton.CheckedChanged += new System.EventHandler(this.LgRadioButton_CheckedChanged);
            // 
            // KtRadioButton
            // 
            this.KtRadioButton.AutoSize = true;
            this.KtRadioButton.Location = new System.Drawing.Point(30, 51);
            this.KtRadioButton.Name = "KtRadioButton";
            this.KtRadioButton.Size = new System.Drawing.Size(39, 16);
            this.KtRadioButton.TabIndex = 1;
            this.KtRadioButton.Tag = "KtRadioButton";
            this.KtRadioButton.Text = "KT";
            this.KtRadioButton.UseVisualStyleBackColor = true;
            this.KtRadioButton.CheckedChanged += new System.EventHandler(this.KtRadioButton_CheckedChanged);
            // 
            // SktRadioButton
            // 
            this.SktRadioButton.AutoSize = true;
            this.SktRadioButton.Checked = true;
            this.SktRadioButton.Location = new System.Drawing.Point(30, 29);
            this.SktRadioButton.Name = "SktRadioButton";
            this.SktRadioButton.Size = new System.Drawing.Size(47, 16);
            this.SktRadioButton.TabIndex = 0;
            this.SktRadioButton.TabStop = true;
            this.SktRadioButton.Tag = "SktRadioButton";
            this.SktRadioButton.Text = "SKT";
            this.SktRadioButton.UseVisualStyleBackColor = true;
            this.SktRadioButton.CheckedChanged += new System.EventHandler(this.SktRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 449);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LgRadioButton;
        private System.Windows.Forms.RadioButton KtRadioButton;
        private System.Windows.Forms.RadioButton SktRadioButton;
    }
}

