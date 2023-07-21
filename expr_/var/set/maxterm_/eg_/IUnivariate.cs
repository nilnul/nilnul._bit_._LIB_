namespace nilnul.bit.expr_.var.set.maxterm_.eg_
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
	///	we observer where the interpreted is 0;
	/// if we product all, we get all interpretations as 0s; the result is 0;
	/// if we product none, we get none interpretations as 0s; the result is 1;
	/// 
	/// 
	/// </summary>
	public interface IUnivariate { }
}
