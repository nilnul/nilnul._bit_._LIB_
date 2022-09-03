using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.vec
{
	/// <summary>
	/// unlike str.Eq, here we assume the two vec are of the same arity
	/// </summary>
	public class Eq: nilnul.obj.str_.seq.eq_.ElEqDefaulted<bool, nilnul.bit.Eq>
	{

		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq>.Instance;
			}
		}


	}
}
