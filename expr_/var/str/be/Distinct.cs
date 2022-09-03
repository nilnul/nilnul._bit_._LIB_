using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.sortedSet.be
{
	public class Distinct:nilnul.BeI<nilnul.bit.var.StrI>
	{
		static public bool _Eval(IEnumerable<VarI1> str, VarI1 var) {

#if DEBUG
			var eqSingleton = nilnul.bit.var.Eq.Instance;
			return str.All(x=> !eqSingleton.Equals(x, var));


#else
			return str.All(x=> !nilnul.bit.var.Eq.Instance.Equals(x, var));


#endif
		}

		static public bool _Eval1(IEnumerable<VarI1> str, VarI1 var) {
			return !str.Contains(var);
		}

		static public bool Eval(StrI str) {
			return str.Count() == 0 ? true : _Eval(str.Skip(1),str.First());
		}

		public bool be(StrI d)
		{
			return Eval(d);
			throw new NotImplementedException();
		}

		public class Asserted
			:nilnul.Asserted<StrI,Distinct>


		{
			public Asserted(StrI str):base(str)
			{

			}

			public Asserted(IEnumerable<VarI1> str):this( new bit.var.sortedSet.EnumerableAsStr(str))
			{

			}

			public int length {
				get { return val.Count(); } }


		}
	}
}
