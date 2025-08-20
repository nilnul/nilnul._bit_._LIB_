using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream_.slider_.cumulus_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		conjunct
	///		and
	///		min
	public class Conjunctor:
		bit.stream_.SliderA
		,ICumulus
	{

		private bit.StreamI1 _arg;

		public bit.StreamI1 arg
		{
			get { return _arg; }
			set { _arg = value; }
		}


		private bool _current;
		public override bool current => _current;

		public Conjunctor( bit.StreamI1 arg)
		{
			this._arg = arg;	
		}

		public override void moveNext()
		{
			_current &= _arg.next();
		}
	}
}
