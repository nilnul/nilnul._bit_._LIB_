namespace nilnul.bit0nul.to_.dich_
{
	/// <summary>
	/// 012 is normally modulo over 3; but here we take 2 as modulo to coerce it as boolean;
	/// </summary>
	static public class _TwoAsEvenX
	{
		static public bool TwoAsEven(this in bool? bit0nul) {
			return bit0nul is null ? false : bit0nul.Value;
		}
	}

}
