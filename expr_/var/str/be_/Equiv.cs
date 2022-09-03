using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.bit.var.sortedSet.be_
{
	/*extern alias obj;*/
	public class Equiv
		:
		nilnul.objs.be_.Equiv<VarI1>
		,
		/*obj::*/nilnul.obj.BeI1<IEnumerable<VarI1>>
	{
		public Equiv( ) : base(bit.var.Eq.Instance)
		{
		}

		
	}
}
