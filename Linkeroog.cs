using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace avans_Decorator
{
	class Linkeroog : ClownDecorator
	{
        public Linkeroog(Clown clownDecorator)
            : base(clownDecorator)
		{

		}

		public override void Draw(Canvas canvas)
		{
			base.Draw(canvas);

			SolidColorBrush solidColorBrush = new SolidColorBrush();
			solidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);

            Ellipse ellipse = new Ellipse();

			ellipse.Fill = solidColorBrush;
			ellipse.StrokeThickness = 1;
			ellipse.Stroke = Brushes.Black;

			ellipse.Width = 20;
			ellipse.Height = 20;

			ellipse.SetValue(Canvas.LeftProperty, 120.0);
			ellipse.SetValue(Canvas.TopProperty, 120.0);

			canvas.Children.Add(ellipse);
		}
	}
}
