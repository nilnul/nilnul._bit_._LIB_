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

namespace nilnul.bit.expr.stati.simple.str.op
{
	public class Disjunct
	{
		

		public class Call :
			nilnul.obj.op._call.ArgsA<StrI>
			
		{


			public Call(StrI str):base(str)
			{

			}

			public Call():base(new Empty())
			{

			}

			public Call(IEnumerable<StatiI> exprs)
	: this(
		exprs.Select(x => new be.Simple.Asserted(x))
	 )
			{

			}

			public Call(IEnumerable<expr.stati.be.Simple.Asserted> str) : base(new Str(str))
			{

			}






			public StatiI toStati() {
				return _ToStati(this.arg.Select(x=>x.val));
			}


			static public StatiI _ToStati(IEnumerable<StatiI> str) {
				if (str.Count()==0)
				{
					return stati.no._zero.Call.Singleton;
				}
				else
				{
					return stati.duo.Max.Call(str.First(), _ToStati(str.Skip(1)));
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
