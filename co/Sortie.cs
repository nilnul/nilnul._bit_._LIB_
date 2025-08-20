using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.co
{
	static public class _SortieX
	{

		static public IEnumerable<(bool former, bool latter)> Seq() {
			var bits = bit.Sortie.ARR;

			return nilnul.obj.str.strung.op_.binary_._CartesianX.Seq_byQuery(
					bits
					,
					bits

			);
		}

		static public readonly (bool former, bool latter)[] Array = Seq().ToArray();

		public const int COUNT = 4; /// sq(2)



	}

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

		public Sortie():this(_SortieX.Seq())
		{
				
		}


		static public Sortie Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Sortie>.Instance;
			}
		}


		[Obsolete(nameof(Singleton))]
		static public Sortie OfAll() {
			
			return new Sortie(
				
			);
		}

		[Obsolete(nameof(Singleton))]
		static public readonly Sortie All = OfAll();


	}
}
