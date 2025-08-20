namespace nilnul.bit.expr_.var.set.maxterm_.eg_
{
	/// <summary>
	/// let n be the count of vars:
	///		the the count of maxterms is 2^n
	///
	///	when n=2, we have 2^2 maxterms:
	///		
	///		x|y  = result
	///		---------
	///		0|0  = 0
	///		0|1  = 1
	///		1|0  = 1
	///		1|1  = 1
	///
	///		x|!y  = result
	///		---------
	///		0|0  = 1
	///		0|1  = 0
	///		1|0  = 1
	///		1|1  = 1
	///		
	///		!x|y  = result
	///		---------
	///		0|0  = 1
	///		0|1  = 1
	///		1|0  = 0
	///		1|1  = 1
	///		
	///		!x|!y  = result
	///		---------
	///		0|0  = 1
	///		0|1  = 1
	///		1|0  = 1
	///		1|1  = 0

	///	we observer among each table, we have a unique interpretation resulting 0; that's what we remove as a row from a truth table which initially interprets each row as 1.
	///
	/// by product of some maxterm,  we can determine what rows are set 0.
	/// by product of 0 maxterm, no row would be 0; and the result is 1;
	/// by product of all maxterms, all row are 0; and the result is 0;
	///
	/// 
	/// 
	/// </summary>
	public interface IBivariate { }
}
