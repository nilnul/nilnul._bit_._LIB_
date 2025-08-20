using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream_.slider_
{
	internal class Cumulus:
		bit.stream_.SliderA
	{

		private bit.StreamI1 _arg;

		public bit.StreamI1 arg
		{
			get { return _arg; }
			set { _arg = value; }
		}


		private bool _current;
		public override bool current => throw new NotImplementedException();

		public Cumulus( bit.StreamI1 arg)
		{
			this._arg = arg;	
		}

		public override void moveNext()
		{
			_current 
		}
	}
}
