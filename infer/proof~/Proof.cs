using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit._proof;

namespace nilnul.bit._theorem._proposal
{
	/// <summary>
	/// the precedent, the subsequent, and the reason.
	/// in other words, if we represent a proof:the node:precent, the node1:subseqnet, the rel(node,node1), and the note tagged on the rel. 
	/// </summary>
	/// <remarks>
	/// note: if ()->p or 1->p in theorems, the p is in theorems. So if p and q in theorems,    p^q  isEquivTo 1. so p^q is in theorem. if a letter in theorem, it should be considered a constant, and should not be varied or abstracted, let alone replacing.
	/// 
	/// 
	/// Note: the difference between axiom and inference rules:
	///  p | q = q | p is inference rule;    here p, q can be substitued by any expr.
	///  p|q might be an axiom; here p, q are constancets and cannot be substituted. becuase the p, q are not free here -- p | q must be true so if p=0, q can only be 1.
	/// 
	///  In other words, the variables in theorem, are not in the sameword as the "letters"/"meta-var" in inference rules; the meta var in infrences can be subsitued by any expr to get a new theorm if the being substitued is a theorem. Notice: if the being substited is not a correct inference rule, the the substitued is not necessary theorem; for example, x|y as being substitued, let us substitued x with !z and y with z or !z, the the resulted is not theorem, nor equiv to x|y.
	/// </remarks>
	/// <remarks>
	/// the difference between "=>" and "|="
	///		1)“1=1”可以推出“费马大定理” 中：
	///		1=1 -> "费马大定理" 是重言式，只有在"费马大定理"是定理的情况下；这实际上说明其已经被证。
	///		2) 还有，但并不能说 1=1 |-   “费马大定理”。 注意，这里面|-必须要应用给定的规则。	/// 
	/// 证明分很多步的。	你这一步 应用什么规则 呢？找不到这样的规则吧。只能分成很多步，然后你想想这么多步的每一步是什么就会发现问题。

	/// </remarks>
	public class Proof:ProofI
	{
		public Proof(SequentsI sequents)
		{
			_sequents = sequents;
		}
		private SequentsI _sequents;
		public SequentsI sequents
		{
			get
			{
				return _sequents;
				throw new NotImplementedException();
			}
		}
	}
}
