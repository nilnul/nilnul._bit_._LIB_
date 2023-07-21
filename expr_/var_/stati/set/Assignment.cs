using nilnul.bit.var.stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.stati.set
{
	[Obsolete()]
	public class Assignment:Dictionary<bit.var.stati.Stati,bool>
	{

		public Assignment()
			:base(stati.Eq.Singleton)
		{

		}





		public var.stati.Set vars {
			get {
				return new var.stati.Set(Keys);
			}
		}

		static public IEnumerable<IEnumerable<bool>> _Enumerate(IEnumerable<bit.var.stati.Stati> _distinct)
		{

			if (_distinct.Count() == 0)
			{
				yield break;

			}

			//var firstVar = _distinct.First();

			foreach (
				var item in
				_Enumerate(
					_distinct.Skip(1))

			)
			{
				yield return nilnul.seq.Head.Eval(false, item);
				yield return nilnul.seq.Head.Eval(true, item);

			}

		}



	}
}
