using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	/// <summary>
	/// we prefer nint to bool? as the latter is over complex and not performant.
	/// </summary>
	public interface INulable { }
	static public class _NulableX
	{
		static public int ToInt(this bool? bitNul) {
			return bitNul is null ? 0 : to.ToIntX.ToNegPosOne(bitNul.Value);
		}

		static public bool? FroInt(this int bitNul) {
			return bitNul==0?(bool?) null: (bitNul>0?true:false );
		}

	}
}
