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
	public class Equiv1 : IEqualityComparer<nilnul.bit.ExprI2>
	{
		/// <summary>
		/// x is equivalent to y iif x ~ y is tautology
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public bool Equals(ExprI2 x, ExprI2 y)
		{

			throw new NotImplementedException();
		}

		public int GetHashCode(ExprI2 obj)
		{
			throw new NotImplementedException();
		}


		static public Equiv1 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Equiv1>.Instance;
			}
		}

	}
}
