using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace avans_Decorator
{
    public class Linkerwenkbrauw : ClownDecorator
    {
        public Linkerwenkbrauw(Clown clownDecorator)
            : base(clownDecorator)
        {

        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);

            Line line = new Line();
            line.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            line.X1 = 100;
            line.X2 = 150;
            line.Y1 = 100;
            line.Y2 = 100;
            line.HorizontalAlignment = HorizontalAlignment.Left;
            line.VerticalAlignment = VerticalAlignment.Center;
            line.StrokeThickness = 2;

            c.Children.Add(line);
        }
    }
}
