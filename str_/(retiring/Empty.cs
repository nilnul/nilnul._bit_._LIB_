using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str.eg
{
	public class Empty : StrA
	{

		public override IEnumerator<bool> GetEnumerator()
		{
			yield break;
			//throw new NotImplementedException();
		}
	}
}
