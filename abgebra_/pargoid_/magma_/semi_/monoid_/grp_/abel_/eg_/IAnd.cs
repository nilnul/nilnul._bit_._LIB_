namespace nilnul.bit.abgebra_.pargoid_.magma_.semi_.monoid_.grp_.abel_.eg_
{
	/// <summary>
	/// the unard is 1. as 1 & 0 = 0, 1 & 1 = 1;
	/// the nard is 0,  as 0 & x =0;
	/// </summary>
	/// <remarks>
	/// hence andAssignment works:
	///		x &= y
	///			, when x is nard 0, no operation is necessary;
	///			, when x is unard 1, x=x&y; but when y is unard 1, x&y=x, and the assignment is unnecessary. (when x y are different)
	///			So only when x is 1, and y is 0, the assignment is necessary; and once x is 0, no op is necessary;
	///			, this is useful in a loop, where we need to get an aggregate: conjunction. But note, the unard 1 means, the semantics of the variable x doesnot hold initially (for vacuous collection); and for first element z, 1&z is always z. The semantics shall be decided by the value of the first element; for example, if the true in an element means something, then that is the semantic;
	/// </remarks>
	/// 
	internal class IAnd
	{
	}




}
