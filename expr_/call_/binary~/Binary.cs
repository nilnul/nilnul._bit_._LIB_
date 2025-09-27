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
using E = nilnul.bit.ExprI2;

namespace nilnul.bit.expr_.call_
{

	[Obsolete()]
	public class Binary
	:
	nilnul.obj.call_.Duo<bit.op_.BinaryI, nilnul.bit.ExprI2, nilnul.bit.ExprI2>
		,
	nilnul.bit.expr_.call_.BinaryI


	{
		public Binary(
			bit.op_.BinaryI op,
				bit.ExprI2 x, int y
		)
			: this(op, x, nilnul.bit.X.Fro(y))
		{

		}
		public Binary(
			bit.op_.BinaryI op,
				int x, E y
		)
			: this(op, nilnul.bit.X.Fro(x), y)
		{

		}
		public Binary(
			bit.op_.BinaryI op,
				int x, V y
		)
			: this(op, nilnul.bit.X.Fro(x), new nilnul.bit.expr_.Var( y))
		{

		}

		public Binary(
						bit.op_.BinaryI op,
					bit.ExprI2 x, bool y

			)
			: this(
				 op, x, new nilnul.bit.expr_.call_.Nulary1(y)
				 )
		{

		}

		public Binary(
						bit.op_.BinaryI op,
					bool x,E y

			)
			: this(
				 op, new nilnul.bit.expr_.call_.Nulary1( x), (y)
				 )
		{

		}


		public Binary(
			bit.op_.BinaryI op,
				bit.ExprI2 x, bit.ExprI2 y
		)
			: base(op, x, y)
		{

		}

		public Binary(
				bit.op_.BinaryI op,
					bit.ExprI2 x, bit.VarI1 y
			)
				:
			this(op,
					x, new expr_.Var(y)
				)
		{

		}

		public Binary(
				bit.op_.BinaryI op,
					bit.VarI1 x, bit.ExprI2 y
			)
				:
			this(op,
					new expr_.Var(x), y
				)
		{

		}


		public Binary(
			bit.op_.BinaryI op,

			bit.VarI1 x, bit.VarI1 y

			)
			: this(op,
				new expr_.Var(x), new expr_.Var(y)
			)
		{

		}

		public Binary(
			bit.op_.BinaryI op,

			bit.VarI1 x, int y

			)
			: this(op,
				new expr_.Var(x), 
				expr_.call_.Nulary1.Create(y)

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

		



		public bit.ExprI2 substitute(bit.VarI1 var, bit.ExprI2 expr)
		{
			return new Binary(
				this.op,
				(arg ).substitute(var, expr),
				(arg1).substitute(var, expr)

		);
			//throw new NotImplementedException();
		}


		public override string ToString()
		{
			string  argTxt=arg.ToString();
			if (arg is expr_.call_.BinaryI)
			{

				var argAsDuo = arg as expr_.call_.BinaryI;
				
				if (op_.binary.re_.Priority.Instance.re(argAsDuo.op, this.op))
				{
				}
				else
				{
					argTxt = $"({argTxt})";
				}


			}
			

			string arg1Txt = arg1.ToString();

			if (arg1 is expr_.call_.Binary)
			{

				var arg1AsDuo = arg1 as expr_.call_.Binary;
				
				if (op_.binary.re_.Priority.Instance.re( this.op, arg1AsDuo.op))
				{
					arg1Txt = $"({arg1Txt})";

				}
				
			}
		

			
			return $"{argTxt }{op}{arg1Txt}";
		}

		static public Binary CreateNe(ExprI2 x, ExprI2 y)
		{
			return new Binary(bit.op_.binary_.Xor.Singleton, x, y);
		}

		static public Binary CreateNe(VarI1 x, V y)
		{
			return new Binary(bit.op_.binary_.Xor.Singleton, x, y);
		}

		static public Binary CreateEq(ExprI2 x, ExprI2 y)
		{
			return new Binary(bit.op_.binary_.Iff.Singleton, x, y);
		}

		static public Binary CreateEq(ExprI2 x, V y)
		{
			return new Binary(bit.op_.binary_.Iff.Singleton, x, y);
		}
		static public Binary CreateEq(V x, E y)
		{
			return new Binary(bit.op_.binary_.Iff.Singleton, x, y);
		}


		static public Binary CreateEq(V x, V y)
		{
			return new Binary(bit.op_.binary_.Iff.Singleton, x, y);
		}


		static public Binary CreateEq(ExprI2 x, int y)
		{
			return new Binary(bit.op_.binary_.Iff.Singleton, x, y);
		}

		

		static public Binary CreateEq(int x, E y)
		{
			return new Binary(bit.op_.binary_.Iff.Singleton, x, y);
		}
		static public Binary CreateEq(int x, V y)
		{
			return new Binary(bit.op_.binary_.Iff.Singleton, x, y);
		}

		static public Binary CreateEq(V x, int y)
		{
			return new Binary(bit.op_.binary_.Iff.Singleton, x, y);
		}


		public static ExprI2 CreateNe(VarI1 x, int y)
		{
			return CreateNe(
				new expr_.Var(x)
				,

				nilnul.bit.X.Fro(y)
			);

			//throw new NotImplementedException();
		}
		public static ExprI2 CreateNe(ExprI2 x, bool y)
		{
			return CreateNe(
				x
				,

				new nilnul.bit.expr_.call_.Nulary1(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI2 CreateNe(VarI1 x, bool y)
		{
			return CreateNe(
				new expr_.Var(x)
				,

				new nilnul.bit.expr_.call_.Nulary1(y)
			);

			throw new NotImplementedException();
		}
		public static Binary CreateImply(E x, E y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static ExprI2 CreateImply(int x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static ExprI2 CreateImply(int x, E y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}




		public static ExprI2 CreateImply(E x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI2 CreateImply(V x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI2 CreateNi(V x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Nand.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI2 CreateNi(E x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Nand.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI2 CreateNi(V x, E y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Nand.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static ExprI2 CreateImply(V x, E y)
		{
			return CreateImply( new expr_.Var( x)  ,y );

			throw new NotImplementedException();
		}




		public static ExprI2 CreateMa(E x, E y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI2 CreateMa(E x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI2 CreateMa(V x, E y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static ExprI2 CreateMa(VarI1 x, VarI1 y)
		{
			return CreateMa(
				new expr_.Var(x)
				,
				new expr_.Var(y)
			);

			throw new NotImplementedException();
		}

		public static ExprI2 CreateNe(ExprI2 x, VarI1 y)
		{

			return CreateNe(
				x
				,
				new expr_.Var(y)
			);

			throw new NotImplementedException();
		}


		public static ExprI2 CreateNe(VarI1 x, ExprI2 y)
		{



			return CreateNe(
					new expr_.Var(x),
				y

			);

			throw new NotImplementedException();
		}



		internal static ExprI2 CreateNe(bool x, VarI1 y)
		{

			return CreateNe(
				 new nilnul.bit.expr_.call_.Nulary1(x),


					new expr_.Var(y)


			);

			throw new NotImplementedException();
		}

		public static ExprI2 CreateMi(ExprI2 x, VarI1 y)
		{

			return CreateMi(
				 x
				 ,
					new expr_.Var(y)


			);

			throw new NotImplementedException();
		}



		public static Binary CreateMi(V x, E y)
		{

			return CreateMi(
				   new expr_.Var( x)
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static ExprI2 CreateMi(V x, V y)
		{

			return CreateMi(
				   new expr_.Var( x)
				 ,
					y


			);

			throw new NotImplementedException();
		}



		public static Binary CreateMi(ExprI2 x, E y)
		{

			return new Binary(
				nilnul.bit.op_.binary_.And.Singleton,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}
		public static E  CreateAnd(E  x, E  y)
		{

			return new Binary(
				nilnul.bit.op_.binary_.And.Singleton,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static E CreateAnd(V x, E y)
		{

			return new Binary(
				nilnul.bit.op_.binary_.And.Singleton,

				 x
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static E CreateImply(bool v, V a)
		{
			return CreateImply(
				nilnul.bit.expr_.call_.Nulary1.Create(v)
				,
				a
			);
			throw new NotImplementedException();
		}

		public static E CreateEq(E expr, bool v)
		{
			return CreateEq(expr, new nilnul.bit.expr_.call_.Nulary1(v));
			throw new NotImplementedException();
		}

		public static E CreateImply(V a, bool v)
		{
			return CreateImply(a, new nilnul.bit.expr_.call_.Nulary1(v));
			throw new NotImplementedException();
		}
	}

}
