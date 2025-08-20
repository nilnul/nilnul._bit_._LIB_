using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi
{
	static public class _SortieX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// each is <see cref="bi._TabuloX"/>
		/// </returns>
		static public IEnumerable<IEnumerable<bool?>> EachAsOutcome() {


			return nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<bool?>.Singleton.cumulate_each2monos(
				Enumerable.Repeat(
					bit0nul._SortieX.ARRAY
					,
					bit0nul.co._SortieX.Array.Length
				)	/// [...],[...],[...],...[...]
			).Select(
				x=>x.Reverse()
			);
			
		}

		static public BigInteger _Count() 
		{
			return BigInteger.Pow(
				nilnul.bit0nul._SortieX.COUNT
				,
				(int)BigInteger.Pow(nilnul.bit0nul._SortieX.COUNT, (int)bit0nul.Bi.ARITY)
			);
			//$"the length of outcome, being {length}, must be 3^(3^2)=19683;"

		}


	}
}
