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
	public class ClownKaal : Clown
	{

		public virtual void Draw(Canvas canvas)
		{
            Ellipse ellipse = new Ellipse();

            ellipse.StrokeThickness = 1;
            ellipse.Stroke = Brushes.Black;

            ellipse.Width = 300;
            ellipse.Height = 300;

            ellipse.SetValue(Canvas.LeftProperty, 60.0);
            ellipse.SetValue(Canvas.TopProperty, 10.0);

            canvas.Children.Add(ellipse);
		}
	}
}
