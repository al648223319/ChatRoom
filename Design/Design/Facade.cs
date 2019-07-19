using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	class PartA
	{
		public void MethodOne()
		{
			Console.WriteLine("组件1");
		}
	}

	class PartB
	{
		public void MethodTwo()
		{
			Console.WriteLine("组件2");
		}
	}

	public class FacadeClass
	{ 
		private PartA a;
		private PartB b;
		public FacadeClass()
		{
			a = new PartA();
			b = new PartB();
		}

		public void MethodA()
		{
			a.MethodOne();
		}

		public void MethodB()
		{
			a.MethodOne();
			b.MethodTwo();
		}
	
	}
}

