namespace nilnul.bit.expr_.tauto_
{
	/// <summary>
	/// <see cref="op_.binary_.Iff"/>
	/// </summary>
	public interface ITantamount:ITautology { }

	static public class _TantamountX 
	{

		/// <summary>
		/// when the equiv <-> becomes <see cref="ITautology"/>, the symbol becomes this;
		/// </summary>
		/// <remarks>
		/// <-> in expr would return bit, while <=> in tautology would return nothing, which might be exception;
		/// </remarks>

		public const string SYMBOL = "<=>";

	}


}
