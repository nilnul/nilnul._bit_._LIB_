namespace nilnul.bit.bi_
{
	/// <summary>
	/// or;
	/// disjunct;
	/// </summary>
	/// alias:
	///		max
	///		or
	static public class _OrX
	{
		/// <summary>
		/// 
		/// </summary>
		/// alternative:
		///		∨
		///			,like letter v
		///		|	
		public const char TOKEN = '|';
		/// <summary>
		/// </summary>
		static public readonly string SYMBOL = $"{TOKEN}";

		static public bool Bi(bool x, bool y)
		{
			return x||y;
		}
	}




}
