using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._thesis._proof._inference_
{
	/// <summary>
	/// the premise of a sequent
	/// </summary>
	public interface ConsequentI{ 
		nilnul.bit.ExprI1 consequent { get; }
	}
}
