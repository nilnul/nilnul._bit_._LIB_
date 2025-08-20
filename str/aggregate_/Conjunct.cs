/*extern alias obj;*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj;
using nilnul.str.seed;
using nilnul.obj.seq;

namespace nilnul.bit.str.aggregate_
{
	public   class Conjunct:AggregateI
	{
		static public bool Eval(IEnumerable<bool> elements) {

			if (elements.Any())
			{
				return elements.First() & Eval(elements.Skip(1));
				
			}
			else
			{
				return true;
			}
		
		}
		static public bool Eval_byUnitaryRecur(IEnumerable<bool> elements) {

			return elements.None() ? true : elements.First() && Eval_byUnitaryRecur(elements.Tail());
		
		}

		static public bool Eval(params bool[] elements) {
			return Eval(elements as IEnumerable<bool> );
		}
		public override string ToString()
		{
			return "Pi";
		}

		public bool eval(StrI1 arg)
		{
			if (arg is nilnul.obj.str_.Sans<bool>)
			{
				return true;
			}
			var started = arg as nilnul.obj.str_.StartedI<bool>;
			return started.head && eval( started.tail);

			//throw new NotImplementedException();
		}

		private bool eval(obj.StrI<bool> arg)
		{
			if (arg is nilnul.obj.str_.Sans<bool>)
			{
				return true;
			}
			var started = arg as nilnul.obj.str_.StartedI<bool>;
			return started.head && eval( started.tail);

			//throw new NotImplementedException();
		}

		public const string SIGN = "PI";



	}
}
