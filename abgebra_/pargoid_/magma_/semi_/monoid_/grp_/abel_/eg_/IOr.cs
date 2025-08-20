namespace nilnul.bit.abgebra_.pargoid_.magma_.semi_.monoid_.grp_.abel_.eg_
{
	/// <summary>
	/// the unard is 0. as 0|1 = 1, 0|0 = 0;
	/// the nard is 1,  as 1|x =1;
	/// </summary>
	/// <remarks>
	/// hence orAssignment works:
	///		x|=y
	///			, when x is nard 1, no operation is necessary;
	///			, when x is unard 0, x=x|y; but when y is unard, x|y=x, and the assignment is unnecessary.(when x y are different, that is y is 1.)
	///			So only when x is 0, and y is 1, the assignment is necessary; and once x is 1, no op is necessary;
	///			, this is useful in a loop, where we need to get an aggregate: disjunction. But note, the unard 0 means, the semantics of the variable x doesnot hold initially (for vacuous collection); and for first element <var>z</var> in the collection, 0|z shall always be z.  The semantics shall be decided by the value of the first element; for example, if the true in an element means something, then that is the semantic;
	/// </remarks>
	internal class IOr
	{
	}




}
