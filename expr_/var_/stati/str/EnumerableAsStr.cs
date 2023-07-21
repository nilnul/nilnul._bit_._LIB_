using nilnul.bit.var.stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace nilnul.bit.var.stati.str
{
	public class EnumerableAsStr:

		nilnul.seq.EnumerableA<Stati>,
		
		nilnul.bit.var.stati.StrI
	{
		private IEnumerable<Stati> _stati;

		public IEnumerable<Stati> stati
		{
			get { return _stati; }
			set { _stati = value; }
		}

		public EnumerableAsStr(IEnumerable<Stati> v)
		{
			_stati = v;
		}

		


		public override IEnumerator<Stati> GetEnumerator()
		{
			return this.GetEnumerator();
			throw new NotImplementedException();
		}


	}
}
