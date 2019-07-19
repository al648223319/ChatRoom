
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
	public class  Product 
	{
		public List<string> l = new List<string>();

		public void Add(string part)
		{
			l.Add(part);
		}

		public void show()
		{
			foreach (var item in l)
			{

				Console.WriteLine(item);
			}
		}
	}

	public abstract class Builder
	{
		public abstract void BuildA();
		public abstract void BuildB();
		public abstract Product GetResult();
	}

	public class BuilderA : Builder
	{
		private Product p = new Product();
		public override void BuildA()
		{
			p.l.Add("a");
		}
		public override void BuildB()
		{
			p.l.Add("b");
		}
		public override Product GetResult()
		{
			return p;
		}
	}

	public class BuilderB : Builder
	{
		private Product p = new Product();
		public override void BuildA()
		{
			p.l.Add("1");
		}
		public override void BuildB()
		{
			p.l.Add("2");
		}
		public override Product GetResult()
		{
			return p;
		}
	}

	public class Director
	{
		public void Construct(Builder builder)
		{
			builder.BuildA();
			builder.BuildB();
		} 
	}
}
