using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.of_.vec
{
	static public class _TruthTableX
	{
		static public IEnumerable<bool> LastCol(of_.VecI op)
		{

			return nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<bool>.Singleton.cumulate_each2monos(
	Enumerable.Repeat(
		nilnul.bit.Sortie.All.ee



		,
		op.arity
	)
).Select(
				input => op.op(input)
	);


		}

		static public tup.sortie_.omni.Poll Tabuleau(of_.VecI op)
		{
			var inputs =nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<bool>.Singleton.cumulate_each2monos(
				Enumerable.Repeat(
					nilnul.bit.Sortie.All.ee
					,
					op.arity
				)
			);

			var lastCol = inputs.Select(
				input => op.op(input)
			);

			return bit.tup.sortie_.omni.Poll.OfAllots1results(
				inputs
				,
				lastCol
			);
		}
	}
}
