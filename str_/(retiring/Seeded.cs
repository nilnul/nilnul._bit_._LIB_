using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str.eg
{
	[Obsolete()]
	public class Seeded
		: nilnul.bit.StrA

		
	{


		static public implicit operator nilnul.str.Seeded<bool>(
			Seeded seeded
			) {
			return new nilnul.str.Seeded<bool>(seeded.seed, seeded.tail);
		}
        private bool _seed;

		public bool seed
		{
			get { return _seed; }
			set { _seed = value; }
		}

		private StrI _tail;

		public StrI tail
		{
			get { return _tail; }
			set { _tail = value; }
		}


		public Seeded(bool seed, StrI tail)
		{
			_seed = seed;
			_tail = tail;
		}
		public override IEnumerator<bool> GetEnumerator()
		{

			yield return _seed;
			foreach (var item in _tail)
			{
				yield return item;
			}
			yield break;

			throw new NotImplementedException();
		}
	}
}
