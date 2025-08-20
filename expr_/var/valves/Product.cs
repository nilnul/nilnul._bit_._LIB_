using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var.set;

namespace nilnul.bit.expr_.var.valves
{

	/// <summary>
	/// eg:
	///		xy
	///		x!y
	///		x!x
	///		{}
	///		xx
	///			,as this is a set of vote
	/// </summary>
	public interface IProduct { }

	static public class _ProductX
	{
		static public set.Ballot ProductAsMinterm0nul<T>(
			IEnumerable<(nilnul.bit.expr_.Var2 var, bool val)> votes
		)
		{
			var r = new var.set.Ballot();
			foreach (var vote in votes)
			{
				var v = vote.var;
				var val = vote.val;

				if (r.ContainsKey(v))
				{
					if (r[v] != val) // eg: x !x  , this is not a minterm. recall that empty minterm is one, not nil. nil cannot be expressed by product, but by sum.
					{
						return null;
					}
					//else:  no need to add to dict;
				}
				else
				{
					r.Add(v, val);
				}

			}
			return (r);

		}


		static public set.Ballot ProductAsMinterm0nul<T>(IEnumerable<KeyValuePair<Var2, bool>> votes)
		{
			return ProductAsMinterm0nul<T>(
				votes.Select(
					v => (v.Key, v.Value)
				)
			);

		}
	}



}
