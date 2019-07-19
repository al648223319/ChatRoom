using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	interface Speak
	{
		void talk();
	}

	public class Englise
	{
		public void talk()
		{
			Console.WriteLine("This is Englise");
		}
	}

	public class lilei : Speak
	{
		private Englise e;
		public lilei()
		{
			e = new Englise();
		}

		public void talk()
		{
			Console.WriteLine("我在翻译");
			e.talk();
		}
	}
}
