using nilnul.bit.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.tup.sortie_.omni
{
	/// <summary>
	/// by using sortie, the data is compactly stored in a structure
	/// </summary>
	/// 
	/// <remarks>
	/// this is useful for <see cref="bit.expr_.var.sortie.sels_.omni.IPoll"/>
	/// <see cref="nameof(TruthTable)"/>
	/// </remarks>
	/// alias:
	///		ballot
	public class Poll:IPoll
	{
		/// <summary>
		/// first dimension is index for rows. each row is <see cref="bit.tup.IVote"/> ( an assignment, and the result).
		/// </summary>

		private bool[,] _votes;
		public bool[,] votes
		{
			get { return _votes; }
			set { _votes = value; }
		}

		public int varsCount {
			get {
				return _votes.GetLength(1)-1;
			}
		}

		public IEnumerable<bool> results {
			get {
				var varsCount = this.varsCount;
				for (int i = 0; i < _votes.GetLength(0); i++)
				{
					yield return _votes[i, varsCount];
				}
			}
		}

		public Poll(
			bool[,] votes
		)
		{
			this._votes = votes;
			nilnul.obj.vow_.True.Vow(
				votes.GetLength(0)  == 1 << ( varsCount)
			);
		}

		public static Poll OfResults(params int[] v1)
		{
			return OfResults(
				v1.Select(x=>
					nilnul.bit.op_.of_._IntegerX.Op(x)
				)
			);
		}

		public bool this[int row, int col] {
			get {
				return _votes[row, col];
			}
			set {
				_votes[row, col] = value;

			}
		}
		public override string ToString()
		{
			return $"{ lastCol2Txt() }";
			return toTxt_inLines();

		}

		public string toTxt(string lineSeperator)
		{
			var interpretations = this.votes;
			return nilnul.str.ToTxtX.ToTxt1(interpretations, lineSeperator);
			//return nilnul.str.ToTxtX.ToTxt1(interpretations,nilnul.Txt.WindowLineBreak_byEnv);

		}
		public string lastCol2Txt(string lineSeperator)
		{
			//var interpretations = nilnul.obj.matrix._ExtensionsX.Col( this.votes
			//	,
			//	this.votes.GetLength(1)-1
			//);


			return nilnul.str.ToTxtX.ToTxt1(this.results.Select(x=> nilnul.bit.phrase_._NumX.Exe(x)), lineSeperator);
			//return nilnul.str.ToTxtX.ToTxt1(interpretations,nilnul.Txt.WindowLineBreak_byEnv);

		}

		public string lastCol2Txt()
		{
			return lastCol2Txt(",");
		}

		public IEnumerable< string> toLines()
		{
			return nilnul.obj.matrix._RowsX.Rows(this._votes).Select(
				r=>				nilnul.objs._PhraseX._Phrase(r)
			);

		}

		
		public string toTxt_inLines()
		{
			return toTxt(Environment.NewLine);
		}

		public static Poll OfAllots1results(IEnumerable<IEnumerable<bool>> bitCoEs, IEnumerable<bool> results)
		{
			var matrix = new bool[
				bitCoEs.Count()

				,
				bitCoEs.First().Count()+1
			];

			var cols = matrix.GetLength(1);
			var colsDec = cols - 1;


			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < cols-1; j++)
				{
					matrix[i, j] = bitCoEs.ElementAt(i).ElementAt(j);

				}
				matrix[i,colsDec ] = results.ElementAt(i);

			}

			return new Poll(matrix);


		}

		public static Poll OfResults( IEnumerable<bool> results)
		{
			var countOfResults = results.Count();
			//it must be pow of 2.

			var varsCount = nilnul.num_.positive._LbX.Lb(countOfResults, out bool strict);
			if (!strict)
			{
				throw new ArgumentException(
					$"{results} has to be PowOf2 strictly."
				);
			}


			var matrix = new bool[
				countOfResults

				,
				varsCount + 1
			];

			var cols = matrix.GetLength(1);
			var colsDec = cols - 1;

			var tups =  nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<bool>.Singleton.cumulate_each2monos(
				Enumerable.Repeat(
					nilnul.bit.Sortie.All.ee
					,
					varsCount
				)
			);


			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < cols - 1; j++)
				{
					matrix[i, j] = tups.ElementAt(i).ElementAt(j);

				}
				matrix[i, colsDec] = results.ElementAt(i);

			}

			return new Poll(matrix);


		}

	}
}