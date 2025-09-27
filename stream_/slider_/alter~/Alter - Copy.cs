using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.slider_
{
	[Obsolete()]

	public class Alter : SliderI
	{
		private bool _current=false;

		//public bool head
		//{
		//	get { return _current; }
		//	//set { _head = value; }
		//}

		public Alter(bool head)
		{
			_current = head;
		}
		public bool current
		{
			get
			{
				return _current;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_current = !_current;
			//throw new NotImplementedException();
		}

		static public Alter CreateTrueFalse() { return new Alter(true); }

		static public Alter CreateFalseTrue() { return new Alter(false); }
		
	}
}
