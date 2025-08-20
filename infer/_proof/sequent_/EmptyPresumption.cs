using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._proposal._proof.sequent_
{
	/// <summary>
	/// note: if the presumption is empty, the finding has to be true in order to make this sequent valid(A=>B is tauto). This means you can always introduce true statement for empty presumption is alwasy the subset of the  "postulate" that is augmented during the process of proof.
	/// </summary>
	public interface EmptyPresumptionI
	{
	}
}
