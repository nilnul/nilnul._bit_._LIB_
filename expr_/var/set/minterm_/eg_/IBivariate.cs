namespace nilnul.bit.expr_.var.set.minterm_.eg_
{
	/// <summary>
	/// let n be the count of vars:
	///		the the count of maxterms is 2^n
	///
	///	when n=2, we have 2^2 maxterms:
	///		
	///		x&y  = result
	///		---------
	///		0&0  = 0
	///		0&1  = 0
	///		1&0  = 0
	///		1&1  = 1
	///
	///		x&!y  = result
	///		---------
	///		0&!0  = 0
	///		0&!1  = 0
	///		1&!0  = 1
	///		1&!1  = 0
	///		
	///		!x&y  = result
	///		---------
	///		!0&0  = 0
	///		!0&1  = 1
	///		!1&0  = 0
	///		!1&1  = 0
	///		
	///		!x&!y  = result
	///		---------
	///		!0&!0  = 1
	///		!0&!1  = 0
	///		!1&!0  = 0
	///		!1&!1  = 0

	///	we observer among each table, we have a unique interpretation resulting 1; that's what we add as a row to a truth table, which initally interprets each as 0;
	///
	/// by sum of some minterm,  we can determine what rows are set 1.
	/// by sum of 0 minterm, no row would be 1; and the result is 0;
	/// by summing of all minterms, all row are1; and the result is 1;
	///
	/// 
	/// 
	/// </summary>
	public interface IBivariate { }
}
