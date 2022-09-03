using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.var.set
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///	alias:
	///		checklist
	///		check
	///	nomenclature:
	///		Ballot
	///			b all of biT
	///		Poll
	///			vs Vote, which is yes/no for a single question, poll is yes/no for each and every memeber of a set.
	///		Assignment
	///			assign value to each/every var
	///		allot
	///			all of typedVal
	///				vs assign: assign is for a single variable
	///			like ballot, but without B
	/// </remarks>
	/// 
	public class Allot : nilnul.obj.dict_.Poll<nilnul.bit.expr_.Var_sys,  nilnul.bit.expr_.var.Eq>
	{
		public Allot(Dictionary<nilnul.bit.expr_.Var_sys, bool> dict):base(dict)
		{
		}
		public Allot():this(new Dictionary<nilnul.bit.expr_.Var_sys, bool>())
		{

		}


		static public Allot _Create__assumeSameCount(IEnumerable<bit.expr_.Var_sys> vars1, IEnumerable<bool> vals

		)
		{

			var r = new Allot();
			for (int i = 0; i < vars1.Count(); i++)
			{
				r.Add(vars1.ElementAt(i), vals.ElementAt(i));
			}
			return r;

		}
	}
}
