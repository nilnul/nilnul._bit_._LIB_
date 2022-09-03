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
using nilnul.str;

namespace nilnul.bit.expr.simple.str.op
{
	public class Conjunct
	{
		

		public class Call :
			nilnul._call.Call_ArgA<StrI>
			
		{


			public Call(StrI str):base(str)
			{

			}

			public Call(IEnumerable<VarI1> exprs)
				:this(
					exprs.Select(x=>new be.Simple.Asserted(x)) 
				 )
			{

			}

			public Call(IEnumerable<expr.be.Simple.Asserted> str):base( new expr.simple.Str( str))
			{

			}



			public Call(IEnumerable<ExprI_membered> exprs)
			: this(
				exprs.Select(x => new be.Simple.Asserted(x))
			 )
			{

			}




			public ExprI_membered toStati()
			{
				return _ToExpr(this.arg.Select(x => x.val));
			}


			public override string ToString()
			{
				return $"{bit.str.op.Conjunct.SIGN}({arg.ToTxt()})";
            }


			static public bit.ExprI_membered _ToExpr(IEnumerable<bit.ExprI_membered> str) {
				if (str.Count()==0)
				{
					return expr.no._one.Call.Singleton;
				}
				else
				{
					return expr.duo.Min.Call(str.First(), _ToExpr(str.Skip(1)));
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
