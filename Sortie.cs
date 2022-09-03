using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	public class Sortie
		: nilnul.obj.Sortie3<bool>
	{
		public Sortie(ObjsI3<bool> val) : base(val)
		{
		}

		public Sortie(IEnumerable<bool> val) : base(val)
		{
		}

		public Sortie(params bool[] elements) : base(elements)
		{
		}
		public Sortie():base(false,true)
		{

		}

		public Sortie(IEqualityComparer<bool> eq, ObjsI3<bool> val) : base(eq, val)
		{
		}

		public Sortie(IEqualityComparer<bool> eq, IEnumerable<bool> val) : base(eq, val)
		{
		}

		public Sortie(IEqualityComparer<bool> eq, params bool[] elements) : base(eq, elements)
		{
		}

		static public Sortie OfAll() {
			return new Sortie(
				false
				,
				true
			);
		}
		static public Sortie All = OfAll();


	}
}
