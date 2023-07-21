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
	public class Disjunct
	{
		

		public class Call :
			nilnul._call.Call_ArgA<Set>
			
		{


			public Call(Set str):base(str)
			{

			}

			public Call():base(new Set())
			{

			}

			public Call(IEnumerable<ExprI_membered> exprs)
	: this(
		exprs.Select(x => new be.Simple.Asserted(x))
	 )
			{

			}

			public Call(IEnumerable<expr.be.Simple.Asserted> str) : base(new Set(str))
			{

			}






			public ExprI_membered toQuadratic() {
				return _ToQuadratic(this.arg.Select(x=>x.val));
			}


			static public ExprI_membered _ToQuadratic(IEnumerable<ExprI_membered> str) {
				if (str.Count()==0)
				{
					return expr.no._zero.Call.Singleton;
				}
				else
				{
					return expr.duo.Max.Call(str.First(), _ToQuadratic(str.Skip(1)));
				}


			}

			



			public nilnul.bit.var.Set vars
			{
				get
				{
					return nilnul.bit.var.set.str.op.Union._Eval(
						arg.Select(x=>((x.val) as _expr.VarsI).vars)	
					);


					throw new NotImplementedException();
				}
			}

			
		}
	}
}
