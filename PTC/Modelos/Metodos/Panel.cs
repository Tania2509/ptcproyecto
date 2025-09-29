using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Metodos
{
    public class PanelRedondeado : Panel
    {
        public int RadioEsquinas { get; set; } = 20;
        public Color ColorBorde { get; set; } = Color.Gray;
        public int AnchoBorde { get; set; } = 1;

        public PanelRedondeado()
        {
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(ColorBorde, AnchoBorde))
            {
                Rectangle rect = new Rectangle(0, 0, Width, Height);

                path.AddArc(rect.X, rect.Y, RadioEsquinas, RadioEsquinas, 180, 90);
                path.AddArc(rect.Width - RadioEsquinas, rect.Y, RadioEsquinas, RadioEsquinas, 270, 90);
                path.AddArc(rect.Width - RadioEsquinas, rect.Height - RadioEsquinas, RadioEsquinas, RadioEsquinas, 0, 90);
                path.AddArc(rect.X, rect.Height - RadioEsquinas, RadioEsquinas, RadioEsquinas, 90, 90);
                path.CloseAllFigures();

                this.Region = new Region(path);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
    }
}