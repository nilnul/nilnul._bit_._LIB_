using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.sortedSet.state_.fixedVars
{
	public class Comparer:IComparer<nilnul.bit.var.sortedSet.State>

	{
		private nilnul.bit.var.SortedSet _vars;

		public nilnul.bit.var.SortedSet vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		public Comparer( nilnul.bit.var.SortedSet vars)
		{
			_vars = vars;
		}
		/// <summary>
		/// the vars of either state is a sorted and the same as _vars.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int Compare(State _x_withGivenVars, State _y_withGivenVars)
		{

			return nilnul.bit.str_.fixedLen.Comparer.Lazy.Compare(
				_x_withGivenVars.Values
				,
				_y_withGivenVars.Values	
			);
			
			//throw new NotImplementedException();
		}



	}
}
