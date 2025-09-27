using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set
{
	[Obsolete(nameof(bit.expr_.var.set.IBallot))]

	public class StateX
	{


		/// <summary>
		/// polls;
		/// note the sequence must be constant.
		/// </summary>
		/// <param name="_distinct"></param>
		/// <returns></returns>
		[Obsolete(nameof(nilnul.bit.var.set.BallotsX))]
		static public IEnumerable<IEnumerable<bool>> _Enumerate(IEnumerable<bit.VarI1> _distinct)
		{

			if (_distinct.Count() == 0)
			{
				yield return new bool[0];
				yield break;    //this is important.

			}

			//var firstVar = _distinct.First();

			foreach (
				var item in
				_Enumerate(
					_distinct.Skip(1).ToList())

			)
			{
				yield return nilnul.obj.str.convert_._HeadX.Head(false, item);
				yield return nilnul.obj.str.convert_._HeadX.Head(true, item);

			}

		}

		/// <summary>
		/// polls
		/// </summary>
		/// <param name="_distinct"></param>
		/// <returns></returns>
		[Obsolete(nameof(nilnul.bit.var.set.BallotsX))]

		static public IEnumerable<State> _EnumerateToStates(IEnumerable<bit.VarI1> _distinct)
		{

			var x = _Enumerate(_distinct);

			foreach (var item in x)
			{
				yield return _Create__sameCount(_distinct, item);
			}

		}

		[Obsolete(nameof(bit.expr_.var.set.IBallot))]

		static public State _Create__sameCount(IEnumerable<VarI1> vars1, IEnumerable<bool> vals

			)
		{

			var r = new State();
			for (int i = 0; i < vars1.Count(); i++)
			{
				r.Add(vars1.ElementAt(i), vals.ElementAt(i));
			}
			return r;

		}
	}
}
