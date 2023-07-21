namespace nilnul.bit.expr_.var.set.minterm_.eg_
{
	/// <summary>
	/// let n be the count of vars:
	///		the the count of maxterms is 2^n
	///	
	///
	///	when n=1, we have 2^1 maxterms:
	///		
	///		x| result
	///		---------
	///		 0| 0
	///		 1|1
	///
	///		!x| result
	///		---------
	///		 0| 1
	///		 1|0
	///	<see cref="eg_.IBivariate"/>
	///	we observer the unique row where the interpreted is 1;
	/// if we sum all minterms, we get all interpretations as 1s; the result is 1;
	/// if we sum none minterms later, we get none interpretations as 1s; the result is 0;
	/// 
	/// 
	/// </summary>
	public interface IUnivariate { }
}
