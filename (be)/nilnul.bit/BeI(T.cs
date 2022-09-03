using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{


	public partial interface BeI< in T>:BeI
	{
		bool be(T obj);

	}
}
