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
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr.duo
{

	public class Call
	:
	nilnul.expr.duo.Call<bit.duo.OpI1, bool, bool, bool, bit.ExprI_membered, bit.ExprI_membered>
		,
	bit.ExprI_membered
	{
		public Call(
			bit.duo.OpI1 op,
				bit.ExprI_membered x, int y
		)
			: this(op, x, nilnul.bit.X.Fro(y))
		{

		}
		public Call(
			bit.duo.OpI1 op,
				int x, E y
		)
			: this(op, nilnul.bit.X.Fro(x), y)
		{

		}
		public Call(
			bit.duo.OpI1 op,
				int x, V y
		)
			: this(op, nilnul.bit.X.Fro(x), new VarAsExpr( y))
		{

		}

		public Call(
						bit.duo.OpI1 op,
					bit.ExprI_membered x, bool y

			)
			: this(
				 op, x, new nilnul.bit.expr.no.Call(y)
				 )
		{

		}

		public Call(
						bit.duo.OpI1 op,
					bool x,E y

			)
			: this(
				 op, new nilnul.bit.expr.no.Call( x), (y)
				 )
		{

		}


		public Call(
			bit.duo.OpI1 op,
				bit.ExprI_membered x, bit.ExprI_membered y
		)
			: base(op, x, y)
		{

		}

		public Call(
				bit.duo.OpI1 op,
					bit.ExprI_membered x, bit.VarI1 y
			)
				:
			this(op,
					x, new VarAsExpr(y)
				)
		{

		}

		public Call(
				bit.duo.OpI1 op,
					bit.VarI1 x, bit.ExprI_membered y
			)
				:
			this(op,
					new VarAsExpr(x), y
				)
		{

		}


		public Call(
			bit.duo.OpI1 op,

			bit.VarI1 x, bit.VarI1 y

			)
			: this(op,
				new VarAsExpr(x), new VarAsExpr(y)
			)
		{

		}

		public Call(
			bit.duo.OpI1 op,

			bit.VarI1 x, int y

			)
			: this(op,
				new VarAsExpr(x), 
				expr.no.Call.Create(y)

			)
		{

		}



		nilnul.bit.var.Set _expr.VarsI.vars
		{
			get
			{
				var r = new nilnul.bit.var.Set();
				r.UnionWith(
						(arg as bit._expr.VarsI).vars

					);
				r.UnionWith(
						(arg1 as bit._expr.VarsI).vars

					);
				return r;


				throw new NotImplementedException();
			}
		}





		public bit.ExprI_membered substitute(bit.VarI1 var, bit.ExprI_membered expr)
		{
			return new Call(
				this.op,
				(arg as bit._expr.SubstituteI).substitute(var, expr),
				(arg1 as bit._expr.SubstituteI).substitute(var, expr)

		);
			throw new NotImplementedException();
		}

		ExprI_membered nilnul._expr.ReduceI<ExprI_membered>.reduce()
		{


			var argReduced = (arg as _expr.ReduceI).reduce();
			var arg1Reduced = (arg1 as _expr.ReduceI).reduce();

			if (argReduced is no.Call && arg1Reduced is no.Call)
			{
				return new no.Call(
					op.eval(

						(argReduced as no.Call).eval()
						,
						(arg1Reduced as no.Call).eval()
					)

				);
			}
			else
			{
				return new Call(
					op
					,
					argReduced, arg1Reduced
				);
			}

			throw new NotImplementedException();
		}

		static public Call CreateNe(ExprI_membered x, ExprI_membered y)
		{
			return new Call(bit.duo.op.Ne.Singleton, x, y);
		}

		static public Call CreateNe(VarI1 x, V y)
		{
			return new Call(bit.duo.op.Ne.Singleton, x, y);
		}

		static public Call CreateEq(ExprI_membered x, ExprI_membered y)
		{
			return new Call(bit.duo.op.Eq.Singleton, x, y);
		}

		static public Call CreateEq(ExprI_membered x, V y)
		{
			return new Call(bit.duo.op.Eq.Singleton, x, y);
		}
		static public Call CreateEq(V x, E y)
		{
			return new Call(bit.duo.op.Eq.Singleton, x, y);
		}


		static public Call CreateEq(V x, V y)
		{
			return new Call(bit.duo.op.Eq.Singleton, x, y);
		}


		static public Call CreateEq(ExprI_membered x, int y)
		{
			return new Call(bit.duo.op.Eq.Singleton, x, y);
		}

		

		static public Call CreateEq(int x, E y)
		{
			return new Call(bit.duo.op.Eq.Singleton, x, y);
		}
		static public Call CreateEq(int x, V y)
		{
			return new Call(bit.duo.op.Eq.Singleton, x, y);
		}

		static public Call CreateEq(V x, int y)
		{
			return new Call(bit.duo.op.Eq.Singleton, x, y);
		}


		public static ExprI_membered CreateNe(VarI1 x, int y)
		{
			return CreateNe(
				new VarAsExpr(x)
				,

				nilnul.bit.X.Fro(y)
			);

			throw new NotImplementedException();
		}
		public static ExprI_membered CreateNe(ExprI_membered x, bool y)
		{
			return CreateNe(
				x
				,

				new nilnul.bit.expr.no.Call(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI_membered CreateNe(VarI1 x, bool y)
		{
			return CreateNe(
				new VarAsExpr(x)
				,

				new nilnul.bit.expr.no.Call(y)
			);

			throw new NotImplementedException();
		}
		public static ExprI_membered CreateImply(E x, E y)
		{
			return new Call(
				nilnul.bit.duo.op.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static ExprI_membered CreateImply(int x, V y)
		{
			return new Call(
				nilnul.bit.duo.op.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI_membered CreateImply(int x, E y)
		{
			return new Call(
				nilnul.bit.duo.op.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}




		public static ExprI_membered CreateImply(E x, V y)
		{
			return new Call(
				nilnul.bit.duo.op.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI_membered CreateImply(V x, V y)
		{
			return new Call(
				nilnul.bit.duo.op.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI_membered CreateNi(V x, V y)
		{
			return new Call(
				nilnul.bit.duo.op.Ni.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI_membered CreateNi(E x, V y)
		{
			return new Call(
				nilnul.bit.duo.op.Ni.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI_membered CreateNi(V x, E y)
		{
			return new Call(
				nilnul.bit.duo.op.Ni.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static ExprI_membered CreateImply(V x, E y)
		{
			return CreateImply( new VarAsExpr( x)  ,y );

			throw new NotImplementedException();
		}




		public static ExprI_membered CreateMa(E x, E y)
		{
			return new Call(
				nilnul.bit.duo.op.Ma.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI_membered CreateMa(E x, Var2 y)
		{
			return new Call(
				nilnul.bit.duo.op.Ma.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI_membered CreateMa(Var2 x, E y)
		{
			return new Call(
				nilnul.bit.duo.op.Ma.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static ExprI_membered CreateMa(VarI1 x, VarI1 y)
		{
			return CreateMa(
				new VarAsExpr(x)
				,
				new VarAsExpr(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI_membered CreateNe(ExprI_membered x, VarI1 y)
		{

			return CreateNe(
				x
				,
				new VarAsExpr(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI_membered CreateNe(VarI1 x, ExprI_membered y)
		{



			return CreateNe(
					new VarAsExpr(x),
				y

			);

			throw new NotImplementedException();
		}



		internal static ExprI_membered CreateNe(bool x, VarI1 y)
		{

			return CreateNe(
				 new nilnul.bit.expr.no.Call(x),


					new VarAsExpr(y)


			);

			throw new NotImplementedException();
		}

		public static ExprI_membered CreateMi(ExprI_membered x, VarI1 y)
		{

			return CreateMi(
				 x
				 ,
					new VarAsExpr(y)


			);

			throw new NotImplementedException();
		}



		public static ExprI_membered CreateMi(V x, E y)
		{

			return CreateMi(
				   new VarAsExpr( x)
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static ExprI_membered CreateMi(V x, V y)
		{

			return CreateMi(
				   new VarAsExpr( x)
				 ,
					y


			);

			throw new NotImplementedException();
		}



		public static ExprI_membered CreateMi(ExprI_membered x, ExprI_membered y)
		{

			return new Call(
				nilnul.bit.duo.op.Mi.Instance,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}
	}

}
