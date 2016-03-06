namespace TestShot
{
    partial class TestShotTextLayoutControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fontChange = new System.Windows.Forms.Button();
            this.selectedFontText = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.coordY = new System.Windows.Forms.NumericUpDown();
            this.coordX = new System.Windows.Forms.NumericUpDown();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coordY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TextLayoutControl";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fontChange);
            this.groupBox2.Controls.Add(this.selectedFontText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 86);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "폰트";
            // 
            // fontChange
            // 
            this.fontChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fontChange.Location = new System.Drawing.Point(3, 60);
            this.fontChange.Name = "fontChange";
            this.fontChange.Size = new System.Drawing.Size(170, 23);
            this.fontChange.TabIndex = 1;
            this.fontChange.Text = "폰트 선택";
            this.fontChange.UseVisualStyleBackColor = true;
            this.fontChange.Click += new System.EventHandler(this.fontChange_Click);
            // 
            // selectedFontText
            // 
            this.selectedFontText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedFontText.AutoSize = true;
            this.selectedFontText.Location = new System.Drawing.Point(13, 21);
            this.selectedFontText.MaximumSize = new System.Drawing.Size(150, 0);
            this.selectedFontText.Name = "selectedFontText";
            this.selectedFontText.Size = new System.Drawing.Size(148, 12);
            this.selectedFontText.TabIndex = 0;
            this.selectedFontText.Text = "Selected font, 10px, color";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.coordY);
            this.groupBox3.Controls.Add(this.coordX);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 48);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "좌표";
            // 
            // coordY
            // 
            this.coordY.Location = new System.Drawing.Point(91, 20);
            this.coordY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.coordY.Name = "coordY";
            this.coordY.Size = new System.Drawing.Size(61, 21);
            this.coordY.TabIndex = 12;
            this.coordY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.coordY.ValueChanged += new System.EventHandler(this.coordY_ValueChanged);
            // 
            // coordX
            // 
            this.coordX.Location = new System.Drawing.Point(24, 20);
            this.coordX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.coordX.Name = "coordX";
            this.coordX.Size = new System.Drawing.Size(61, 21);
            this.coordX.TabIndex = 11;
            this.coordX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.coordX.ValueChanged += new System.EventHandler(this.coordX_ValueChanged);
            // 
            // TestShotTextLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TestShotTextLayoutControl";
            this.Size = new System.Drawing.Size(182, 160);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coordY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button fontChange;
        private System.Windows.Forms.Label selectedFontText;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown coordY;
        private System.Windows.Forms.NumericUpDown coordX;
    }
}
