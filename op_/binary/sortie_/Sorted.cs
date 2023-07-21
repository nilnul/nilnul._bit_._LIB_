using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.sortie_
{
	public class Sorted
		: SortedSet<op_.BinaryI1>
	{



		public Sorted(IEnumerable<BinaryI1> collection, IComparer<BinaryI1> comparer) : base(collection, comparer)
		{
		}

		public Sorted(IComparer<BinaryI1> comparer) : base(comparer)
		{
		}
		public Sorted(IEnumerable<BinaryI1> collection) : base(collection, binary.Comp.Singleton)
		{
		}
		
		public Sorted():base(
			binary.Comp.Singleton
		) 
		{
		}

		static public Sorted _OfAll() {
			return new Sorted(binary.Sortie._Arr);
		}
		static public Sorted _OfAllReversed() {
			return new Sorted(binary.Sortie._Arr, binary.comp_.Converse.Singleton);
		}

		static public Sorted All = _OfAll();
		static public Sorted AllReversed = _OfAllReversed();
			



	}
}
