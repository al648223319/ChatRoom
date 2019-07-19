using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	interface Work
	{
		void buy();
	}

	class Boos : Work
	{
		public void buy()
		{
			Console.WriteLine("老板说谢谢");
		}
	}

	class zhongqiu : Work
	{
		Boos m_b;
		public zhongqiu()
		{
			m_b = new Boos();
		}

		public void buy()
		{
			Console.WriteLine("老板叫我买咖啡");
			m_b.buy();
		}
	}
}
