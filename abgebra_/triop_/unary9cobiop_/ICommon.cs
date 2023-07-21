namespace nilnul.bit.abgebra_.triop_
{
	/// <summary>
	/// not, or, and
	/// </summary>
	/// <remarks>
	/// the nilard is 0; the oneard is 1;
	/// the annillator is 0;
	/// we have no negation. -0 =0. but -1 can be 0 or 1.
	/// for nonnil 1, its inverse is 1 as 1&1 =1.
	/// 
	/// </remarks>
	/// alias:
	///		common abgebra
	///		canonical, but it means sop,pos of minterms or maxterms;
	///		normal, but normal means:sop, pos
	///		,
	///		boolean, per http://www2.seas.gwu.edu/~ayoussef/cs1311/spring16/BooleanAlgebra.pdf
	///		
	public interface ICommon:IAbgebra
		,
		ITriop
	{
	}



}
