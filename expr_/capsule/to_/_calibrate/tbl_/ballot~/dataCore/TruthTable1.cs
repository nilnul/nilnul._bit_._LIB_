using nilnul.bit.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.vars.assignment.interpretations
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <see cref="nameof(TruthTable)"/>
	/// </remarks>
	[Obsolete(nameof(expr_.var.sortie.allots_.omni.Poll))]
	public class TruthTable
	{

		private _truthTable.Matrix _matrix;
		public _truthTable.Matrix matrix
		{
			get { return _matrix; }
			//set { _matrix = value; }
		}

		private nilnul.bit.var.Sortie1 _vars;
		public nilnul.bit.var.Sortie1 vars
		{
			get { return _vars; }
			//set { _vars = value; }
		}



		private TruthTable(
			nilnul.bit.var.Sortie1 vars
			,
			_truthTable.Matrix matrix
		)
		{
			 nilnul.obj.vow_.True.Vow( vars.en.Count() == matrix.varsCount,"Vars count is not equal to matrix.varsCount in TruthTable");

			_vars = vars;
			_matrix = matrix;

		}



	}
}
