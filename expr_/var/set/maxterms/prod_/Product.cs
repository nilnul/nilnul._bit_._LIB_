using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.simpleSum.str.op
{
	public class Product
	{
		public class Call:nilnul._call.Call_ArgA<StrI>
		{
			public Call(StrI str):base(str)
			{

			}

			public Call(IEnumerable<bit.expr.simple.set.op.Disjunct.Call> simpleSums)
				:this(
					 new str.EnumerableAsStr(simpleSums)
				 )
			{



			}

			

			public Call(IEnumerable<bit.expr.simple.str.op.Disjunct.Call> str)
	: this(
		new str.EnumerableAsStr(str)
	 )
			{

			}


			public ExprI_membered toStati() {

				return arg.Aggregate(
					new bit.expr.no._one.Call()
					,
					(ExprI_membered a, simple.str.op.Disjunct.Call n)=>expr.duo.Min.Call(a, n.toStati())
				);


			}

			public override string ToString()
			{
				return $"{bit.str.op.Conjunct.SIGN}({arg.ToStr()})";
            }

		}


	}
}
