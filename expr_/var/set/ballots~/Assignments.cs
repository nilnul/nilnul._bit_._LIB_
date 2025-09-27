using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.toset
{
	public class Assignments
	{
		private nilnul.bit.var.stati.str.be.Distinct.Asserted _vars;

		public nilnul.bit.var.stati.str.be.Distinct.Asserted vars
		{
			get { return _vars; }
			private set { _vars = value; }
		}

		static public IEnumerable<IEnumerable<bool>> Enumerate(bit.var.stati.str.be.Distinct.Asserted vars) {
			return _Enumerate(vars.val);
		}


		static public IEnumerable<IEnumerable<bool>> _Enumerate(IEnumerable<bit.var.stati.Stati> _distinct)
		{

			if (_distinct.Count() == 0)
			{
				yield return new bool[0];
				yield break;

			}

			//var firstVar = _distinct.First();

#if DEBUG
			var enumed = _Enumerate(
					_distinct.Skip(1).ToList()
				).ToList();

			foreach (
				var item in
				enumed

			)
			{
				yield return nilnul.seq.Head.Eval(false, item);
				yield return nilnul.seq.Head.Eval(true, item);

			}


#else

			foreach (
				var item in
				_Enumerate(
					_distinct.Skip(1).ToList()
				)

			)
			{
				yield return nilnul.seq.Head.Eval(false, item);
				yield return nilnul.seq.Head.Eval(true, item);

			}
#endif

		}



	}
}
