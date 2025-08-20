namespace nilnul.bit.bi_
{
	/// <summary>
	/// and;
	/// conjunct;
	/// </summary>
	/// alias:
	///		multi
	///		min
	///			,as "and" is a keyword in C# comparison patter, "min" can be used as an euphemism for that;
	///		and
	static public class _AndX
	{
		/// <summary>
		/// 
		/// </summary>
		/// &&
		/// &
		///		∧
		/// 
		public const char TOKEN = '&';
		/// <summary>
		/// 
		/// </summary>
		static public readonly string SYMBOL = $"{TOKEN}";

		static public bool Bi(bool x, bool y)
		{
			return x&&y;
		}
	}





}
