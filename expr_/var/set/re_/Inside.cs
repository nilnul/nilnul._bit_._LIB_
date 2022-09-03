using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set
{
	public class Inside:nilnul.ord.LeA<Set>
	{

		public override bool le(Set x, Set y)
		{

			return x.IsSubsetOf(y);

			throw new NotImplementedException();
		}



	}

	
}
