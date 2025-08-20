using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._proof
{
	///pop-sci.com/哥德尔不完全性定理-（一）/
	///作者 ：刘洁民博士
	/// 
	/// 1900年，希尔伯特在第二届国际数学家大会上作了题为《数学问题》的报告:
	///除非它能够从这些公理通过有限步逻辑推理而得到，就不能认为是正确的
	///
	/// 
	/// <summary>
	/// a fininite ordered colection of sequent. a string of sequent.
	/// For a sequents, we have the start state and the end state. (for empty sequents, both states are the same).
	/// The end state must contain the conclusion.
	/// Note each squent transits the state. no sequent means no transit. So seqents is a state transit machine/mechanism.
	/// </summary>
	public interface SequentsI:nilnul.obj.StrI<Sequent>
		//,IEnumerator<Sequent>
		,IEnumerable<Sequent>

	{

		
		
	}

	public class Sequents : SequentsI
	{
		private IEnumerable<Sequent> _enumerable;

		public IEnumerable<Sequent> enumerable
		{
			get { return _enumerable; }
			set { _enumerable = value; }
		}

		public Sequents(IEnumerable<Sequent> enumerable)
		{
			_enumerable = enumerable;
		}


		public IEnumerator<Sequent> GetEnumerator()
		{
			return _enumerable.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
