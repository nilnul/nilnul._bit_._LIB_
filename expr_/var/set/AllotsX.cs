using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.var.set
{
	/// <summary>
	/// <see cref="var.set.ISels"/>
	/// </summary>
	public class _AllotsX
	{



		static public IEnumerable<Allot> _EnumerateToPolls(IEnumerable<bit.expr_.Var_sys> _distinct)
		{

			var x = expr_.var.sortie._assign._ValsX._Enumerate_assumeNatural(_distinct.Count());

			foreach (var item in x)
			{
				yield return Allot._Create__assumeSameCount(_distinct, item);
			}

		}

	}
}
