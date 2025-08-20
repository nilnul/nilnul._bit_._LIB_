using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str_.fixedLen
{
	public class Comparer : IComparer<IEnumerable<bool>>
	{
		private int _len;

		public int len
		{
			get { return _len; }
			set { _len = value; }
		}

		public Comparer(int len)
		{
			_len = len;
		}

		public int Compare(IEnumerable<bool> x, IEnumerable<bool> y)
		{
			for (int i = 0; i < _len; i++)
			{
				var compared = nilnul.bit.Comparer.Lazy.Compare(x.ElementAt(i), y.ElementAt(i));

				if (compared!=0)
				{
					return compared;

				}
			}
			return 0;
		//	throw new NotImplementedException();
		}

		static private Lazy<Comparer> _Lazy = new Lazy<Comparer>();
		static public Comparer Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
