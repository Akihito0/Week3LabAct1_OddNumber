using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

[Designer(typeof(ControlDesigner))]
public class StarButton : Control
{
    private bool isSelected = false;
    private int starIndex;
    private StarButton[] starButtons;

    // Default constructor for the designer
    public StarButton()
    {
        this.Size = new Size(50, 50);
        this.Paint += StarButton_Paint;
        this.Click += StarButton_Click;
    }

    // Constructor with parameters
    public StarButton(int index, StarButton[] stars) : this()
    {
        starIndex = index;
        starButtons = stars;
    }

    private void StarButton_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        PointF[] starPoints = GetStarPoints(new PointF(Width / 2, Height / 2), Width / 2 - 2, Width / 4 - 2);
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddPolygon(starPoints);
            using (Brush brush = new SolidBrush(isSelected ? Color.Gold : Color.Gray))
            {
                e.Graphics.FillPath(brush, path);
            }
            using (Pen pen = new Pen(Color.Black))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    private void StarButton_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < starButtons.Length; i++)
        {
            starButtons[i].isSelected = i <= starIndex;
            starButtons[i].Invalidate();
        }
    }

    private PointF[] GetStarPoints(PointF center, float outerRadius, float innerRadius)
    {
        PointF[] points = new PointF[10];
        double angle = -Math.PI / 2;
        double step = Math.PI / 5;

        for (int i = 0; i < 10; i++)
        {
            float radius = i % 2 == 0 ? outerRadius : innerRadius;
            points[i] = new PointF(
                center.X + (float)(radius * Math.Cos(angle)),
                center.Y + (float)(radius * Math.Sin(angle))
            );
            angle += step;
        }

        return points;
    }
}