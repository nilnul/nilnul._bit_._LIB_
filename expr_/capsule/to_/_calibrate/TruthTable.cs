using nilnul.bit.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.capsule.to_._calibrate
{
	/// <summary>
	/// truth table;
	/// interpretations of vars's assignment; in fact, a <seealso cref="nameof(bit.tup.sortie_.omni.Poll)"/> with header
	/// </summary>
	/// <remarks>
	/// <see cref="TruthTable"/>
	/// </remarks>
	/// 
	/// <see cref="var.set.sels_.omni.IPoll"/>
	///	[Obsolete(nameof(nilnul.bit.expr_.var.sortie.allots_.omni.Poll))]


	public class TruthTable
		:
		expr_.var.sortie.sels_.omni.IPoll
	{

		private bit.tup.sortie_.omni.Poll _matrix;
		public bit.tup.sortie_.omni.Poll matrix
		{
			get { return _matrix; }
			//set { _matrix = value; }
		}

		private nilnul.bit.expr_.var.Sortie4generi _vars;
		public nilnul.bit.expr_.var.Sortie4generi vars
		{
			get { return _vars; }
			//set { _vars = value; }
		}



		public TruthTable(
			nilnul.bit.expr_.var.Sortie4generi vars
			,
			bit.tup.sortie_.omni.Poll matrix
		)
		{
			 nilnul.obj.vow_.True.Vow( vars.ee.Count() == matrix.varsCount,"Vars count is not equal to matrix.varsCount in TruthTable");

			_vars = vars;
			_matrix = matrix;

		}
		public IEnumerable<string> toLines() {
			yield return this.vars.ToString();	//the col of result is not appended
			foreach (var item in this._matrix.toLines())
			{
				yield return item;
			}


		}

		public override string ToString()
		{

			return nilnul.objs._PhraseX._PhraseAsLines( this.toLines() );
		}



	}
}
