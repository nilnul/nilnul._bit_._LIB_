using nilnul.bit.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <see cref="nameof(TruthTable)"/>
	/// </remarks>
	//[Obsolete()]

	public class TruthTable1

	{
		private IEnumerable<Interpretation> _interpretations;
		public IEnumerable<Interpretation> interpretations
		{
			get { return _interpretations; }
		}





		private TruthTable1(
			IEnumerable<Interpretation> interprets

				)
		{
			expr.interprets.avow_.SameVars_Diff.Singleton.avow(interprets);

			///
			var varsCount = nilnul.bit.expr.interprets.be_.SameVars.En._getVars_assumeSameVars(interprets).Count();
			nilnul.obj.avow_.True.Avow(
				interprets.Count() == (1 << varsCount)
			);

			_interpretations = interprets;

		}






		public override string ToString()
		{
			return toTxt_inLines();


		}
		public string toTxt(string lineSeperator)
		{
			var interpretations = this.interpretations;
			return nilnul.str.ToTxtX.ToTxt1(interpretations, lineSeperator);
			//return nilnul.str.ToTxtX.ToTxt1(interpretations,nilnul.Txt.WindowLineBreak_byEnv);


		}
		
		public string toTxt_inLines()
		{

			return toTxt(Environment.NewLine);


		}

		[Obsolete(nameof(nilnul.bit.expr_.closed._ReifyX))]
		static public TruthTable1 Create(bit.ExprI_membered expr)
		{

			var vars = (expr as bit._expr.VarsI).vars;

			//var varsSorted = vars.OrderBy(a => a, nilnul.obj.var.comparer_.FroNaming.Lazy);
#if DEBUG
			//var assignments = nilnul.bit.var.set.Assignment._Enumerate(varsSorted).ToList();
			//var assignments = nilnul.bit.var.set.Assignment._Enumerate(vars.OrderBy( x=>x, nilnul.obj.var.comparer_.FroNaming.Lazy)).ToList();

#else
			//var assignments = nilnul.bit.var.set.Assignment._Enumerate(varsSorted);


#endif
			var assignments1 = nilnul.bit.var.set.Assignment._EnumerateToAssignments(vars).ToList();


			//var results = assignments.Select(x => Interpret._Eval(expr, x));

			var interpretations = assignments1.Select(
				x => new Interpretation(
				 	x,

					Interpret.Eval(expr, x)
				)
			);

			var truthTable = new TruthTable1(
				interpretations
			);
			return truthTable;


		}







	}
}
