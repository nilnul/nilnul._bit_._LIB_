using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.objs.be_.distinct.vow;

namespace nilnul.bit.var
{
	[Obsolete()]
	public interface SortieI
		:nilnul.obj.SortieI<nilnul.bit.VarI1>
	{
	}
	[Obsolete()]

	public class Sortie :
		nilnul.bit.var.str.be_.distinct.vow.Ed
		,
		SortieI
	{
		public Sortie(StrI1 val) : base(val)
		{

		}

		public En1<VarI1> asDistinct => throw new NotImplementedException();

		public bool contain(nilnul.bit.VarI1 var) {
			return new nilnul.bit.var.str.be_.Contain(var).be(ed);
		}


	}
}
