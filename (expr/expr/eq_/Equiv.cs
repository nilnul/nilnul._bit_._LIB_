using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.eq_
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[Obsolete()]
	public class Equiv : IEqualityComparer<nilnul.bit.ExprI1>
	{
		/// <summary>
		/// x is equivalent to y iif x ~ y is tautology
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public bool Equals(ExprI1 x, ExprI1 y)
		{

			throw new NotImplementedException();
		}

		public int GetHashCode(ExprI1 obj)
		{
			throw new NotImplementedException();
		}


		static public Equiv Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Equiv>.Instance;
			}
		}

	}
}
