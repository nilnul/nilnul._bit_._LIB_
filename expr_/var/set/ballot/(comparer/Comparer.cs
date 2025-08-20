using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.bit.var.set.assignment
{
	/// <summary>
	/// for the purpose of ordering interpretations of a truth table before output it (for example rendering it as text to human).
	/// 
	/// </summary>
	public class Comparer : IComparer<Assignment>
	{


		public int Compare(Assignment x, Assignment y)
		{
			///order by vars.
			///
			return nilnul.obj.set.Comparer<var.Assignment, var.assignment.Comparer>.Singleton.Compare(
				x.toSet(),
				
				y.toSet()
			);


			//throw new NotImplementedException();
		}

		static private Lazy<Comparer> _Lazy = new Lazy<Comparer>();
		static public Comparer Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
