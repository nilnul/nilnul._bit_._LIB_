using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream_
{
	public interface SliderI:
		nilnul.bit.StreamI1
		,
		nilnul.obj.stream_.SliderI<bool>
	{
	}

	public abstract class SliderA :
		nilnul.obj.stream_.SliderA<bool>
		,
		SliderI
	{
		

	}
}
