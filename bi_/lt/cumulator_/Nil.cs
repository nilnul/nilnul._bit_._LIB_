using nilnul.bit.op_.binary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi_.lt.cumulator_
{
	/// <summary>
	/// 
	/// </summary>
	public class Nil
		: Cumulator
	{
		public Nil() : base(false)
		{
		}


		static public Nil Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nil>.Instance;
			}
		}

	}
}
