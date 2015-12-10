using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace avans_Decorator
{
	public abstract class ClownDecorator : Clown
	{
        private Clown _clownDecorator;

		public ClownDecorator(Clown clownDecorator)
		{
            _clownDecorator = clownDecorator;
		}

		public virtual void Draw(Canvas canvas)
		{
            _clownDecorator.Draw(canvas);
		}
	}
}
