using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public abstract class CheckWay
	{
		public abstract double GetResult(double price);
	}

	public class NormalWay : CheckWay
	{
		public override double GetResult(double price)
		{
			return price;
		}
	}

	public class RebateWay : CheckWay
	{
		public double m_discount;
		public RebateWay(double discount)
		{
			m_discount = discount;
		}

		public override double GetResult(double price)
		{
			return price * m_discount;
		}
	}

	public class Checkstand
	{
		CheckWay m_cw;
		public Checkstand(CheckWay cw)
		{
			m_cw = cw;
		}
		public  double GetResult(double price)
		{
			return m_cw.GetResult(price);
		}
	}



}
