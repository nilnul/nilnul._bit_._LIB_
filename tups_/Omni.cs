using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.tups_
{
	static public class _OmniX
	{


		/// <summary>
		/// note the sequence must be constant.
		/// </summary>
		/// <param name="_distinct"></param>
		/// <returns></returns>
		static public IEnumerable<IEnumerable<bool>> _Enumerate_lengthAssumeNatural(int _distinct)
		{

			if (_distinct == 0)
			{
				yield return new bool[0];
				yield break;    //this is important.

			}

			//var firstVar = _distinct.First();

			foreach (
				var item in
				_Enumerate_lengthAssumeNatural(
					_distinct-1
				)

			)
			{
				yield return nilnul.obj.str.convert_._HeadX.Head(false, item);
				yield return nilnul.obj.str.convert_._HeadX.Head(true, item);

			}

		}

		static public bool[,] _MatrixByTup_assumeNatural(int length) {
			var lazy = _Enumerate_lengthAssumeNatural(length);
			var eager=lazy.ToArray();

			var r = new bool[
				eager.Length
				,
				length
			];

			for (int i = 0; i < eager.Length; i++)
			{
				var t=eager[i].ToArray();
				for (int j = 0; j < length; j++)
				{
					r[i, j] = t[j];
				}
			}
			return r;
		}
	}
}
