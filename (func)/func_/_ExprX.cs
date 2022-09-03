using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.expr_.PlainI;

namespace nilnul.bit.func_
{
	/// <summary>
	/// convert an expr to func
	/// </summary>
	public class _ExprX
	{
		static public nilnul.bit.FuncI2 Construct(E expr) {
			return new Func2(new var.Sortie1(),expr);
		}
	}


}
