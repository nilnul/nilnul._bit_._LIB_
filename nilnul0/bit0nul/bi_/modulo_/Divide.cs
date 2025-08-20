using System;

namespace nilnul.bit0nul.bi_.modulo_
{
	/// <summary>
	/// modulo divide
	/// </summary>
	/// alias:
	///		<see cref="nilnul.num.bi_."/>
	public class Divide : bit0nul.BiI
	{
		/// <summary>
		/// par / par1
		/// </summary>
		/// <param name="par"></param>
		/// <param name="par1"></param>
		/// <returns></returns>
		public bool? op(bool? par, bool? par1)
		{
			if (par1 == false) /// 0
			{
				return null;	///max

			}
			if (par1 ==true)
			{
				return par;

			}

			if (par is null)
			{
				return true;
			}
			return false;

		}


		static public Divide Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Divide>.Instance;
			}
		}

	}



}
