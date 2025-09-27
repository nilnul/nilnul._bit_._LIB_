using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set
{
	

	public class EqOfEnumerable:
		nilnul.obj.var.set.EqOfEnumerable<bool>,

		IEqualityComparer<IEnumerable< nilnul.bit.VarI1>>

	{
		static public readonly EqOfEnumerable Instance = new EqOfEnumerable();

		public bool Equals(IEnumerable<VarI1> x, IEnumerable<VarI1> y)
		{
			return base.Equals(x, y);
			//throw new NotImplementedException();
		}

		

		public int GetHashCode(IEnumerable<VarI1> obj)
		{
			return base.GetHashCode(obj);
			//throw new NotImplementedException();
		}

		
	}
}
