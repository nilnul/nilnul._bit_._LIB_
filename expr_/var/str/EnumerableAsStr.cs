using nilnul.bit.var.stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace nilnul.bit.var.sortedSet
{
	public class EnumerableAsStr:nilnul.bit.var.StrA
	{
		private IEnumerable<VarI1> _stati;

		public IEnumerable<VarI1> stati
		{
			get { return _stati; }
			set { _stati = value; }
		}

		public EnumerableAsStr(IEnumerable<VarI1> v)
		{
			_stati = v;
		}

		


		public override IEnumerator<VarI1> GetEnumerator()
		{
			return _stati.GetEnumerator();
			throw new NotImplementedException();
		}


	}
}
