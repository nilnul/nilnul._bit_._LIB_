namespace nilnul.bit.bi_
{
	/// <summary>
	/// <see cref="bi.re_.IConverse"/>: itself;
	/// <see cref="bi.re_.IDuet"/>: <see cref="_AndX"/>
	/// </summary>
	static public class _NandX
	{
		/// <summary>
		/// 
		/// </summary>
		/// alternatives:
		///		uparrow
		///		⍲
		///		⊼
		public const char TOKEN = '⍲';

		static public readonly string SYMBOL = $"{TOKEN}";
		static public bool Bi(bool x, bool y)
		{
			return !(x&&y);
		}
	}




}
