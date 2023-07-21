using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.ident
{
	/// <summary>
	/// x&y ->z  =  x -> y->z
	/// x&y ->z  =  x -> (y->z)
	/// 
	/// </summary>
	public class Exportation : nilnul.bit.expr._ident.TernaryA
	{


		public Exportation(Var2 v,Var2 v1,Var2 v2):base(v,v1, v2)
		{

		}

		public Exportation()
		{

		}

		/// <summary>
		/// x&y ->z  ~  x -> y->z
		/// </summary>
		/// <param name="v"></param>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public override ExprI_membered createExpr(Var2 v, Var2 v1, Var2 v2)
		{

			return nilnul.bit.expr.duo.Call.CreateEq(
				nilnul.bit.expr.duo.Call.CreateImply(
					nilnul.bit.expr.duo.Call.CreateMi(v, v1)
					,
					v2
				)
				,
				nilnul.bit.expr.duo.Call.CreateImply(
					v
					,

					nilnul.bit.expr.duo.Call.CreateImply(v1,v2)
				)


			);

			//throw new NotImplementedException();
		}
	}
}
