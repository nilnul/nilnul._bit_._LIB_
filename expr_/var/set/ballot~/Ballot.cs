using nilnul.bit.var.stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var.sortedSet.be;

namespace nilnul.bit.var.set
{
	/// <summary>
	/// before passing parameter to a function, the vars are assigned value and before arguments. 
	/// </summary>
	/// <remarks>
	/// alias:
	///
	///		checklist
	///		
	/// The computed results by the funtion after taking in the assignment is not touched on here. The computed result, together with the assignment will be defined in "Interpretation"</remarks>
	///
	[Obsolete(nameof(bit.expr_.var.set.IBallot))]
	public class Ballot:Dictionary<bit.VarI1,bool>
	{

		public Ballot()
			:base(nilnul.bit.var.Eq.Singleton)
		{

		}

		public override string ToString()
		{
			return ToTxtOrdered();
		}
		public IEnumerable<var.Assign> enumerateByOrder()
		{
			return this.Select(a => new var.Assign(a)).OrderBy(x => x.var, nilnul.obj.var.comparer_.FroNaming.Lazy);
		}

		public string ToTxtOrdered()
		{
			return $@"{ nilnul.str.ToTxtX.ToTxt1(
				enumerateByOrder().Select(x => x.ToString())
			)
			}";
		}


		public nilnul.bit.var.assign.set_.ByVar toSet()
		{
			var r = new nilnul.bit.var.assign.set_.ByVar();

			foreach (var item in this)
			{
				r.hashSet.Add(new var.Assign(item.Key, item.Value));
			}
			return r;
		}




	}
}
