using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace avans_Decorator
{
	public class Rechteroog : ClownDecorator
	{
		public Rechteroog(Clown decorated) : base(decorated)
		{

		}

		public override void Draw(Canvas canvas)
		{
            base.Draw(canvas);

            SolidColorBrush solidColorBrush = new SolidColorBrush();
            solidColorBrush.Color = System.Windows.Media.Color.FromArgb(255, 255, 0, 0);

            Ellipse ellipse = new Ellipse();

            ellipse.Fill = solidColorBrush;
            ellipse.StrokeThickness = 1;
            ellipse.Stroke = System.Windows.Media.Brushes.Black;

            ellipse.Width = 20;
            ellipse.Height = 20;

            ellipse.SetValue(Canvas.RightProperty, 120.0);
            ellipse.SetValue(Canvas.TopProperty, 120.0);

            canvas.Children.Add(ellipse);
		}
	}
}
