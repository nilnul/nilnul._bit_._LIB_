using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.co
{
	public class Sortie
		: nilnul.obj.Sortie3<(bool, bool)>
	{
		public Sortie(ObjsI3<(bool, bool)> val) : base(val)
		{
		}

		public Sortie(IEnumerable<(bool, bool)> val) : base(val)
		{
		}

		public Sortie(params (bool, bool)[] elements) : base(elements)
		{
		}

		public Sortie(IEqualityComparer<(bool, bool)> eq, ObjsI3<(bool, bool)> val) : base(eq, val)
		{
		}

		public Sortie(IEqualityComparer<(bool, bool)> eq, IEnumerable<(bool, bool)> val) : base(eq, val)
		{
		}

		public Sortie(IEqualityComparer<(bool, bool)> eq, params (bool, bool)[] elements) : base(eq, elements)
		{
		}

		

		static public Sortie OfAll() {
			var bits = bit.Sortie.OfAll();
			return new Sortie(
				nilnul.obj.str.strung.op_.binary_._CartesianX.Seq_byQuery(
					bits.ee
					,
					bits.ee
				
				)
				
			);
		}
		static public readonly Sortie All = OfAll();


	}
}
