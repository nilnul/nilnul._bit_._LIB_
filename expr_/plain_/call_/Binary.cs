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
using E = nilnul.bit.expr_.PlainI;

namespace nilnul.bit.expr_.plain_.call_
{

	public class Binary
	:
	nilnul.obj.call_._binary_.OpArgArg1A<bit.op_.BinaryI1, nilnul.bit.expr_.PlainI, nilnul.bit.expr_.PlainI>
		,
	nilnul.bit.expr_.plain_.call_.BinaryI


	{
		public Binary(
			bit.op_.BinaryI1 op,
				bit.expr_.PlainI x, int y
		)
			: this(op, x, nilnul.bit.X.Fro(y))
		{

		}
		public Binary(
			bit.op_.BinaryI1 op,
				int x, E y
		)
			: this(op, nilnul.bit.X.Fro(x), y)
		{

		}
		public Binary(
			bit.op_.BinaryI1 op,
				int x, V y
		)
			: this(op, nilnul.bit.X.Fro(x), new nilnul.bit.expr_.plain_.Var( y))
		{

		}

		public Binary(
						bit.op_.BinaryI1 op,
					bit.expr_.PlainI x, bool y

			)
			: this(
				 op, x, new nilnul.bit.expr_.plain_.call_.Nary(y)
				 )
		{

		}

		public Binary(
						bit.op_.BinaryI1 op,
					bool x,E y

			)
			: this(
				 op, new nilnul.bit.expr_.plain_.call_.Nary( x), (y)
				 )
		{

		}


		public Binary(
			bit.op_.BinaryI1 op,
				bit.expr_.PlainI x, bit.expr_.PlainI y
		)
			: base(op, x, y)
		{

		}

		public Binary(
				bit.op_.BinaryI1 op,
					bit.expr_.PlainI x, bit.VarI1 y
			)
				:
			this(op,
					x, new expr_.plain_.Var(y)
				)
		{

		}

		public Binary(
				bit.op_.BinaryI1 op,
					bit.VarI1 x, bit.expr_.PlainI y
			)
				:
			this(op,
					new expr_.plain_.Var(x), y
				)
		{

		}


		public Binary(
			bit.op_.BinaryI1 op,

			bit.VarI1 x, bit.VarI1 y

			)
			: this(op,
				new expr_.plain_.Var(x), new expr_.plain_.Var(y)
			)
		{

		}

		public Binary(
			bit.op_.BinaryI1 op,

			bit.VarI1 x, int y

			)
			: this(op,
				new expr_.plain_.Var(x), 
				expr_.plain_.call_.Nary.Create(y)

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

		



		public bit.expr_.PlainI substitute(bit.VarI1 var, bit.expr_.PlainI expr)
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
			if (arg is expr_.plain_.call_.BinaryI)
			{

				var argAsDuo = arg as expr_.plain_.call_.BinaryI;
				
				if (op_.binary.re_.Priority1.Instance.re(argAsDuo.op, this.op))
				{
				}
				else
				{
					argTxt = $"({argTxt})";
				}


			}
			

			string arg1Txt = arg1.ToString();

			if (arg1 is expr_.plain_.call_.BinaryI)
			{

				var arg1AsDuo = arg1 as expr_.plain_.call_.BinaryI;
				
				if (op_.binary.re_.Priority1.Instance.re( this.op, arg1AsDuo.op))
				{
					arg1Txt = $"({arg1Txt})";

				}
				
			}
		

			
			return $"{argTxt }{op}{arg1Txt}";
		}

		static public Binary CreateNe(PlainI x, PlainI y)
		{
			return new Binary(bit.op_.binary_.Xor.Singleton, x, y);
		}

		static public Binary CreateNe(VarI1 x, V y)
		{
			return new Binary(bit.op_.binary_.Xor.Singleton, x, y);
		}

		static public Binary CreateEq(PlainI x, PlainI y)
		{
			return new Binary(bit.op_.binary_.Iff.Singleton, x, y);
		}

		static public Binary CreateEq(PlainI x, V y)
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


		static public Binary CreateEq(PlainI x, int y)
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


		public static PlainI CreateNe(VarI1 x, int y)
		{
			return CreateNe(
				new expr_.plain_.Var(x)
				,

				nilnul.bit.X.Fro(y)
			);

			//throw new NotImplementedException();
		}
		public static PlainI CreateNe(PlainI x, bool y)
		{
			return CreateNe(
				x
				,

				new nilnul.bit.expr_.plain_.call_.Nary(y)
			);

			//throw new NotImplementedException();
		}

		public static PlainI CreateNe(VarI1 x, bool y)
		{
			return CreateNe(
				new expr_.plain_.Var(x)
				,

				new nilnul.bit.expr_.plain_.call_.Nary(y)
			);

			//throw new NotImplementedException();
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

		public static PlainI CreateImply(int x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static PlainI CreateImply(int x, E y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}




		public static PlainI CreateImply(E x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}


		public static PlainI CreateImply(V x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Imply.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static PlainI CreateNi(V x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Nand.Singleton,
				(x)
				,
				(y)
			);

			//throw new NotImplementedException();
		}

		public static PlainI CreateNi(E x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Nand.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}

		public static PlainI CreateNi(V x, E y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Nand.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static PlainI CreateImply(V x, E y)
		{
			return CreateImply( new expr_.plain_.Var( x)  ,y );

			throw new NotImplementedException();
		}




		public static PlainI CreateMa(E x, E y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static PlainI CreateMa(E x, V y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}


		public static PlainI CreateMa(V x, E y)
		{
			return new Binary(
				nilnul.bit.op_.binary_.Or.Singleton,
				(x)
				,
				(y)
			);

			throw new NotImplementedException();
		}



		public static PlainI CreateMa(VarI1 x, VarI1 y)
		{
			return CreateMa(
				new expr_.plain_.Var(x)
				,
				new expr_.plain_.Var(y)
			);

			throw new NotImplementedException();
		}

		public static PlainI CreateNe(PlainI x, VarI1 y)
		{

			return CreateNe(
				x
				,
				new expr_.plain_.Var(y)
			);

			throw new NotImplementedException();
		}


		public static PlainI CreateNe(VarI1 x, PlainI y)
		{



			return CreateNe(
					new expr_.plain_.Var(x),
				y

			);

			throw new NotImplementedException();
		}



		internal static PlainI CreateNe(bool x, VarI1 y)
		{

			return CreateNe(
				 new nilnul.bit.expr_.plain_.call_.Nary(x),


					new expr_.plain_.Var(y)


			);

			throw new NotImplementedException();
		}

		public static PlainI CreateMi(PlainI x, VarI1 y)
		{

			return CreateMi(
				 x
				 ,
					new expr_.plain_.Var(y)


			);

			throw new NotImplementedException();
		}



		public static Binary CreateMi(V x, E y)
		{

			return CreateMi(
				   new expr_.plain_.Var( x)
				 ,
					y


			);

			throw new NotImplementedException();
		}

		public static PlainI CreateMi(V x, V y)
		{

			return CreateMi(
				   new expr_.plain_.Var( x)
				 ,
					y


			);

			throw new NotImplementedException();
		}



		public static Binary CreateMi(PlainI x, E y)
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
				nilnul.bit.expr_.plain_.call_.Nary.Create(v)
				,
				a
			);
			throw new NotImplementedException();
		}

		public static E CreateEq(E expr, bool v)
		{
			return CreateEq(expr, new nilnul.bit.expr_.plain_.call_.Nary(v));
			throw new NotImplementedException();
		}

		public static E CreateImply(V a, bool v)
		{
			return CreateImply(a, new nilnul.bit.expr_.plain_.call_.Nary(v));
			throw new NotImplementedException();
		}
	}

}
