using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestShot
{
    public partial class TestShotTextLayoutControl : UserControl
    {
        public TestShotTextLayoutControl()
        {
            InitializeComponent();
        }

        public void updateFontText()
        {
            selectedFontText.Text = FontName + ", " + FontSize;
        }

        private void fontChange_Click(object sender, EventArgs e)
        {
            //fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                FontName = fontDialog.Font.Name;
                FontSize = fontDialog.Font.Size;
                updateFontText();
                if (this.OnChange != null)
                    this.OnChange(sender, e);
            }
        }

        public string FontName { get; set; }
        public float FontSize { get; set; }
        public int X
        {
            get { return (int)coordX.Value; }
            set { coordX.Value = value; }
        }
        public int Y
        {
            get { return (int)coordY.Value; }
            set { coordY.Value = value; }
        }

        [Category("Appearance"), Description("텍스트"), Bindable(true)
            Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return this.groupBox1.Text; }
            set { this.groupBox1.Text = value; }
        }

        private void coordX_ValueChanged(object sender, EventArgs e)
        {
            if (this.OnChange != null)
                this.OnChange(sender, e);
        }

        private void coordY_ValueChanged(object sender, EventArgs e)
        {
            if (this.OnChange != null)
                this.OnChange(sender, e);
        }

        public EventHandler OnChange;
    }
}
