using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphing
{
    public partial class Graphing : Form
    {
        private static int defW = 600;
        private static int defH = 400;
        public Graphing()
        {
            InitializeComponent();
        }

        private void Graphing_Load(object sender, EventArgs e)
        {
            this.Width = defW;
            this.Height = defH;
        }

        private void Graphing_ResizeEnd(Object sender, EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            // Point size
            int rectW = relPoint(10, 0).X;
            int rectH = relPoint(0, 10).Y;

            // Create pens and brushes
            Pen blackPen = new Pen(Color.Black, relPoint(3, 0).X);
            Pen redPen = new Pen(Color.Red, relPoint(3,0).X);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            // Initialize points
            /*
             * Using an array makes adding new points and drawing them a lot easier
             */
            //Point pointOfOrigin = new Point(20, this.ClientSize.Height - 20);
            Point pointOfOrigin = relPoint(20, defH - 20);
            Point yAxisEnd = relPoint(20, 20);
            Point xAxisEnd = relPoint(defW - 20,  defH - 20);
            Point[] points = {
                relPoint(20 - rectW / 2, 20 - rectH / 2),
                relPoint(100, 300),
                relPoint(200, 200),
                relPoint(275, 300),
                relPoint(400, 150),
                relPoint(550, 200),
            };
            
            // Draw axis lines
            graphics.DrawLine(blackPen, pointOfOrigin, yAxisEnd);
            graphics.DrawLine(blackPen, pointOfOrigin, xAxisEnd);

            // Create rectangles for the points (ellipses)
            Rectangle[] rects = new Rectangle[points.Length];
            for (int i = 0; i < rects.Length; i++)
            {
                rects[i] = new Rectangle(points[i].X, points[i].Y, rectW, rectH);
            }

            // Draw points
            foreach (Rectangle rect in rects)
            {
                graphics.FillEllipse(redBrush, rect);
            }

            // Draw the line
            for (int i = 0; i < points.Length - 1; i++)
            {
                graphics.DrawLine(redPen, points[i].X + rectW / 2, points[i].Y + rectH / 2, points[i + 1].X + rectW / 2, points[i + 1].Y + rectH / 2);
            }
        }

        private Point relPoint(int x, int y)
        {
            Point relPoint = new Point();
            relPoint.X = (int) (((float) this.ClientSize.Width / (float) defW) * (float) x);
            relPoint.Y = (int) (((float) this.ClientSize.Height / (float) defH) * (float) y);
            return relPoint;
        }
    }
}
