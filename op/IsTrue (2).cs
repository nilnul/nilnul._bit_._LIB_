using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.element;

namespace nilnul.logic
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IsAlwaysTrue
	{

		static private readonly IsAlwaysTrue _Instance = new IsAlwaysTrue();
		static public IsAlwaysTrue Instance
		{
			get
			{
				return _Instance;
			}
		}
		private IsAlwaysTrue()
		{
		}

		public bool eval(ExprI<bool> a) {

			ExprI<bool> a2=a.eval();

			if (a2 is ConstI<bool>)
			{
				return (((ConstI<bool>)a).eval());
			}
			else
			{
				return false;
			}
		
		}

		
				
	}
	static public class MyClass
	{
		static public bool IsAlwaysTrue(this ExprI<bool> a)
		{
			return logic.IsAlwaysTrue.Instance.eval(a);

		}

	}
}
