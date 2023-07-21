using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr.in2n.eg
{

	/// <summary>
	/// a collection of vars that is empty, with a complete group of ops, say, (not ,and ,or)
	/// </summary>
	public class TwoVars : In2nI
	{
		private V _v;

		public V v
		{
			get { return _v; }
			set { _v = value; }
		}

		private V _v1;

		public V v1
		{
			get { return _v1; }
			set { _v1 = value; }
		}

		/// <summary>
		/// a collection of all finite exprs.
		/// </summary>
		/// <returns></returns>

		public IEnumerable<ExprI_membered> CreateEnumerable()
		{
			#region sum of empty
			//sum()
			/// (x,y) => 0
			yield return nilnul.bit.expr.no.Call.CreateNil();

			#endregion

			#region sum of one
			/// sum( x&y)
			/// x&y
			/// and
			yield return nilnul.bit.expr.duo.Call.CreateMa(_v, _v1);

			/// sum( x&!y)
			/// gt
			/// 
			yield return nilnul.bit.expr.duo.Call.CreateMa(
				new nilnul.bit.expr.VarAsExpr(_v)
				,
				nilnul.bit.expr.Call.CreateNeg(_v1)
			);


			/// sum( !x&y)
			/// lt
			/// 
			yield return nilnul.bit.expr.duo.Call.CreateMa(
				nilnul.bit.expr.Call.CreateNeg(_v)
				,
				new nilnul.bit.expr.VarAsExpr(_v1)
			);

			/// sum( !x&!y)
			/// nor
			yield return nilnul.bit.expr.duo.Call.CreateMa(
				nilnul.bit.expr.Call.CreateNeg(_v)
				,
				nilnul.bit.expr.Call.CreateNeg(_v1)
			);
			#endregion


			#region sum of two
			/// sum( x&y, x&!y)=     (x,y) => x
			/// head
			yield return new nilnul.bit.expr.VarAsExpr(_v);

			/// sum( x&y, !x&y) = (x,y) =>y
			/// toe
			yield return new nilnul.bit.expr.VarAsExpr(_v);

			/// sum( x&y, !x&!y)= x~y
			yield return nilnul.bit.expr.duo.Call.CreateEq(
				nilnul.bit.expr.Call.CreateNeg(_v)
				,
				nilnul.bit.expr.Call.CreateNeg(_v1)
			);

			/// sum( x&!y, !x&y)
			/// xor
			yield return nilnul.bit.expr.duo.Call.CreateNe(_v, _v1);

			///sum(x&!y , !x&!y)
			///!y
			/// negToe
			yield return nilnul.bit.expr.Call.CreateNeg(_v1);

			/// sum( !x&y, !x&!y)
			/// !x
			/// neg head
			yield return nilnul.bit.expr.Call.CreateNeg(_v);
			#endregion


			#region sum of three
			/// = !( !x&!y )
			/// =x|y
			/// or
			yield return   nilnul.bit.expr.duo.Call.CreateMa(_v, _v1); ;

			/// = !( x&y )
			/// =!x|!y
			/// nand
			yield return nilnul.bit.expr.duo.Call.CreateNi(_v, _v1);

			/// !(x&!y)
			/// !x|y
			/// imply|le
			yield return nilnul.bit.expr.duo.Call.CreateImply(
				(_v)
				,
				(_v1)
			);

			/// !(!x&y)
			/// x|!y
			/// ge, reverse imply
			yield return nilnul.bit.expr.duo.Call.CreateImply(
				(_v1)
				,
				(_v)
			);


			#endregion

			/// sum( .... )
			/// 1
			/// 
			yield return nilnul.bit.expr.no.Call.CreateOne();

			yield break;



		}
	}
}
