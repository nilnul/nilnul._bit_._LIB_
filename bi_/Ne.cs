using System.Runtime.CompilerServices;

namespace nilnul.bit.bi_
{
	/// <summary>
	/// 
	/// </summary>
	public class Ne :
		nilnul.bit.IBi
		,
		nilnul.bit.op_.BinaryI1
		,
		nilnul.obj.of_.BinaryI<bool>
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool op(bool par, bool par1)
		{
			return _NeX.Bi(par, par1);
		}



		static public Ne Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Ne>.Instance;
			}
		}


	}




}
