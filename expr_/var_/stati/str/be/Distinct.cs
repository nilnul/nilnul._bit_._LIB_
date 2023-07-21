using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.stati.str.be
{
	public class Distinct:nilnul.obj.BeI<StrI>
	{
		static public bool _Eval(IEnumerable<Stati> str, Stati var) {

#if DEBUG
			var eqSingleton = stati.Eq.Instance;
			return str.All(x=> !eqSingleton.Equals(x, var));


#else

			return str.All(x=>stati.Eq.Instance.Ne(x, var));

#endif
		}

		static public bool _Eval1(IEnumerable<Stati> str, Stati var) {
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
			:nilnul.obj.Asserted1<StrI,Distinct>

		{
			public Asserted(StrI str):base(str)
			{

			}

			public Asserted(IEnumerable<Stati> str):this( new bit.var.stati.str.EnumerableAsStr(str))
			{

			}

			public int length {
				get { return val.Count(); } }


		}
	}
}
