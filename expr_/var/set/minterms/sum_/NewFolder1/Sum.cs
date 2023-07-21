using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.bit.expr.simpleProduct.str.op
{
	[Obsolete(nameof( nilnul.bit.expr_.var.set.minterms))]
	public class Sum
	{
		public class Call:nilnul.obj.op._call.ArgsA<bit.expr.simpleProduct.StrI>
		{
			public Call(StrI str):base(str)
			{

			}

			public Call(IEnumerable<bit.expr.simple.str.op.Conjunct.Call> str)
				:this(
					new str.EnumerableAsStr(str) 
				 )
			{

			}

			public Call(        
				IEnumerable<bit.expr.simple.set.op.Conjunct.Call> simpleProducts
				)
				: this(
					 new str.EnumerableAsStr(simpleProducts)
				 )
			{



			}



			public ExprI_membered toExpr()
			{

				return arg.Aggregate(
					new bit.expr.no._one.Call()
					,
					(ExprI_membered a, simple.str.op.Conjunct.Call n) => expr.duo.Max.Call(a, n.toStati())
				);



			}
			public override string ToString()
			{
				return $"{bit.str.summarize_._DisjunctX.SYMBOL}({arg.ToTxt()})";
            }
			




		}
	}
}
