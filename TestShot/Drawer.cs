using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestShot
{
    class Drawer
    {
        public static void drawImage(Graphics graphics, Image image, int x, int y)
        {
            int cX, cY;
            Rectangle dest;
            cX = (x);
            cY = (y);
            dest = new Rectangle(cX, cY, (image.Width), (image.Height));
            graphics.DrawImage(image, dest);
        }
        public static void drawImage(Graphics graphics, Image image, int x, int y, int width, int height)
        {
            int cX, cY;
            Rectangle dest;
            cX = (x);
            cY = (y);
            dest = new Rectangle(cX, cY, (width), (height));
            graphics.DrawImage(image, dest);
        }
        public static void drawImageCenter(Graphics graphics, Image image, int x, int y)
        {
            Rectangle dest;
            dest = new Rectangle((x - image.Width / 2), (y - image.Height / 2), (image.Width), (image.Height));
            graphics.DrawImage(image, dest);
        }
        public static void drawImageCenter(Graphics graphics, Image image, int x, int y, int width, int height)
        {
            Rectangle dest;
            dest = new Rectangle((x - width / 2), (y - height / 2), (width), (height));
            graphics.DrawImage(image, dest);
        }
        public static void drawString(Graphics graphics, String str, Font font, int x, int y)
        {
            StringFormat format = StringFormat.GenericTypographic;
            SizeF size = graphics.MeasureString(str, font);
            graphics.DrawString(str, font, Brushes.White, new Point(x, y), format);
        }
        public static void drawStringCenter(Graphics graphics, String str, Font font, int x, int y)
        {
            StringFormat format = new StringFormat(StringFormat.GenericTypographic);
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            SizeF size = graphics.MeasureString(str, font);
            int margin = 2 * ((int)size.Height - font.Height);
            graphics.DrawString(str, font, Brushes.White, new Point(x, y), format);
            //TextRenderer.DrawText(graphics, str, font, new Point(x, y), Color.FromArgb(0xFFFFFF), TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
        }
        public static void drawString(Graphics graphics, String str, Font font, int color, int x, int y)
        {
            StringFormat format = StringFormat.GenericTypographic;
            SolidBrush brush = new SolidBrush(Color.FromArgb(color));
            SizeF size = graphics.MeasureString(str, font);
            int margin = 2 * ((int)size.Height - font.Height);
            graphics.DrawString(str, font, brush, new Point(x, y), format);
            //TextRenderer.DrawText(graphics, str, font, new Point(x, y), Color.FromArgb(color), TextFormatFlags.NoPadding);
        }
    }
}
