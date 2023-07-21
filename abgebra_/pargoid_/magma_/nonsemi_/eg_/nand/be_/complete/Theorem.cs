using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.abgebra_.nand.be_.complete
{

	internal class Theorem
	{
		///	we can generate <see cref="bit.of_.unary_"/>|<see cref="bit.op_.unary_.Not1"/>:
		///		x nand x =!x
		///		
		/// we can generate <see cref="bit.of_.INary"/>:0 by:
		///		!x nand x =1, (note here we apply the projection operator; just image that we give two incoming wires or in fact we can disregard or ommit the two incoming wires and leave the receiving pins untended, and the output wire keep outputting 1 constantly, and that can be taken as a constant);
		///				in other words, the els can have 0, or 1 at random; we just disregard the input;
		///		!(1 ) = 0
		///		
		///	we can geneate <see cref="bit.op_.binary_.And"/>:
		///		!(x nand y) =  x and y
		///		
		///	we can geneate <see cref="bit.op_.binary_.Or"/>:
		///		!(!x and !y) =  x or y
		///		
		/// then we can generate any;

	}
}
