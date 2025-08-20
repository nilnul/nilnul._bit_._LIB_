using System.Runtime.CompilerServices;

namespace nilnul.bit.bi_
{
	/// <summary>
	/// x | !y
	/// ;
	/// implied by;
	/// requires; entails;
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		x is the necessity for y
	///		x is necessary;
	///		pow|power|ponent, as [0,1] = 0, else = 1.
	///

	static public class _GeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// alter:
		///		>=
		public const char TOKEN = '≥';
		/// <summary>
		/// 
		/// </summary>
		static public readonly string SYMBOL = $"{TOKEN}";

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Bi(bool x, bool y)
		{
			return x || !y;
		}
	}






}
