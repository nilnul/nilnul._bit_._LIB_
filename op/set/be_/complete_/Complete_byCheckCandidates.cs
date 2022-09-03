using nilnul.obj.seq_.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.set.be_
{
	/// <summary>
	/// there must be one binary_op, or else it's not complete.
	/// If it includes all binary_.op, then it's complete; <see cref="nilnul.bit.expr_.closed_.canonic.op_.of_.OfClosed"/>
	/// </summary>
	static public class _Complete_byCheckCandidatesX
	{
		static public bool IsComplete_assumeArityLeTwo(IEnumerable<bit.OpI2> ops) {
			if (ops.None(
				o=> o is nilnul.obj.op_.BinaryI<bool>
			))
			{
				return false;

			}



			// try to add each biop from #0 to #15
			foreach (var item in op_.binary.sortie_.Sorted.All)
			{
				// imagine the two inputs for the item
				//x , y
				// with the item, x (op) y
				/// can be expressed by other ops.
				/// the expression can be a unary expression. So we try different unary ops from the current unary opSet.
				/// the expression can be binary expression.
				/// the expression cannot be nary expression, as we need two inputs. (some input can be nary.)
				///
				/// let's start with the unary. the input of the unary has to be a bivariate expr. ,the truthtable has to be the negation of expected one.
				///			we then try to add that candidate; that candidate is not the same as current item. It might be already in current ops, or we need to find that one.
				///
				/// let's then proceed with the binary. 

			}

		}
	}
}
