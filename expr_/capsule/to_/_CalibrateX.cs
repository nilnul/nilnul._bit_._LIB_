using nilnul.obj.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.capsule.to_
{
	/// <summary>
	/// truth table of the expr; tabuleau;
	/// </summary>
	/// <see cref="nilnul.bit.expr.TruthTable1.Create(ExprI_membered)"/>
	/// alias:
	///		interprets
	///	<see cref="closed.to_.ICanonize"/>
	///	<see cref="closed.to_.ICalibrate"/>
	///	
	/// 
	static public class _CalibrateX
	{
		

		static public capsule.to_._calibrate.TruthTable _GetTruthTable_0capsule(this bit.ExprI_generi expr)
		{


			var vars = (expr).Vars().Select( v=> new bit.expr_.Var2(v));

			var varsAsSortie = new nilnul.bit.expr_.var.Sortie4generi(vars);

			var varsAsSorteEnumed = varsAsSortie.ee.ToArray();

			#region tableBody

			var inputs_enumerated = nilnul.bit.tups_._OmniX._Enumerate_lengthAssumeNatural(varsAsSorteEnumed.Length).ToArray();


			var results = inputs_enumerated.Select(
				x =>
					expr_.capsule._EvalX.Eval(
						expr,
						expr_.var.set.Sel._Create__assumeSameCount(varsAsSorteEnumed, x)
					)
			).ToArray();


			var matrix = new bool[
				inputs_enumerated.Count(),
				varsAsSorteEnumed.Length+ 1
				
			];

			for (int j = 0; j < inputs_enumerated.Count() ; j++)
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




			var truthTable = new nilnul.bit.expr_.capsule.to_._calibrate.TruthTable(
				varsAsSortie,
				tbody
			);
			return truthTable;


		}


		static public nilnul.bit.expr_.var.sortie.allots_.omni.Poll _GetTruthTable_0capsule(this bit.ExprI_sys expr)
		{


			var vars = nilnul.bit.expr._VarsX.Vars(expr);//.vars;

			var varsAsSortie = new nilnul.bit.expr_.var.Sortie1(vars);

			var varsAsSorteEnumed = varsAsSortie.ee.ToArray();

			#region tableBody

			var inputs_enumerated = nilnul.bit.tups_._OmniX._Enumerate_lengthAssumeNatural(varsAsSorteEnumed.Length).ToArray();


			var results = inputs_enumerated.Select(
				x => expr_.closed_.calc._EvalX.Eval(
						expr,
						expr_.var.set.Allot._Create__assumeSameCount(varsAsSorteEnumed, x)
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
