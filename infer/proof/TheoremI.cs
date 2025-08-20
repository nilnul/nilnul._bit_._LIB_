using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.proof
{
	/// <summary>
	/// theorem is a vowed proposal(thesis)
	/// we say theorem holds; we don't say theorem is true. 'cuz with a self-contradictory axiom such as X and NotX, we can prove a false statement such as X and NotX.
	/// 
	/// Theorem is dependent on axioms.
	/// So we say axioms proves(⫢) the theorem. Note, with self-contradictory axioms, we can prove any as theorem
	/// </summary>
	public interface TheoremI:_theorem_.AllI
	{

	}
}
