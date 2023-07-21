using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_
{
	public interface BinaryI1
		:OpI2, 
		nilnul.obj.op_._binary_.par1_.retParPar1_.ClosedI<bool>
		,
		nilnul.obj.op_.BinaryI<bool>
		//,
		//nilnul.bit.op_.BinaryI1
	{
	}
	/*
	 there are 16 binary ops, which fall into the following few categories:
		1) invariate (variate upon 0 vars):
			nil.
				regardless of inputs, that is, 0-variate, output 0
			nil.dual, aka one
				output 1 regardless of inputs
		2) univariate:
			2.1)
				2.1.1) head:
					regardless of the last component of the input, output the first input
				2.1.2) toe:
					regardless of the first component of the input, output the first input.
			2.2) the dual of the above.
				2.2.1) negHead
				2.2.2) negToe
			2.3) so we have 4 univariate op
		3) comparision of the two (two, not one, determines the output): so this is bivariate
			3.1)
				3.1.1) min
				3.1.2) max
				3.1.3) lt
				3.1.4) le
				3.1.5) eq
			3.2) the dual of the above
				3.2.1) negMin
				3.2.2) negMax
				3.2.3) ge
				3.2.4) gt
				3.2.5) ne
			3.3) so we have 10 bivariate 
			
	 */
	
}
