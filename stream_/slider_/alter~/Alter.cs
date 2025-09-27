using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream
{
	[Obsolete(nameof(nilnul.bit.slider_.Alter))]
	public class Alter : StreamI
	{
		private bool _b4head=false;

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
