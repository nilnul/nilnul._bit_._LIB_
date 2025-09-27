using nilnul.bit.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.vars.assignment.interpretations._truthTable
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <see cref="nameof(TruthTable)"/>
	/// </remarks>
	///
	[Obsolete()]
	public class Matrix
	{

		private bool[,] _interpretations;
		public bool[,] interpretations
		{
			get { return _interpretations; }
			set { _interpretations = value; }
		}

		public int varsCount {
			get {
				return _interpretations.GetLength(1)-1;
			}
		}

		public IEnumerable<bool> results {
			get {
				var varsCount = this.varsCount;
				for (int i = 0; i < _interpretations.GetLength(0); i++)
				{
					yield return _interpretations[varsCount, i];
				}
			}
		}

		private Matrix(
			bool[,] interprets
		)
		{
			nilnul.obj.vow_.True.Vow(
				interprets.GetLength(0)  == 1 << ( varsCount)
			);
		}

		public bool this[int row, int col] {
			get {
				return _interpretations[row, col];
			}
			set {
				_interpretations[row, col] = value;

			}
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

	}
}