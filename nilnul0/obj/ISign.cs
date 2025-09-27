namespace nilnul.obj
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// for integer, the sign should include not only positive or negative, but also 0;
	/// to use only positive or negative, excluding 0, we need to use another term: negated. the negatedness or an integer is true or false, never a null value;
	/// </remarks>
	/// alias:
	///		trich
	///		sign

	public interface ISign :ITrichotomy{ }


}
