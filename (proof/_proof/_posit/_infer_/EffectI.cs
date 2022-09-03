using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._thesis._proof._infer_
{
	/// <summary>
	/// the premise of a sequent
	/// </summary>
	public interface EffectI{ 
		nilnul.bit.ExprI1 effect { get; }
	}
}
