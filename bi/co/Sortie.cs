using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.co
{
	public class Sortie
		: nilnul.obj.Sortie3<(bit.op_.BinaryI1, bit.op_.BinaryI1)>
	{
		

		


		public Sortie(IEqualityComparer<(BinaryI1, BinaryI1)> eq, ObjsI3<(BinaryI1, BinaryI1)> val) : base(eq, val)
		{
		}

		public Sortie(ObjsI3<(BinaryI1, BinaryI1)> val) : base(val)
		{
		}

		public Sortie(IEqualityComparer<(BinaryI1, BinaryI1)> eq, IEnumerable<(BinaryI1, BinaryI1)> val) : base(eq, val)
		{
		}

		public Sortie(IEnumerable<(BinaryI1, BinaryI1)> val) : base(val)
		{
		}

		public Sortie(IEqualityComparer<(BinaryI1, BinaryI1)> eq, params (BinaryI1, BinaryI1)[] elements) : base(eq, elements)
		{
		}

		public Sortie(params (BinaryI1, BinaryI1)[] elements) : base(elements)
		{
		}

		static public Sortie OfAll()
		{
			var bits = bit.op_.binary.Sortie.OfAll();
			return new Sortie(
				new nilnul.obj.eq_.HashNil<(op_.BinaryI1,op_.BinaryI1)>(
					(co,co1) =>
					nilnul.bit.op_.binary.Eq.Singleton.Equals(co.Item1,co1.Item1)
					&&
					nilnul.bit.op_.binary.Eq.Singleton.Equals(co.Item2,co1.Item2)

				)
				,
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
