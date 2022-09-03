using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr.op
{
	/// <summary>
	/// 
	/// </summary>
	public class Substitute
	{

		static public Substitute Singleton = SingletonByDefault<Substitute>.Instance;
		public E eval(E e, nilnul.bit.expr.set.Substitution map) {

			E r = null;
			foreach (var item in map)
			{
				r = r.substitute(item.Key,item.Value);
				
			}
			return r;

		}
		public E eval_byEnumerate(E e, nilnul.bit.expr.set.Substitution map) {

			E r = null;
			foreach (var item in map.enumerate())
			{
				
				r = eval(e,item);
			}
			return r;

		}

		

		public E eval(E e, nilnul.bit.expr.Substitution map)
		{
			return e.substitute(map.var, map.expr);

		}


	}
}
