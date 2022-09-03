using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;
using nilnul.obj.expr.stati._stati;
using nilnul.bit.expr.stati;
using nilnul._expr;
using nilnul.bit._expr;
using nilnul.bit.var;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.expr.call_
{

	[Obsolete()]
	public class Duo
	:
	nilnul.obj.call_.Duo<bit.duo.OpI1, nilnul.bit.ExprI1, nilnul.bit.ExprI1>
		,
	nilnul.bit.ExprI1

	{
		public Duo(
			bit.duo.OpI1 op,
				bit.ExprI1 x, int y
		)
			: this(op, x, nilnul.bit.X.Fro(y))
		{

		}
		public Duo(
			bit.duo.OpI1 op,
				int x, E y
		)
			: this(op, nilnul.bit.X.Fro(x), y)
		{

		}
		public Duo(
			bit.duo.OpI1 op,
				int x, V y
		)
			: this(op, nilnul.bit.X.Fro(x), new nilnul.bit.expr_.VarAsExpr( y))
		{

		}

		public Duo(
						bit.duo.OpI1 op,
					bit.ExprI1 x, bool y

			)
			: this(
				 op, x, new nilnul.bit.expr.call_.No(y)
				 )
		{

		}

		public Duo(
						bit.duo.OpI1 op,
					bool x,E y

			)
			: this(
				 op, new nilnul.bit.expr.call_.No( x), (y)
				 )
		{

		}


		public Duo(
			bit.duo.OpI1 op,
				bit.ExprI1 x, bit.ExprI1 y
		)
			: base(op, x, y)
		{

		}

		public Duo(
				bit.duo.OpI1 op,
					bit.ExprI1 x, bit.VarI1 y
			)
				:
			this(op,
					x, new expr_.VarAsExpr(y)
				)
		{

		}

		public Duo(
				bit.duo.OpI1 op,
					bit.VarI1 x, bit.ExprI1 y
			)
				:
			this(op,
					new expr_.VarAsExpr(x), y
				)
		{

		}


		public Duo(
			bit.duo.OpI1 op,

			bit.VarI1 x, bit.VarI1 y

			)
			: this(op,
				new expr_.VarAsExpr(x), new expr_.VarAsExpr(y)
			)
		{

		}

		public Duo(
			bit.duo.OpI1 op,

			bit.VarI1 x, int y

			)
			: this(op,
				new expr_.VarAsExpr(x), 
				expr.call_.No.Create(y)

			)
		{

		}



		public nilnul.bit.var.Set1 vars
		{
			get
			{
				var r = new nilnul.bit.var.Set1();
				r.UnionWith(
						(arg).vars

					);
				r.UnionWith(
						(arg1).vars

					);
				return r;


				//throw new NotImplementedException();
			}
		}





		public bit.ExprI1 substitute(bit.VarI1 var, bit.ExprI1 expr)
		{
			return new Duo(
				this.op,
				(arg ).substitute(var, expr),
				(arg1).substitute(var, expr)

		);
			//throw new NotImplementedException();
		}

		public ExprI1 reduce()
		{


			var argReduced = (arg ).reduce();
			var arg1Reduced = (arg1).reduce();

			if (argReduced is call_.NoI && arg1Reduced is call_.NoI)
			{
				return new call_.No(
					op.eval(

						(argReduced as call_.NoI).eval()
						,
						(arg1Reduced as call_.NoI).eval()
					)

				);
			}
			else
			{
				return new Duo(
					op
					,
					argReduced, arg1Reduced
				);
			}

			throw new NotImplementedException();
		}

		static public Duo CreateNe(ExprI1 x, ExprI1 y)
		{
			return new Duo(bit.duo.op.Ne.Singleton, x, y);
		}

		static public Duo CreateNe(VarI1 x, V y)
		{
			return new Duo(bit.duo.op.Ne.Singleton, x, y);
		}

		static public Duo CreateEq(ExprI1 x, ExprI1 y)
		{
			return new Duo(bit.duo.op.Eq.Singleton, x, y);
		}

		static public Duo CreateEq(ExprI1 x, V y)
		{
			return new Duo(bit.duo.op.Eq.Singleton, x, y);
		}
		static public Duo CreateEq(V x, E y)
		{
			return new Duo(bit.duo.op.Eq.Singleton, x, y);
		}


		static public Duo CreateEq(V x, V y)
		{
			return new Duo(bit.duo.op.Eq.Singleton, x, y);
		}


		static public Duo CreateEq(ExprI1 x, int y)
		{
			return new Duo(bit.duo.op.Eq.Singleton, x, y);
		}

		

		static public Duo CreateEq(int x, E y)
		{
			return new Duo(bit.duo.op.Eq.Singleton, x, y);
		}
		static public Duo CreateEq(int x, V y)
		{
			return new Duo(bit.duo.op.Eq.Singleton, x, y);
		}

		static public Duo CreateEq(V x, int y)
		{
			return new Duo(bit.duo.op.Eq.Singleton, x, y);
		}


		public static ExprI1 CreateNe(VarI1 x, int y)
		{
			return CreateNe(
				new expr_.VarAsExpr(x)
				,

				nilnul.bit.X.Fro(y)
			);

			//throw new NotImplementedException();
		}
		public static ExprI1 CreateNe(ExprI1 x, bool y)
		{
			return CreateNe(
				x
				,

				new nilnul.bit.expr.call_.No(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateNe(VarI1 x, bool y)
		{
			return CreateNe(
				new expr_.VarAsExpr(x)
				,

				new nilnul.bit.expr.call_.No(y)
			);

			throw new NotImplementedException();
		}
		public static ExprI1 CreateImply(E x, E y)
		{
			return new Duo(
				nilnul.bit.duo.op.Le.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static ExprI1 CreateImply(int x, V y)
		{
			return new Duo(
				nilnul.bit.duo.op.Le.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static ExprI1 CreateImply(int x, E y)
		{
			return new Duo(
				nilnul.bit.duo.op.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}




		public static ExprI1 CreateImply(E x, V y)
		{
			return new Duo(
				nilnul.bit.duo.op.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI1 CreateImply(V x, V y)
		{
			return new Duo(
				nilnul.bit.duo.op.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateNi(V x, V y)
		{
			return new Duo(
				nilnul.bit.duo.op.Ni.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateNi(E x, V y)
		{
			return new Duo(
				nilnul.bit.duo.op.Ni.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateNi(V x, E y)
		{
			return new Duo(
				nilnul.bit.duo.op.Ni.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static ExprI1 CreateImply(V x, E y)
		{
			return CreateImply( new expr_.VarAsExpr( x)  ,y );

			throw new NotImplementedException();
		}




		public static ExprI1 CreateMa(E x, E y)
		{
			return new Duo(
				nilnul.bit.duo.op.Ma.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI1 CreateMa(E x, Var2 y)
		{
			return new Duo(
				nilnul.bit.duo.op.Ma.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI1 CreateMa(Var2 x, E y)
		{
			return new Duo(
				nilnul.bit.duo.op.Ma.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static ExprI1 CreateMa(VarI1 x, VarI1 y)
		{
			return CreateMa(
				new expr_.VarAsExpr(x)
				,
				new expr_.VarAsExpr(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateNe(ExprI1 x, VarI1 y)
		{

			return CreateNe(
				x
				,
				new expr_.VarAsExpr(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI1 CreateNe(VarI1 x, ExprI1 y)
		{



			return CreateNe(
					new expr_.VarAsExpr(x),
				y

			);

			throw new NotImplementedException();
		}



		internal static ExprI1 CreateNe(bool x, VarI1 y)
		{

			return CreateNe(
				 new nilnul.bit.expr.call_.No(x),


					new expr_.VarAsExpr(y)


			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateMi(ExprI1 x, VarI1 y)
		{

			return CreateMi(
				 x
				 ,
					new expr_.VarAsExpr(y)


			);

			throw new NotImplementedException();
		}



		public static ExprI1 CreateMi(V x, E y)
		{

			return CreateMi(
				   new expr_.VarAsExpr( x)
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateMi(V x, V y)
		{

			return CreateMi(
				   new expr_.VarAsExpr( x)
				 ,
					y


			);

			throw new NotImplementedException();
		}



		public static ExprI1 CreateMi(ExprI1 x, ExprI1 y)
		{

			return new Duo(
				nilnul.bit.duo.op.Mi.Instance,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}
		public static ExprI1 CreateAnd(ExprI1 x, ExprI1 y)
		{

			return new Duo(
				nilnul.bit.duo.op.Mi.Instance,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}


	}

}
