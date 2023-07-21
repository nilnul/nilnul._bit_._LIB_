using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.sortedSet
{
	public class Eq : IEqualityComparer<SortedSet>
	{
		private IEqualityComparer<SortedSet<nilnul.bit.VarI1>> _eq;

		public IEqualityComparer<SortedSet<nilnul.bit.VarI1>> eq
		{
			get { return _eq; }
			//set { _eq = value; }
		}

		public Eq()
		{
			_eq = SortedSet<nilnul.bit.VarI1>.CreateSetComparer(nilnul.obj.var.Eq1.Instance);


		}
		public bool Equals(SortedSet x, SortedSet y)
		{
			return _eq.Equals(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(SortedSet obj)
		{
			return _eq.GetHashCode(obj);
			//throw new NotImplementedException();
		}

		public bool _equals(IEnumerable<nilnul.bit.VarI1> _sortedSet, IEnumerable<nilnul.bit.VarI1> _sortedSet1) {

			return _sortedSet.SequenceEqual(_sortedSet,nilnul.obj.var.Eq1.Instance);
			
		}

		static private Lazy<Eq> _Lazy = new Lazy<Eq>();
		static public Eq Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
