using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.expr_.PlainI;

namespace nilnul.bit.func.construct_
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

	public class Expr : nilnul.bit.func.ConstructI<E>
	{
		public FuncI2 op(E par)
		{
			return _ExprX.Construct(par);
			throw new NotImplementedException();
		}


		static public Expr Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Expr>.Instance;
			}
		}

	}


}
