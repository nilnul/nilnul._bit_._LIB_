using nilnul.bit.op_.binary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi_.ge.cumulator_
{
	/// <summary>
	/// 
	/// </summary>
	public class One
		: Cumulator
	{
		public One() : base(true)
		{
		}


		static public One Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<One>.Instance;
			}
		}

	}
}
