using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.func_.tauto.be_.unary.vow;

namespace nilnul.bit.func_.tauto_
{
	public interface UnaryI
	{
		nilnul.bit.func_.tauto.be_.unary.vow.En unary { get; }
	}

	public class Unary : nilnul.bit.func_.tauto.be_.unary.vow.En,

		UnaryI
	{
		public Unary(TautoI val) : base(val)
		{
		}

		public En unary => this;
	}
}
