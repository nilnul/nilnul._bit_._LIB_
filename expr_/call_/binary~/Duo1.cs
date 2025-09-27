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

namespace nilnul.bit.expr_.call_
{
	[Obsolete(nameof(Binary))]
	public class Duo1
	:
	nilnul.obj.call_.Duo<bit.CombineI, nilnul.bit.ExprI1, nilnul.bit.ExprI1>
		,
	nilnul.bit.expr_.call_.DuoI


	{
		public Duo1(
			bit.CombineI op,
				bit.ExprI1 x, int y
		)
			: this(op, x, nilnul.bit.X.Fro(y))
		{

		}
		public Duo1(
			bit.CombineI op,
				int x, E y
		)
			: this(op, nilnul.bit.X.Fro(x), y)
		{

		}
		public Duo1(
			bit.CombineI op,
				int x, V y
		)
			: this(op, nilnul.bit.X.Fro(x), new nilnul.bit.expr_.VarAsExpr( y))
		{

		}

		public Duo1(
						bit.CombineI op,
					bit.ExprI1 x, bool y

			)
			: this(
				 op, x, new nilnul.bit.expr_.call_.No(y)
				 )
		{

		}

		public Duo1(
						bit.CombineI op,
					bool x,E y

			)
			: this(
				 op, new nilnul.bit.expr_.call_.No( x), (y)
				 )
		{

		}


		public Duo1(
			bit.CombineI op,
				bit.ExprI1 x, bit.ExprI1 y
		)
			: base(op, x, y)
		{

		}

		public Duo1(
				bit.CombineI op,
					bit.ExprI1 x, bit.VarI1 y
			)
				:
			this(op,
					x, new expr_.VarAsExpr(y)
				)
		{

		}

		public Duo1(
				bit.CombineI op,
					bit.VarI1 x, bit.ExprI1 y
			)
				:
			this(op,
					new expr_.VarAsExpr(x), y
				)
		{

		}


		public Duo1(
			bit.CombineI op,

			bit.VarI1 x, bit.VarI1 y

			)
			: this(op,
				new expr_.VarAsExpr(x), new expr_.VarAsExpr(y)
			)
		{

		}

		public Duo1(
			bit.CombineI op,

			bit.VarI1 x, int y

			)
			: this(op,
				new expr_.VarAsExpr(x), 
				expr.call_.No.Create(y)

			)
		{

		}



		public bit.var.Set1 vars
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
			return new Duo1(
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

			if (argReduced is call_.No && arg1Reduced is call_.No)
			{
				return new call_.No(
					op.eval(

						(argReduced as call_.No).op.result
						,
						(arg1Reduced as call_.No).op.result
					)

				);
			}
			else
			{
				return new Duo1(
					op
					,
					argReduced, arg1Reduced
				);
			}

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			string  argTxt=arg.ToString();
			if (arg is expr_.call_.Duo1)
			{

				var argAsDuo = arg as expr_.call_.Duo1;
				
				if (combine.re_.Priority.Instance.re(argAsDuo.op, this.op))
				{
				}
				else
				{
					argTxt = $"({argTxt})";
				}


			}
			

			string arg1Txt = arg1.ToString();

			if (arg1 is expr_.call_.Duo1)
			{

				var arg1AsDuo = arg1 as expr_.call_.Duo1;
				
				if (combine.re_.Priority.Instance.re( this.op, arg1AsDuo.op))
				{
					arg1Txt = $"({arg1Txt})";

				}
				
			}
		

			
			return $"{argTxt }{op}{arg1Txt}";
		}

		static public Duo1 CreateNe(ExprI1 x, ExprI1 y)
		{
			return new Duo1(bit.combine_.Ne.Singleton, x, y);
		}

		static public Duo1 CreateNe(VarI1 x, V y)
		{
			return new Duo1(bit.combine_.Ne.Singleton, x, y);
		}

		static public Duo1 CreateEq(ExprI1 x, ExprI1 y)
		{
			return new Duo1(bit.combine_.Eq.Singleton, x, y);
		}

		static public Duo1 CreateEq(ExprI1 x, V y)
		{
			return new Duo1(bit.combine_.Eq.Singleton, x, y);
		}
		static public Duo1 CreateEq(V x, E y)
		{
			return new Duo1(bit.combine_.Eq.Singleton, x, y);
		}


		static public Duo1 CreateEq(V x, V y)
		{
			return new Duo1(bit.combine_.Eq.Singleton, x, y);
		}


		static public Duo1 CreateEq(ExprI1 x, int y)
		{
			return new Duo1(bit.combine_.Eq.Singleton, x, y);
		}

		

		static public Duo1 CreateEq(int x, E y)
		{
			return new Duo1(bit.combine_.Eq.Singleton, x, y);
		}
		static public Duo1 CreateEq(int x, V y)
		{
			return new Duo1(bit.combine_.Eq.Singleton, x, y);
		}

		static public Duo1 CreateEq(V x, int y)
		{
			return new Duo1(bit.combine_.Eq.Singleton, x, y);
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
		public static Duo1 CreateImply(E x, E y)
		{
			return new Duo1(
				nilnul.bit.combine_.Le.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static ExprI1 CreateImply(int x, V y)
		{
			return new Duo1(
				nilnul.bit.combine_.Le.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static ExprI1 CreateImply(int x, E y)
		{
			return new Duo1(
				nilnul.bit.combine_.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}




		public static ExprI1 CreateImply(E x, V y)
		{
			return new Duo1(
				nilnul.bit.combine_.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI1 CreateImply(V x, V y)
		{
			return new Duo1(
				nilnul.bit.combine_.Le.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateNi(V x, V y)
		{
			return new Duo1(
				nilnul.bit.combine_.Nand.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateNi(E x, V y)
		{
			return new Duo1(
				nilnul.bit.combine_.Nand.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateNi(V x, E y)
		{
			return new Duo1(
				nilnul.bit.combine_.Nand.Singleton,
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
			return new Duo1(
				nilnul.bit.combine_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI1 CreateMa(E x, V y)
		{
			return new Duo1(
				nilnul.bit.combine_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI1 CreateMa(V x, E y)
		{
			return new Duo1(
				nilnul.bit.combine_.Or.Singleton,
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
				 new nilnul.bit.expr_.call_.No(x),


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



		public static Duo1 CreateMi(V x, E y)
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



		public static Duo1 CreateMi(ExprI1 x, ExprI1 y)
		{

			return new Duo1(
				nilnul.bit.combine_.And.Instance,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}
		public static ExprI1 CreateAnd(ExprI1 x, ExprI1 y)
		{

			return new Duo1(
				nilnul.bit.combine_.And.Instance,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static ExprI1 CreateAnd(V x, ExprI1 y)
		{

			return new Duo1(
				nilnul.bit.combine_.And.Instance,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static E CreateImply(bool v, V a)
		{
			return CreateImply(
				nilnul.bit.expr_.call_.No.Create(v)
				,
				a
			);
			throw new NotImplementedException();
		}

		public static E CreateEq(E expr, bool v)
		{
			return CreateEq(expr, new nilnul.bit.expr_.call_.No(v));
			throw new NotImplementedException();
		}

		public static E CreateImply(V a, bool v)
		{
			return CreateImply(a, new nilnul.bit.expr_.call_.No(v));
			throw new NotImplementedException();
		}
	}

}
