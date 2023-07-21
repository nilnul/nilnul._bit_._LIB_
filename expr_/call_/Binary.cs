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
using E = nilnul.bit.ExprI3;

namespace nilnul.bit.expr_.call_
{

	public class Binary1
	:
	nilnul.obj.call_.Binary<bit.op_.BinaryI1, nilnul.bit.ExprI3, nilnul.bit.ExprI3>
		,
	nilnul.bit.expr_.call_.BinaryI1


	{
		public Binary1(
			bit.op_.BinaryI1 op,
				bit.ExprI3 x, bit.ExprI3 y
		)
			: base(op, x, y)
		{

		}

		public Binary1(
			bit.op_.BinaryI1 op,
				bit.expr.Co x
		)
			: base(op, x.Item1, x.Item2)
		{

		}

		public Binary1(
						bit.op_.BinaryI1 op,
					bit.ExprI3 x, bool y

			)
			: this(
				 op, x, new nilnul.bit.expr_.call_.Nary(y)
				 )
		{

		}



		public Binary1(
			bit.op_.BinaryI1 op,
				bit.ExprI3 x, int y
		)
			: this(op, x, nilnul.bit.X.Fro(y))
		{

		}
		public Binary1(
			bit.op_.BinaryI1 op,
				int x, E y
		)
			: this(op, nilnul.bit.X.Fro(x), y)
		{

		}
		public Binary1(
			bit.op_.BinaryI1 op,
				int x, V y
		)
			: this(op, nilnul.bit.X.Fro(x), new nilnul.bit.expr_.Var1( y))
		{

		}


		public Binary1(
						bit.op_.BinaryI1 op,
					bool x,E y

			)
			: this(
				 op, new nilnul.bit.expr_.call_.Nary( x), (y)
				 )
		{

		}


		public Binary1(
				bit.op_.BinaryI1 op,
					bit.ExprI3 x, bit.VarI1 y
			)
				:
			this(op,
					x, new expr_.Var1(y)
				)
		{

		}

		public Binary1(
				bit.op_.BinaryI1 op,
					bit.VarI1 x, bit.ExprI3 y
			)
				:
			this(op,
					new expr_.Var1(x), y
				)
		{

		}


		public Binary1(
			bit.op_.BinaryI1 op,

			bit.VarI1 x, bit.VarI1 y

			)
			: this(op,
				new expr_.Var1(x), new expr_.Var1(y)
			)
		{

		}

		public Binary1(
			bit.op_.BinaryI1 op,

			bit.VarI1 x, int y

			)
			: this(op,
				new expr_.Var1(x), 
				expr_.call_.Nary.Create(y)

			)
		{

		}



		public bit.var.Set2 vars
		{
			get
			{
				var r = new nilnul.bit.var.Set2();
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

		



		public bit.ExprI3 substitute(bit.VarI1 var, bit.ExprI3 expr)
		{
			return new Binary1(
				this.op,
				(arg ).substitute(var, expr),
				(arg1).substitute(var, expr)

		);
			//throw new NotImplementedException();
		}


		public override string ToString()
		{
			string  argTxt=arg.ToString();
			if (arg is expr_.call_.BinaryI1)
			{

				var argAsDuo = arg as expr_.call_.BinaryI1;
				
				if (op_.binary.re_.Priority1.Instance.re(argAsDuo.op, this.op))
				{
				}
				else
				{
					argTxt = $"({argTxt})";
				}


			}
			

			string arg1Txt = arg1.ToString();

			if (arg1 is expr_.call_.Binary1)
			{

				var arg1AsDuo = arg1 as expr_.call_.Binary1;
				
				if (op_.binary.re_.Priority1.Instance.re( this.op, arg1AsDuo.op))
				{
					arg1Txt = $"({arg1Txt})";

				}
				
			}
		

			
			return $"{argTxt }{op}{arg1Txt}";
		}

		static public Binary1 CreateNe(ExprI3 x, ExprI3 y)
		{
			return new Binary1(bit.op_.binary_.Xor.Singleton, x, y);
		}

		static public Binary1 CreateNe(VarI1 x, V y)
		{
			return new Binary1(bit.op_.binary_.Xor.Singleton, x, y);
		}

	

		static public Binary1 CreateEq(ExprI3 x, ExprI3 y)
		{
			return new Binary1(bit.op_.binary_.Iff.Singleton, x, y);
		}

		static public Binary1 CreateEq(ExprI3 x, V y)
		{
			return new Binary1(bit.op_.binary_.Iff.Singleton, x, y);
		}
		static public Binary1 CreateEq(V x, E y)
		{
			return new Binary1(bit.op_.binary_.Iff.Singleton, x, y);
		}


		static public Binary1 CreateEq(V x, V y)
		{
			return new Binary1(bit.op_.binary_.Iff.Singleton, x, y);
		}


		static public Binary1 CreateEq(ExprI3 x, int y)
		{
			return new Binary1(bit.op_.binary_.Iff.Singleton, x, y);
		}

		

		static public Binary1 CreateEq(int x, E y)
		{
			return new Binary1(bit.op_.binary_.Iff.Singleton, x, y);
		}
		static public Binary1 CreateEq(int x, V y)
		{
			return new Binary1(bit.op_.binary_.Iff.Singleton, x, y);
		}

		static public Binary1 CreateEq(V x, int y)
		{
			return new Binary1(bit.op_.binary_.Iff.Singleton, x, y);
		}


		public static ExprI3 CreateNe(VarI1 x, int y)
		{
			return CreateNe(
				new expr_.Var1(x)
				,

				nilnul.bit.X.Fro(y)
			);

			//throw new NotImplementedException();
		}
		public static ExprI3 CreateNe(ExprI3 x, bool y)
		{
			return CreateNe(
				x
				,

				new nilnul.bit.expr_.call_.Nary(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI3 CreateNe(VarI1 x, bool y)
		{
			return CreateNe(
				new expr_.Var1(x)
				,

				new nilnul.bit.expr_.call_.Nary(y)
			);

			throw new NotImplementedException();
		}
		public static Binary1 CreateImply(E x, E y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static ExprI3 CreateImply(int x, V y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static ExprI3 CreateImply(int x, E y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}




		public static ExprI3 CreateImply(E x, V y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI3 CreateImply(V x, V y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI3 CreateNi(V x, V y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Nand.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI3 CreateNi(E x, V y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Nand.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI3 CreateNi(V x, E y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Nand.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static ExprI3 CreateImply(V x, E y)
		{
			return CreateImply( new expr_.Var1( x)  ,y );

			throw new NotImplementedException();
		}




		public static ExprI3 CreateMa(E x, E y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI3 CreateMa(E x, Var1 y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI3 CreateMa(Var1 x, E y)
		{
			return new Binary1(
				nilnul.bit.op_.binary_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static ExprI3 CreateMa(VarI1 x, VarI1 y)
		{
			return CreateMa(
				(E)new expr_.Var1(x)
				,
				(E)new expr_.Var1(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI3 CreateNe(ExprI3 x, VarI1 y)
		{

			return CreateNe(
				x
				,
				new expr_.Var1(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI3 CreateNe(VarI1 x, ExprI3 y)
		{



			return CreateNe(
					new expr_.Var1(x),
				y

			);

			throw new NotImplementedException();
		}



		internal static ExprI3 CreateNe(bool x, VarI1 y)
		{

			return CreateNe(
				 new nilnul.bit.expr_.call_.Nary(x),


					new expr_.Var1(y)


			);

			throw new NotImplementedException();
		}

		public static ExprI3 CreateMi(ExprI3 x, VarI1 y)
		{

			return CreateMi(
				 x
				 ,
					new expr_.Var1(y)


			);

			throw new NotImplementedException();
		}



		public static Binary1 CreateMi(V x, E y)
		{

			return CreateMi(
				   new expr_.Var1( x)
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static ExprI3 CreateMi(V x, V y)
		{

			return CreateMi(
				   new expr_.Var1( x)
				 ,
					y


			);

			throw new NotImplementedException();
		}



		public static Binary1 CreateMi(ExprI3 x, E y)
		{

			return new Binary1(
				nilnul.bit.op_.binary_.And.Singleton,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}
		public static E  CreateAnd(E  x, E  y)
		{

			return new Binary1(
				nilnul.bit.op_.binary_.And.Singleton,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static E CreateAnd(V x, E y)
		{

			return new Binary1(
				nilnul.bit.op_.binary_.And.Singleton,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static E CreateImply(bool v, Var1 a)
		{
			return CreateImply(
				nilnul.bit.expr_.call_.Nary.Create(v)
				,
				a
			);
			throw new NotImplementedException();
		}

		public static E CreateEq(E expr, bool v)
		{
			return CreateEq(expr, new nilnul.bit.expr_.call_.Nary(v));
			throw new NotImplementedException();
		}

		public static E CreateImply(Var1 a, bool v)
		{
			return CreateImply(a, new nilnul.bit.expr_.call_.Nary(v));
			throw new NotImplementedException();
		}
	}

}
