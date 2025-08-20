namespace nilnul.bit.expr_.var.set.maxterm_.eg_
{
	/// <summary>
	/// let n be the count of vars:
	///		the the count of maxterms is 2^n
	///
	///	when n=0, we have only one maxterm:
	///		sum()
	///	in truth table:
	///		() = result
	///		-------
	///		() =  sum() =0
	///		
	///	<see cref="eg_.IBivariate"/>
	///	we observer where the interpreted is 0;
	/// if we product all maxterms, we get all interpretations as 0s; the result is 0;
	/// if we product none maxterms, we get none interpretations as 0s; the result is 1;
	/// 
	/// 
	/// </summary>
	public interface INonvariate { }
}
