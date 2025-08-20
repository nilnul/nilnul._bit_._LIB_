using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.of_.vec
{
	public class Set :
		nilnul.obj.set_.EqDefaulted<
			of_.ScalaI
			,
			vec.Eq
		>

	{
		public Set()
		{
		}

		public Set(params ScalaI[] vars) : base(vars)
		{
		}

		public Set(IEnumerable<ScalaI> elements) : base(elements)
		{
		}

	
	}
}
