using nilnul.bit.str.eg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream.eg
{
	public class Cyclic:
		nilnul.stream.Cyclic<bool>,
		
		StreamI

	{
		private Seeded _seeded;

		public Seeded seeded
		{
			get { return _seeded; }
			set { _seeded = value; }
		}

		public Cyclic(Seeded seeded):base(seeded)
		{
		}

	
	}
}
