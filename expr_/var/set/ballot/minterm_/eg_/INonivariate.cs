namespace nilnul.bit.expr_.var.set.minterm_.eg_
{
	/// <summary>
	/// let n be the count of vars:
	///		the the count of maxterms is 2^n
	///
	///	when n=0, we have only one minterm:
	///		prod()
	///	in truth table:
	///		() = result
	///		-------
	///		() =  prod() =1
	///		
	///	<see cref="eg_.IBivariate"/>
	///	we observer there is a unique row where the interpreted is 1;
	/// if we sum all minterms, we get all interpretations as 1s; the result is 1;
	/// if we sum none maxterms, we get none interpretations as 1s; the result is 0;
	/// 
	/// 
	/// </summary>
	public interface INonvariate { }
}
