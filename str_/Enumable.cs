using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str_
{
	public class Enumable

		:
		nilnul.obj.Box<IEnumerable<bool>>
		,
		EnumableI
	{
		public Enumable(IEnumerable<bool> val) : base(val)
		{
		}

		public IEnumerator<bool> GetEnumerator()
		{
			return boxed.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}


	}
}
