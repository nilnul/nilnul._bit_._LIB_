using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	
	/// 
	[Obsolete(nameof(nilnul.bit._theorem._proposal.Proof))]

	public class Proof
	{
		private IEnumerable<_proof.RuleI> _rules=new List<_proof.RuleI>();

		public IEnumerable<_proof.RuleI> rules
		{
			get { return _rules; }
			set { _rules = value; }
		}

	}

	/*
	 to get a proof, we can 
	 1) deduce, that is, start from the presumption to get the verdict
	 or 2) reduce, that is, start from the verdict to retrospect to the presumption
	 or 3) use both.
	 */
}
