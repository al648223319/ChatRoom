using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public abstract class Girl
	{
		public abstract void show();
	}


	public class Yeyao : Girl
	{

		public Yeyao()
		{
			Console.Write("创建叶瑶");
		}
		public override void show()
		{
			Console.Write("叶瑶正常装扮");
		}
	}

	public class Wear : Girl
	{
		public Girl m_g;
		public void Decorate( Girl g)
		{
			m_g = g;
		}
		public override void show()
		{
			m_g.show();
		}
	}

	public class Pretty : Wear
	{
		public override void show()
		{
			base.show();
			Console.Write("叶瑶变装 ");
		}
	}

	public class Cosplay : Wear
	{
		public override void show()
		{
			base.show();
			Console.Write("叶瑶Cosplay");
		}
	}


}
