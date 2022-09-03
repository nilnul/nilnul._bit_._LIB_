using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.closed
{
	/// <summary>
	/// to var.sortie
	/// </summary>
	static public class _ReifyX
	{
		

		static public nilnul.bit.expr_.var.sortie.allots_.omni.Poll GetTruthTable_assumeClosed(this bit.Expr_sys expr)
		{


			var vars = (expr).vars;

			var varsAsSortie = new nilnul.bit.expr_.var.Sortie1(vars);

			var varsAsSorteEnumed = varsAsSortie.ee.ToArray();

			#region tableBody

			var inputs_enumerated = nilnul.bit.tups_._OmniX._Enumerate_lengthAssumeNatural(varsAsSorteEnumed.Length).ToArray();


			var results = inputs_enumerated.Select(
				x =>
					expr_.closed_.calc._EvalX.Eval(
						expr,
						var.set.Allot._Create__assumeSameCount(varsAsSorteEnumed, x)
					)
			).ToArray();


			var matrix = new bool[
				inputs_enumerated.Count(),
				varsAsSorteEnumed.Length+ 1
				
			];

			for (int j = 0; j < inputs_enumerated.Count() - 1; j++)
			{
				var inputEager = inputs_enumerated[j].ToArray();

				int i = 0;
				for (; i < varsAsSorteEnumed.Length; i++)
				{

					matrix[j, i] = inputEager[i];

				}
				matrix[j, i] = results[j];

			}

			var tbody = new bit.tup.sortie_.omni.Poll(
				matrix
			);


			#endregion




			var truthTable = new nilnul.bit.expr_.var.sortie.allots_.omni.Poll(
				varsAsSortie,
				tbody
			);
			return truthTable;


		}


		static public nilnul.bit.expr_.var.sortie.allots_.omni.Poll GetTruthTable_assumeClosed(this bit.ExprI_sys expr)
		{


			var vars = nilnul.bit.expr._VarsX.Vars(expr);//.vars;

			var varsAsSortie = new nilnul.bit.expr_.var.Sortie1(vars);

			var varsAsSorteEnumed = varsAsSortie.ee.ToArray();

			#region tableBody

			var inputs_enumerated = nilnul.bit.tups_._OmniX._Enumerate_lengthAssumeNatural(varsAsSorteEnumed.Length).ToArray();


			var results = inputs_enumerated.Select(
				x => expr_.closed_.calc._EvalX.Eval(
						expr,
						var.set.Allot._Create__assumeSameCount(varsAsSorteEnumed, x)
					)
			).ToArray();


			var matrix = new bool[
				inputs_enumerated.Count(),
				varsAsSorteEnumed.Length+ 1
				
			];

			for (int j = 0; j < inputs_enumerated.Count(); j++)
			{
				var inputEager = inputs_enumerated[j].ToArray();

				int i = 0;
				for (; i < varsAsSorteEnumed.Length; i++)
				{

					matrix[j, i] = inputEager[i];

				}
				matrix[j, i] = results[j];

			}

			var tbody = new bit.tup.sortie_.omni.Poll(
				matrix
			);


			#endregion




			var truthTable = new nilnul.bit.expr_.var.sortie.allots_.omni.Poll(
				varsAsSortie,
				tbody
			);
			return truthTable;


		}


	}
}
