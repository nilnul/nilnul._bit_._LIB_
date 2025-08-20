using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream_
{
	[Obsolete(nameof(stream_.slider_.Alter)+" ; as this is infact an implementation of slider")]
	public class Alter : bit.StreamI, bit.StreamI1
	{
		private bool _b4head=false;

		public bool b4head
		{
			get { return _b4head; }
			set { _b4head = value; }
		}

		public bool next()
		{
			return _b4head = !_b4head;
			//return _b4head;

		}
	}
}
