using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace nilnul.bit.vow_
{
	/// the unvered one is occupied by previouse dep.
	/// <summary>
	/// 
	/// </summary>
	static public class _TrueX1
	{
		static public void Vow<T>( bool bit, string x)
			where T: nilnul.obj.IVow

		{
			if (!bit)
			{
				throw new nilnul.obj._vow.FailException1<T>(
					x
				);
			}
		}

		static public void Vow<T>( bool bit)
			where T: nilnul.obj.IVow
		{
			if (!bit)
			{
				throw new nilnul.obj._vow.FailException1<T>(
				);
			}
		}

		static public void Vow_ovXpn<T>(bool bit, string x)

		{
			if (!bit)
			{
				throw new Exception(x);
			}
		}
		static public void Vow_ovXpn<T>( bool bit, T xpn)
			where T: Exception

		{
			if (!bit)
			{
				throw xpn;
			}
		}

		static public void Vow_ovXpn<T>( bool bit)
			where T: Exception,new()

		{
			Vow_ovXpn(bit, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<T>.Instance
			);
			
		}
		
	}
}