using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr_.plain.be_.tauto.vow;

namespace nilnul.bit.expr_.plain_
{
	public interface TautoI
	{
		nilnul.bit.expr_.plain.be_.tauto.vow.En tauto { get; }
	}

	public class Tauto : nilnul.bit.expr_.plain.be_.tauto.vow.En
		,
		TautoI
	{
		public Tauto(PlainI val) : base(val)
		{
		}

		public En tauto => this;
	}
}
