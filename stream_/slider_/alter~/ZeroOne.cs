using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream
{

	public class ZeroOne : StreamI
	{
		private bool _b4head=true;

		public bool b4head
		{
			get { return _b4head; }
			set { _b4head = value; }
		}

		public bool next()
		{
			_b4head = !_b4head;
			return _b4head;

			throw new NotImplementedException();
		}
	}
}
