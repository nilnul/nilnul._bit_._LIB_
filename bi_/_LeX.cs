namespace nilnul.bit.bi_
{
	/// <summary>
	/// imply
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		imply
	///		suffice
	/// 
	static public class _LeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// alternative:
		///		->
		///		<=
		public const char TOKEN = '≤';

		static public readonly string SYMBOL = $"{TOKEN}";

		static public bool Bi(bool x, bool y)
		{
			return !x || y;
		}
	}



}
