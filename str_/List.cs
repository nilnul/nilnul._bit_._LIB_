using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str_
{
	[Obsolete("lst the name is preferred",true)]
	public class List:StrI1
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

		 
	}
}
