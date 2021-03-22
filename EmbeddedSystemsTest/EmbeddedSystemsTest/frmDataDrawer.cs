using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbeddedSystemsTest
{
    public partial class frmDataDrawer : Form
    {
        List<Point> points;
        bool drawing;

        public frmDataDrawer()
        {
            InitializeComponent();
            points = new List<Point>();
        }

        private void panDrawData_Paint(object sender, PaintEventArgs e)
        {
            PaintGrid();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearCanvas();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Extract y data from the points. I'm sure there's a better way to do
            // this but I'm tired right now :(
            int[] yData = new int[points.Count];

            for(int i = 0; i < points.Count; i++)
            {
                // There is a 286-pixel offset between numeric data and the mouse's y axis
                yData[i] = points[i].Y + 286;
            }

            string csvToSave = string.Join(",", yData);

            if (csvToSave != null)
            {
                File.WriteAllText(txtFilename.Text + ".csv", csvToSave);
            }
        }

        private void panDrawData_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            DrawPoint(e.X, e.Y, false);
        }

        private void panDrawData_MouseMove(object sender, MouseEventArgs e)
        {
            // sets drawing to false if the cursor is out of bounds
            if (e.X < 0 || e.Y < 0 || e.X > panDrawData.Width || e.Y > panDrawData.Height)
            {
                drawing = false;
            }
            // otherwise, shows where the cursor is currently
            else
            {
                lblCurrValue.Text = "Current Value: " + (e.Y - 460) * -1;
            }

            if (radDrawPoints.Checked)
            {
                // if the mouse is down on the canvas, then...
                if (drawing == true)
                {
                    // draws the point at the cursor's location
                    DrawPoint(e.X, e.Y, true);
                }
            }
        }

        private void panDrawData_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        // DRAW POINT
        // takes in two parameters: X and Y locations of the cursor
        // draws the point at the cursor's location, then adds that to a list
        public void DrawPoint(int x, int y, bool drag)
        {
            // adds the X and Y values to a list of points (with an offset)

            points.Add(new Point((x - 243), (349 - y - 175)));

            lblDataPoints.Text = "Data points: " + points.Count;

            // draws a single dot only if you are not dragging
            Graphics g = panDrawData.CreateGraphics();
            Pen p = new Pen(new SolidBrush(Color.LawnGreen), 2);
            Rectangle r = new Rectangle(x, y, 1, 1);

            // actually draws the dot
            g.DrawEllipse(p, r);

            // be gone!
            g.Dispose();
            p.Dispose();

            //draws a line between the points if necessary
            if (points.Count > 1)
            {
                DrawLine(points[points.Count - 2], points[points.Count - 1], drag, true);
            }

        }

        // DRAW LINE
        // draws a line between two points so you don't just see a bunch of dots on the preview
        public void DrawLine(Point a, Point b, bool drag, bool custom)
        {

            //only draws lines between points if the mouse is being held down and didn't just click
            if (drag == true)
            {
                // draws a series of dots that you're drawing on the oscilloscope
                Graphics g = panDrawData.CreateGraphics();
                Pen p = new Pen(new SolidBrush(Color.LawnGreen), 2);

                //only positions the line if the user is drawing
                if (custom == true)
                {
                    // positioning offset
                    Point newPointA = new Point(a.X + 244, -1 * (a.Y - 175));
                    Point newPointB = new Point(b.X + 244, -1 * (b.Y - 175));

                    // actually draws the dots
                    g.DrawLine(p, newPointA, newPointB);
                }
                else g.DrawLine(p, a, b);

                // be gone!
                g.Dispose();
                p.Dispose();
            }
        }

        // CLEAR CANVAS
        // clears the preview, and resets all the label objects
        public void ClearCanvas()
        {
            points.Clear();
            lblDataPoints.Text = "Data points: 0";
            panDrawData.Refresh();
            PaintGrid();
        }

        public void PaintGrid()
        {
            Pen grayPen = new Pen(Color.LightGray, 1);
            Pen thickerGrayPen = new Pen(Color.LightGray, 3);

            Graphics g = panDrawData.CreateGraphics();

            // Draw rows
            for (int i = 0; i <= panDrawData.Height; i += 20)
            {
                if (i != 460) g.DrawLine(grayPen, 0, i, panDrawData.Width, i);
                else g.DrawLine(thickerGrayPen, 0, i, panDrawData.Width, i);

            }

            // Draw columns
            for (int i = 0; i <= panDrawData.Width; i += 20)
            {
                g.DrawLine(grayPen, i, 0, i, panDrawData.Height);
            }

            g.Dispose();
        }
    }
}
