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

namespace nilnul.bit.expr.simple.str.op
{
	public class Disjunct
	{
		

		public class Call :
			nilnul._call.Call_ArgA<StrI>
			
		{


			

			public Call():base(new Empty())
			{

			}

			public Call(IEnumerable<ExprI_membered> exprs)
			: this(
				exprs.Select(x => new be.Simple.Asserted(x))
			 )
			{

			}

			public Call(IEnumerable<expr.be.Simple.Asserted> str) : base(new Str(str))
			{

			}

			public Call(StrI arg) : base(arg)
			{
			}

			public ExprI_membered toStati() {
				return _ToStati(this.arg.Select(x=>x.val));
			}


			static public ExprI_membered _ToStati(IEnumerable<ExprI_membered> str) {
				if (str.Count()==0)
				{
					return expr.no._zero.Call.Singleton;
				}
				else
				{
					return expr.duo.Max.Call(str.First(), _ToStati(str.Skip(1)));
				}


			}

			



			public nilnul.bit.var.stati.Set vars
			{
				get
				{
					return nilnul.bit.var.stati.set.str.op.Union._Eval(
						arg.Select(x=>((x.val) as nilnul.bit.expr.stati._stati.VarsI).vars)	
					);


					throw new NotImplementedException();
				}
			}

			
		}
	}
}
