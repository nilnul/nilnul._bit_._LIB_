using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.abgebra_.nil9xor9and.be_.complete
{

	internal class NonTheorem
	{
		/// we cannot generate <see cref="bit.of_.INary"/>:1 as,
		///		x ^x =0, we can get 0, but 0 is already included, thus it's redundant;
		///		0 ^ 0 =0, 0 & 0 =0. we have no way to get 1;
		///		
		///		(x & y) ^ (x ^y) = x |y. we can get x|y, which is a maxterm of x, with y; but we cannot get 1.
		///
		///		x ^(x|y) =y & !x = y !-> x
		///			, which is not !x
		///		
		///		
		///		

		/// note that in set theory, delta9sect is complete (in fact, a ring, cand derive common set ops: !, &, |, not complete in the same sense) in that:
		///		1) we require it's closed. so,
		///			(x & y) ^ (x ^y) = x |y.
		///			with "|" and closedness, we can get the universal set; note here the universal set is the union of all; it's not 1, or always covers all cases;
		///			
		///			x delta x =0, which is in fact a axiom derivation that 0 is included;
		///			
		///		2) x ^ omega = ~x;
		///		3) ~(~x & ~y) =x|y;
		///		4) we now have ~, |, ^.
		///		5) if our initial els are {0}, the universal set is 0. it's still a common algebra of set; we cannot get a nonempty set.
		
	}
}
