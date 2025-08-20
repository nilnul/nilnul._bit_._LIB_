using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.vow.ee_
{
	public class VowDefault<TVow> : Ee
		where TVow : nilnul.obj.VowI2<op_.BinaryI1>, new()
	{
		public VowDefault(BinaryI1 val) :
			base(
				val
				,
				nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
			)
		{
		}
	}
}
