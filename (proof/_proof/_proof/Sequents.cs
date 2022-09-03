using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._proof
{
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
