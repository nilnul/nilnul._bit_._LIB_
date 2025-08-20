using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.combine
{
	/// <summary>
	/// just view its truth table.
	/// </summary>
	public class Eq : IEqualityComparer<nilnul.bit.CombineI>
	{
		public bool Equals(CombineI x, CombineI y)
		{
			if (x.GetType()==y.GetType())
			{
				return true;
			}
			return false;
			throw new NotImplementedException();
		}

		public int GetHashCode(CombineI obj)
		{
			return obj.GetType().GetHashCode();
			throw new NotImplementedException();
		}


		static public readonly Eq Singleton = nilnul.obj.SingletonByDefault<Eq>.Instance;

	}
}
