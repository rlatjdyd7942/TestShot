namespace TestShot
{
    partial class TestShotImageLayoutControl
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.coordY = new System.Windows.Forms.NumericUpDown();
            this.coordX = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coordY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 160);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ImageLayoutControl";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.height);
            this.groupBox3.Controls.Add(this.width);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 61);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "사이즈";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(91, 20);
            this.height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(61, 21);
            this.height.TabIndex = 12;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.height.ValueChanged += new System.EventHandler(this.height_ValueChanged);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(24, 20);
            this.width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(61, 21);
            this.width.TabIndex = 11;
            this.width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.coordY);
            this.groupBox2.Controls.Add(this.coordX);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "좌표";
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
            this.coordY.TabIndex = 10;
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
            this.coordX.TabIndex = 9;
            this.coordX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.coordX.ValueChanged += new System.EventHandler(this.coordX_ValueChanged);
            // 
            // TestShotImageLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TestShotImageLayoutControl";
            this.Size = new System.Drawing.Size(182, 160);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coordY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown coordY;
        private System.Windows.Forms.NumericUpDown coordX;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.NumericUpDown width;
    }
}
