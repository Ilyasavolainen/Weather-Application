using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Weather_Application
{
    public class RoundedDataGridView : DataGridView
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 20; // Set the corner radius here
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            path = RoundedRectangle(rect, cornerRadius);
            this.Region = new Region(path);
        }

        private GraphicsPath RoundedRectangle(Rectangle r, int radius)
        {
            float x = r.X, y = r.Y, w = r.Width, h = r.Height;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(x, y, 2 * radius, 2 * radius, 180, 90);
            path.AddLine(x + radius, y, x + w - radius, y);
            path.AddArc(x + w - 2 * radius, y, 2 * radius, 2 * radius, 270, 90);
            path.AddLine(x + w, y + radius, x + w, y + h - radius);
            path.AddArc(x + w - 2 * radius, y + h - 2 * radius, 2 * radius, 2 * radius, 0, 90);
            path.AddLine(x + w - radius, y + h, x + radius, y + h);
            path.AddArc(x, y + h - 2 * radius, 2 * radius, 2 * radius, 90, 90);
            path.AddLine(x, y + h - radius, x, y + radius);
            path.CloseFigure();
            return path;
        }
    }

    /*internal class RoundedDataGridView
    {
    } */
}
