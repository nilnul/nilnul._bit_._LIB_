using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream.slider_
{
	[Obsolete()]

	/// <summary>
	/// started with false
	/// </summary>
	public class Alter : SliderI,StreamI
	{
		private bool _current=false;

		public bool current
		{
			get
			{
				return _current;
			}
		}
	

		public Alter(bool head=false)
		{
			_current = head;
		}

		

		public void moveNext()
		{
			_current = !_current;
		}

		static public Alter CreateTrueStart() { return new Alter(true); }

		static public Alter CreateFalseStart() { return new Alter(false); }

		public bool next()
		{
			var old = _current;
			_current = !_current;
			return old;
		}
	}
}
