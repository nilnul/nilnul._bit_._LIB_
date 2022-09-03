using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.obj.expr;
using nilnul.obj.expr.stati._stati;
using nilnul.obj.var.stati;

namespace nilnul.bit.expr.simple.set.op
{
	public class Conjunct
	{


		public class Call :
			nilnul._call.ArgA<Set>

		{


			public Call(Set str) : base(str)
			{

			}

			public Call(IEnumerable<VarI1> exprs)
				: this(
					exprs.Select(x => new be.Simple.Asserted(x))
				 )
			{

			}

			public Call(IEnumerable<expr.be.Simple.Asserted> str) : base(new expr.simple.Set(str))
			{

			}

			static public Call Create(IEnumerable<ExprI_membered> str)
			{
				return new Call(
						str.Select(x => new be.Simple.Asserted(x)
					 )
				);
			}


			public ExprI_membered toQuadratic()
			{
				return _ToQuadratic(this.arg.Select(x => x.val));
			}


			public override string ToString()
			{
				return $"{bit.str.op.And.SIGN}({arg.ToStr()})";
			}


			static public bit.ExprI_membered _ToQuadratic(IEnumerable<bit.ExprI_membered> str)
			{
				if (str.Count() == 0)
				{
					return expr.no._one.Call.Singleton;
				}
				else
				{
					return expr.duo.Min.Call(str.First(), _ToQuadratic(str.Skip(1)));
				}


			}





			public nilnul.bit.var.Set vars
			{
				get
				{
					return nilnul.bit.var.set.str.op.Union._Eval(
						arg.Select(x => ((x.val) as _expr.VarsI).vars)
					);


					throw new NotImplementedException();
				}
			}


		}
	}
}
