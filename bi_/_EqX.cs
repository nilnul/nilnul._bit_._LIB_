using System.Runtime.CompilerServices;

namespace nilnul.bit.bi_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		eq
	///		biconditional
	///		mutual imply
	///		iif
	///		iff
	///		corre
	///		coincident
	///		synergy
	///		iso
	///		simultaneously
	///		concur
	///		align
	///		agree
	///		nxor
	///		
	///		
	static public class _EqX
	{
		/// <summary>
		/// 
		/// </summary>
		/// alternative:
		///		=
		///		==
		///		≡
		///		⟚
		///		⇔
		///		≈
		///		~
		public const char TOKEN = '=';
		/// <summary>
		/// </summary>
		static public readonly string SYMBOL = $"{TOKEN}";

		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		static public bool Bi(in bool x,in bool y)
		{
			return x==y;
		}
	}





}
