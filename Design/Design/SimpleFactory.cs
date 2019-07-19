using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
	public abstract class Operator
	{
		public virtual double GetResult()
		{
			double d = 0;
			return d;
		}

		private double numberA = 0;
		private double numberB = 0;

		public double NumberA
		{
			get { return numberA; }
			set { numberA = value; }
		}

		public double NumberB
		{
			get { return numberB; }
			set { numberB = value; }
		} 
	}

	public class OperationAdd : Operator
	{
		public override double GetResult()
		{
			return NumberA + NumberB;
		}
	}

	public class OperationSub : Operator
	{
		public override double GetResult()
		{
			return NumberA - NumberB;
		}
	}

	public class OperationFactory
	{
		public static Operator CreateOperate(string operate)
		{
			Operator oper = null;
			switch (operate)
			{
				case "+":
					oper = new OperationAdd();
					break;
				case "-":
					oper = new OperationSub();
					break;
			}

			return oper;
		}
	}

}
