using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain
{
	public interface EqI:IEqualityComparer<PlainI>
	{

	}
	public abstract class EqA : EqI
	{
		public abstract bool Equals(PlainI x, PlainI y);
		public  int GetHashCode(PlainI obj) { return 0; }
	}
}
