using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str
{
	public class List:StrA
	{
		private List<bool> _val;

		public List<bool> val
		{
			get { return _val; }
			set { _val = value; }
		}

		public List(List<bool> val)
		{
			_val = val;
		}

		public List()
		{
			_val = new List<bool>();
		}

		public override IEnumerator<bool> GetEnumerator()
		{
			return _val.GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
