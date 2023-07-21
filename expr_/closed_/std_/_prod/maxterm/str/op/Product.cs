using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.simpleSum.str.op
{
	public class Product
	{
		public class Call:nilnul.obj.op._call.ArgsA<StrI>
		{
			public Call(StrI str):base(str)
			{

			}

			public Call(IEnumerable<bit.expr.stati.simple.str.op.Disjunct.Call> str)
	: this(
		new str.EnumerableAsStr(str)
	 )
			{

			}


			public StatiI toStati() {

				return arg.Aggregate(
					new bit.expr.stati.no._one.Call()
					,
					(StatiI a, simple.str.op.Disjunct.Call n)=>expr.stati.duo.Min.Call(a, n.toStati())
				);


			}

			public override string ToString()
			{
				return $"{bit.str.op.And.SIGN}({arg.ToStr()})";
            }

		}


	}
}
