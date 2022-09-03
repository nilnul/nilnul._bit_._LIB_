using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V = nilnul.bit.Var2;


namespace nilnul.bit.expr.ident
{
	public partial class XMiX_X: _ident.UnaryA
	{


		static public XMiX_X Singleton = SingletonByDefault<XMiX_X>.Instance;


		public XMiX_X(V x):base(x)
		{

		}

		public XMiX_X():this( new V() )
		{

		}

		public override ExprI_membered createExpr(Var2 x)
		{
			return nilnul.bit.expr.duo.Eq.Call(
						nilnul.bit.expr.duo.Call.CreateMi(x ,x)
						,
						x
			);


			throw new NotImplementedException();
		}



	}
}
