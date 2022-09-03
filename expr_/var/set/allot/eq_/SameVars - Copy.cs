using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.state.eq_
{
	/// <summary>
	/// 
	/// </summary>
	public class SameVars : IEqualityComparer<State>
	{
		public bool Equals(State x, State y)
		{


			return nilnul.bit.var.set.EqOfEnumerable.Instance.Equals(x.Keys.AsEnumerable(), y.Keys.AsEnumerable());

			//throw new NotImplementedException();
		}

		public int GetHashCode(State obj)
		{
			return nilnul.bit.var.set.EqOfEnumerable.Instance.GetHashCode(obj.Keys);
			//throw new NotImplementedException();
		}


		static private Lazy<SameVars> _Lazy = new Lazy<SameVars>();
		static public SameVars Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
