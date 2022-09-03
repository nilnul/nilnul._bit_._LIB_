using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.duo_
{
	public class Equiv
		: 
		duo.be_.equiv.vow.En
		,
		nilnul.CoI<nilnul.bit.expr_.PlainI>
	{
		public Equiv(Duo val) : base(val)
		{
		}

		public PlainI item => this.en.Item1;
		public PlainI item1 => this.en.Item2;
	}
}
