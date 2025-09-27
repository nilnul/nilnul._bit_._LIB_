using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{

	/// <summary>
	/// aliase for Multi
	/// </summary>
	///
	[Obsolete()]
	public class Min
		:nilnul.bit.op.BinaryI
	{


		public bool eval(bool x, bool y)
		{
			return x && y;
			throw new NotImplementedException();
		}
	}
}
