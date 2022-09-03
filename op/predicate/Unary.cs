using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.predicate
{
	public partial class Unary<TArg> : nilnul.bit.op.predicate.UnaryI<TArg>
	{
		private System.Predicate<TArg> _predicate;

		public System.Predicate<TArg>  predicate
		{
			get { return _predicate; }
			set { _predicate = value; }
		}


		public bool eval(TArg x) {
			return _predicate(x);
		}
		public Unary(System.Predicate<TArg> predicate)
		{
			this._predicate = predicate;

		}
		public Unary()
			:this((x)=>true)
		{

		}


		
	}
}
