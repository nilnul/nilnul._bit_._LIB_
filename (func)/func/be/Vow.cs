using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.be
{
	public class Vow<TBe>
		: nilnul.be.Vow<nilnul.bit.FuncI2,TBe>
		,nilnul.bit.func.VowI
		where TBe : nilnul.bit.func.BeI1, new()
	{
		
	}
}
