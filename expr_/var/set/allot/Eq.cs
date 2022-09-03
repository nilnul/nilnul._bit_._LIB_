using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.bit.var.set.assignment
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[Obsolete()]
	public class Eq : IEqualityComparer<Assignment>
	{
		public bool Equals(Assignment x, Assignment y)
		{
			

		return 	nilnul.obj.set.eq_._EqOfEnumerable.Eq(
				x.enumerate()
				,y.enumerate()
				,
				var.assignment.Eq.Lazy
				
			);
			
			//throw new NotImplementedException();
		}

		public int GetHashCode(Assignment obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


		static private Lazy<Eq> _Lazy = new Lazy<Eq>();
		static public Eq Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
