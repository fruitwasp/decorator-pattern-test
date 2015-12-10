using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace avans_Decorator
{
	public class Factory
	{
		public static Clown GetClown(bool[] baChoice)
		{
			Clown clownDecorator = new ClownKaal();

            for (int index = 0; index < baChoice.Length; index++)
			{
                if (!baChoice[index]) continue;

                switch (index)
                {
                    case 0: clownDecorator = new Linkeroog(clownDecorator); break;
                    case 1: clownDecorator = new Rechteroog(clownDecorator); break;
                    case 2: clownDecorator = new Linkerwenkbrauw(clownDecorator); break;
                    case 3: clownDecorator = new Rechterwenkbrauw(clownDecorator); break;
                }
			}

			return clownDecorator;
		}
	}
}
