using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Rejected<T>
	{
		public Rejected(T val, Func<T, bool> be)
		{
			nilnul.bit.be.Reject.Eval(val,be);

			this.val = val;
			this._be = be;

		}


	

		private T _val;
		public T val
		{
			get { return _val; }
			set
			{

				_val = value;
			}
		}

		private Func<T, bool> _be;

		public Func<T, bool> be
		{
			get { return _be; }
			set { _be = value; }
		}


		

	}
}
