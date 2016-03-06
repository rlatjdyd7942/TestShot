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
    public partial class TestShotImageLayoutControl : UserControl
    {
        public TestShotImageLayoutControl()
        {
            InitializeComponent();
        }

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
        public int SizeWidth
        {
            get { return (int)width.Value; }
            set { width.Value = value; }
        }
        public int SizeHeight
        {
            get { return (int)height.Value; }
            set { height.Value = value; }
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

        private void width_ValueChanged(object sender, EventArgs e)
        {
            if (this.OnChange != null)
                this.OnChange(sender, e);
        }

        private void height_ValueChanged(object sender, EventArgs e)
        {
            if (this.OnChange != null)
                this.OnChange(sender, e);
        }

        public EventHandler OnChange;
    }
}
