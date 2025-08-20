using System.Runtime.CompilerServices;

namespace nilnul.bit.bi_
{
	public class Eq :
		nilnul.bit.IBi
		,
		nilnul.bit.op_.BinaryI1
		,
		nilnul.obj.of_.BinaryI<bool>
		//,
		//nilnul.obj.bi<bool>

	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool op(bool par, bool par1)
		{
			return _EqX.Bi(in par, in par1);
		}




		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq>.Instance;
			}
		}


	}




}
