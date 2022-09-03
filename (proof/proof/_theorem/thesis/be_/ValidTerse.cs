using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._theorem.proposal.be_
{
	/// <summary>
	/// if the consequent is already in the set of lemma, the remaining sequents are not necessary and shall be removed.
	/// if the succesant of a sequent is already in the set of lemma, that sequent is not necessary, and shall be removed..
	/// 
	/// 
	/// 除了要求证明有效外，我们还通常要求证明简洁。
	///		如果推断中已经含有 结论，则后续的语句都不必需要了，这样可以避免累赘；
	///		如果推断中 得到的 result在 lemma中已经出现过，则该条语句应该删除，这样可以避免重复; 
	///		如果从结论 中 向前倒推，只留下必须的语句， 这样可以去掉无关的语句。
	/// 
	/// </summary>
	public class ValidAndTerse
	{

	}
}
