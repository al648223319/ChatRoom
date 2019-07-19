using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	 public abstract class  TieBa
	{
		 private List<user> list = new List<user>();

		public void register(user s)
		{
			list.Add(s);
		}

		public void remove(user s)
		{
			list.Remove(s);
		}

		public void Notify()
		{
			foreach (var s in list)
			{
				s.Update();
			}
		}

	}

	public class Administrator:TieBa
	{
		private string subjectState;

		public string SubjectState
		{
			get { return subjectState; }
			set { subjectState = value; }
		}
	}


	public abstract class user
	{
		public abstract void Update();
	}

	public class shuiyou : user
	{
		private string name;
		private string observerState;
		private Administrator subject;

		public shuiyou(Administrator subject, string name)
		{
            this.subject = subject;
            this.name = name;
        }
        
        public override void Update() {
            observerState = subject.SubjectState;
            Console.WriteLine("观察者{0}的新状态是{1}", name, observerState);
        }

		//public Administrator Subject
		//{
		//	get { return subject; }
		//	set { subject = value; }
		//}
	}
}
