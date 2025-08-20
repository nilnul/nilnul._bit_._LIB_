namespace nilnul.bit
{
	/// <summary>
	/// implies of given, not variable as for <see cref="obj.IStr"/>, size;
	/// </summary>
	/// vs:
	///		<see cref="nilnul.obj.IStr"/>, which is of variable size;
	public interface IVec
		:
		obj.IVec<bool>
		,
		bit.IStr
	{ }
}
