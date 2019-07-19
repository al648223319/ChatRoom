using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory;
using Strategy;
using Decorator;
using Proxy;
using Build;
using Facade;
using Observer;
using Adapter;
class Program
{
	static void Main(string[] args)
	{
		#region 简单工厂
		//Operator opAdd = OperationFactory.CreateOperate("+");
		//opAdd.NumberA = 1;
		//opAdd.NumberB = 2;
		//Console.WriteLine(opAdd.GetResult());

		//Operator opSub = OperationFactory.CreateOperate("-");
		//opSub.NumberA = 1;
		//opSub.NumberB = 2;
		//Console.WriteLine(opSub.GetResult());
		#endregion

		#region 策略模式 将算法包装好 调用的时候可互换 可再次包装一个简单工厂
		//RebateWay rw = new RebateWay(0.8);
		//Checkstand ch = new Checkstand(rw);
		//double price =  ch.GetResult(10);
		//Console.Write(price);
		#endregion

		#region 装饰者模式  在不改动旧功能接口下 新增新的接口
		//Girl g = new Yeyao();
		//Pretty p = new Pretty();
		//Cosplay c = new Cosplay();
		//p.Decorate(g);
		//c.Decorate(p);
		//c.show();
		#endregion

		#region 代理
		//zhongqiu z = new zhongqiu();
		//z.buy();
		#endregion

		#region 建造模式
		////创建具体建造者（抽象其建造者）
		//Builder b1 = new BuilderA();
		//Builder b2 = new BuilderB();

		////指挥 （构建者）
		//Director d = new Director();
		//d.Construct(b1);

		////组装其产品 展示
		//Product p = b1.GetResult();
		//p.show();

		//d.Construct(b2);
		//Product p1 = b2.GetResult();
		//p1.show();
		#endregion  

		#region 外观模式 创建一个提供外部调用的类 类的方法中含有其它类的方法  在开发阶段子系统不断更改，复杂化，使用外观模式提供外部一个简单的接口
		//为子系统中的一组接口提供一个一致的界面,此模式定义了一个高层接口,这个接口使得这一子系统更加容易使用

		//FacadeClass f = new FacadeClass();
		//f.MethodA();
		//f.MethodB();

		#endregion


		#region 观察者模式  定义了一种一对多的依赖关系,让多个观察者对象同时监听某一个主题对象.这个主题对象在状态发生变化时,会通知所有观察者对象,使它们能够自动更新自己
		
		//Administrator d = new Administrator();
		//d.register(new shuiyou(d, "zhangsan"));
		//d.register(new shuiyou(d, "lisi"));
		//d.SubjectState = "123";
		//d.Notify();

		//d.SubjectState = "ABC";
		//d.Notify();

		#endregion


		#region  适配模式 将一个类的接口转换成客户希望的另外一个接口.Adapter模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作
		
		//lilei l = new lilei();
		//l.talk();

		#endregion



		Console.Read();
	}
}

