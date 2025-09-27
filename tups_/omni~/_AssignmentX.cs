using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.var.sortie._assign
{
	[Obsolete()]
	static public class _ValsX
	{


		/// <summary>
		/// note the sequence must be constant.
		/// </summary>
		/// <param name="_distinct"></param>
		/// <returns></returns>
		static public IEnumerable<IEnumerable<bool>> _Enumerate_assumeNatural(int _distinct)
		{

			if (_distinct == 0)
			{
				yield return new bool[0];
				yield break;    //this is important.

			}

			//var firstVar = _distinct.First();

			foreach (
				var item in
				_Enumerate_assumeNatural(
					_distinct-1
				)

			)
			{
				yield return nilnul.obj.str.convert_._HeadX.Head(false, item);
				yield return nilnul.obj.str.convert_._HeadX.Head(true, item);

			}

		}

	}
}
