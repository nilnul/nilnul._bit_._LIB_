﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.expr.be_.tauto
{
	public class Vow:nilnul.obj.be.Vow_beDefault<nilnul.bit.ExprI1, Tauto>
	{



		static public readonly Vow Singleton = nilnul.obj.SingletonByDefault<Vow>.Instance;

		[Obsolete(nameof(Singleton))]
		static public void Eval( E x ) {

			nilnul.obj.vow_.True.Vow(
				nilnul.bit.expr.be_.Tauto.Eval(x)
			);

		}
	}
}
