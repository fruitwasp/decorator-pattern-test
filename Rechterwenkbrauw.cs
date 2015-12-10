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
    public class Rechterwenkbrauw : ClownDecorator
    {
        public Rechterwenkbrauw(Clown clownDecorator)
            : base(clownDecorator)
        {

        }

        public override void Draw(Canvas canvas)
        {
            base.Draw(canvas);

            Line line = new Line();
            line.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            line.X1 = 260;
            line.X2 = 310;
            line.Y1 = 100;
            line.Y2 = 100;
            line.HorizontalAlignment = HorizontalAlignment.Right;
            line.VerticalAlignment = VerticalAlignment.Center;
            line.StrokeThickness = 2;

            canvas.Children.Add(line);
        }
    }
}
