using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.stati.s
{
	[Obsolete()]
	public class Headed : nilnul.obj.var.stati.s.Headed<bool, bit.var.stati.Stati, SI>, SI
	{

		public Headed(bit.var.stati.Stati head, SI tail) : base(head, tail)
		{

		}

		static public Headed CreateSingleton(bit.var.stati.Stati var) {
			return new Headed(var, Empty.Singleton);
		}
	}

	public class Empty:nilnul.obj.var.stati.s.Empty
		,SI
	{

		static public Empty Singleton = SingletonByDefault<Empty>.Instance;

	}
	public interface SI:nilnul.obj.var.stati.s.SI
	{
	}
}
