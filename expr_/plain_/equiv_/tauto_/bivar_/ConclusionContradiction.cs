﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI1;


namespace nilnul.bit.expr_.call_.duo.be_.equiv.vow.ed.be_.tauto.vow.ed_
{
	/// <summary>
	/// x & !y ->0 = x->y
	/// </summary>
	public class ConclusionContradiction : Ed
	{
		public ConclusionContradiction(V a, V b) : base(

			bit.expr_.call_.Duo.CreateImply(
				bit.expr_.call_.Duo.CreateAnd(
					a
					,
					bit.expr_.call_.Mono.CreateNeg(b)
				)
				,
				bit.expr_.call_.No.CreateNil()
			)
			,
			bit.expr_.call_.Duo.CreateImply(
				a
				,
				b
			)
		)
		{

		}

		/// <summary>
		/// x-> x&!y ->0 =   x & !y ->0
		/// x-> ( x&!y ->0 ) =   x & !y -> 0
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public E CreateExpr(V a, V b)
		{
			return bit.expr_.call_.Duo.CreateEq(
				bit.expr_.call_.Duo.CreateImply(
					a
					,
					bit.expr_.call_.Duo.CreateImply(
						bit.expr_.call_.Duo.CreateAnd(
							a
							,
							bit.expr_.call_.Mono.CreateNeg(b)
						)
						,
						bit.expr_.call_.No.CreateNil()

					)
				)
				,
				bit.expr_.call_.Duo.CreateImply(
					bit.expr_.call_.Duo.CreateAnd(
						a
						,
						bit.expr_.call_.Mono.CreateNeg(b)
					)
					,
					bit.expr_.call_.No.CreateNil()
				)
			);
		}
	}
}
