using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.capsule_
{
	/// <summary>
	/// not only var is each/every of type bit, but also each subexpression in between is of type bit.
	/// </summary>
	/// <remarks>
	/// donot open the capsule; let the capusle inherit <see cref="expr_.IClosed"/>, then the capsule would become closed.
	/// eg:
	///		<see cref="expr_.capsule_.std_._prod.IMaxterm"/>, as itself is closed, the process can be capsuled, the input is <see cref="IClosed"/>
	///		as long as we don't let the str of valves inherit <see cref="IClosed"/>
	/// </remarks>
	public interface IClosed:ICapsule
	{
	}

}
