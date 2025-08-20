using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	public interface IStream
		:
		nilnul.obj.IStream<bool>
	{ }
	public interface StreamI1:nilnul.obj.StreamI2<bool>
	{
	}


}
