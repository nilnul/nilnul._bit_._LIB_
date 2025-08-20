namespace nilnul.bit.bi_
{
	/// <summary>
	/// x > y
	/// </summary>
	/// <remarks>
	/// <see cref="bi.re_.IDuet"/>: <see cref="bi_._LeX"/>
	/// <see cref="bi.re_.IConverse"/>: <see cref="bi_._LtX"/>
	/// </remarks>
	static public class _GtX
	{
		/// <summary>
		/// 
		/// </summary>
		public const string SYMBOL = ">";

		static public bool Bi(bool x, bool y)
		{
			return x && !y;
		}
	}



}
