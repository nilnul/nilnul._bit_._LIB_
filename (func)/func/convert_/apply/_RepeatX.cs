using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.expr_.PlainI;//.ExprI3;

namespace nilnul.bit.func.convert_.apply
{
	/// <summary>
	/// To correspond to the convert_.Vary, which append a var, the Apply remove that last var.
	/// </summary>
	/// 
	static public class _RepeatX
	{

	

		static public FuncI2 Op(FuncI2 func, IEnumerable<E> exprs) {

			var applied = func;

			foreach (var item in exprs)
			{
				applied=nilnul.bit.func.convert_._ApplyX.Op(applied, item);
			}
			return applied;
		}

		static public FuncI2 Op(FuncI2 func, params E[] exprs) {

			var applied = func;

			foreach (var item in exprs)
			{
				applied=nilnul.bit.func.convert_._ApplyX.Op(applied, item);
			}
			return applied;
		}

	}
}
