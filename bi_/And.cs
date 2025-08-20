using System.Runtime.CompilerServices;

namespace nilnul.bit.bi_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		and
	///		ampersand
	///		
	///		nd
	///		min
	///			mn
	public class And :
		nilnul.bit.IBi
		,
		nilnul.bit.BiI
		,
		nilnul.bit.op_.BinaryI1
		,
		nilnul.obj.of_.BinaryI<bool>
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool op(bool par, bool par1)
		{
			return _AndX.Bi(par, par1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool op(in bool par, in bool par1)
		{
			return _AndX.Bi(par, par1);
		}

		static public And Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<And>.Instance;
			}
		}
	}
}