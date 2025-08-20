using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.re_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		extreme
	///		noCancel
	public class NoCancel : ReI

	{
		public bool re(bool? a, bool? b)
		{
			return (a ==true && b ==true)  || (a ==false &&  b==false);
		}

		public bool re(int a, int b)
		{
			
			return (a >0  && b >0)  || (a <0 && b<0);
		}

		static public NoCancel Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<NoCancel>.Unison;
			}
		}

	}
}
