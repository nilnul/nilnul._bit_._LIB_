using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.be.vow_
{
	public class BeDefault<TBe>
		: Vow
		where TBe : nilnul.obj.BeI1<BinaryI1>, new()
	{
		public BeDefault() :
			base(
				_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
			)
		{
		}


		static public BeDefault<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<TBe>>.Instance;
			}
		}

	}
}
