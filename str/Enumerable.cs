using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str
{

	public class EnumerableAsStr : StrA
	{
		private IEnumerable<bool> _val;

		public IEnumerable<bool> val
		{
			get { return _val; }
			set { _val = value; }
		}
		public EnumerableAsStr(IEnumerable<bool> val)
		{
			_val = val;
		}

		public override IEnumerator<bool> GetEnumerator()
		{
			return _val.GetEnumerator();
			//throw new NotImplementedException();
		}
	}

}
