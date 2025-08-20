using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream_.slider_
{

	/// <summary>
	/// started with false.
	/// if false then true, is true. so false comes first.
	/// (if true then false, is false.)
	/// </summary>
	public class Alter :
		bit.stream_.SliderA
		,
		bit.stream_.SliderI
	{
		private bool _current=false;

		public override bool current
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

		

		public override void moveNext()
		{
			_current = !_current;
		}

		static public Alter CreateTrueStart() { return new Alter(true); }

		static public Alter CreateFalseStart() { return new Alter(false); }

		//public bool next()
		//{
		//	var old = _current;
		//	_current = !_current;
		//	return old;
		//}
	}
}
