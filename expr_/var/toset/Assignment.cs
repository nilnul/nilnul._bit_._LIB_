using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.toset
{
	public class Assignment
		: seq.EnumerableA<bit.var.Assignment>
	{
		private nilnul.bit.var.stati.str.be.Distinct.Asserted _vars;

		public nilnul.bit.var.stati.str.be.Distinct.Asserted vars
		{
			get { return _vars; }
			private set { _vars = value; }
		}

		private IEnumerable<bool> _vals;

		public IEnumerable<bool> vals
		{
			get { return _vals; }
			private set { _vals = value; }
		}

		public Assignment(nilnul.bit.var.stati.str.be.Distinct.Asserted vars
			, bool[] vals
		)
		{

			nilnul.Assert.True(
				vals.Length==  vars.length
			);

			_vars = vars;
			_vals = vals;

		}

		public Assignment(nilnul.bit.var.stati.str.be.Distinct.Asserted vars
			, IEnumerable<bool> vals
		)
		{

			nilnul.Assert.True(
				vals.Count()==  vars.length
			);

			_vars = vars;
			_vals = vals;

		}



		public override IEnumerator<var.Assignment> GetEnumerator()
		{
			for (int i = 0; i < _vals.Count(); i++)
			{
				yield return new var.Assignment(_vars.val.ElementAt(i),_vals.ElementAt(i));

			}

			yield break;

			throw new NotImplementedException();
		}

		
	}
}
