using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.simpleProduct.str.op
{
	public class Sum
	{
		public class Call:nilnul.obj.op._call.ArgsA<bit.expr.stati.simpleProduct.StrI>
		{
			public Call(StrI str):base(str)
			{

			}

			public Call(IEnumerable<bit.expr.stati.simple.str.op.Conjunct.Call> str)
				:this(
					new str.EnumerableAsStr(str) 
				 )
			{

			}

			public StatiI toStati()
			{

				return arg.Aggregate(
					new bit.expr.stati.no._one.Call()
					,
					(StatiI a, simple.str.op.Conjunct.Call n) => expr.stati.duo.Max.Call(a, n.toStati())
				);



			}
			public override string ToString()
			{
				return $"{bit.str.op.Or.SIGN}({arg.ToStr()})";
            }
			




		}
	}
}
