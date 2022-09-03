using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.func.be_.tauto.vow;

namespace nilnul.bit.func_
{
	public interface TautoI
	{
		nilnul.bit.func.be_.tauto.vow.En tauto { get; }
	}
	public class Tauto : nilnul.bit.func.be_.tauto.vow.En
		,
		TautoI
	{
		public Tauto(FuncI2 val) : base(val)
		{
		}

		public nilnul.bit.func.be_.tauto.vow.En tauto => this;

	}
}
