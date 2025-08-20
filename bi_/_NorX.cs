namespace nilnul.bit.bi_
{
	/// <summary>
	/// <see cref="bi.re_.IDuet"/>: <see cref="bi_._OrX"/>
	/// ;
	/// <see cref="bi.re_.IConverse"/>: itself;
	/// </summary>
	static public class _NorX
	{
		/// <summary>
		/// 
		/// </summary>
		/// alternative:
		///		⊽
		///		⍱
		///		↓
		///		⊽
		///		⊻
		///		^
		///		
		///
		public const char TOKEN = '⍱';

		static public readonly string SYMBOL = $"{TOKEN}";
		static public bool Bi(bool x, bool y)
		{
			return !(x||y);
		}
	}



}
