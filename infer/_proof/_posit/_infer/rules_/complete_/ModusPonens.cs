using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._thesis._proof._infer.rules_.complete_
{
	/// <summary>
	/// the rule set of a single ModusPonens is complete in that:
	/// if(a -> b) then
	/// a |= b
	/// doesn't throw exception.
	/// 
	/// because: 
	/// 
	/// inside the block following "if(a -> b)", a -> b is assumed true. and in a |- b, we assumed a is true. so the assumptions are {a, a -> b}
	/// to prove a |- b, we have:
	///		a , a -> b  therefore(by applying modus ponens) b
	///		q.e.d.
	///		
	/// in addition,
	/// if (a -> b) then
	///		|= a -> b
	///	also holds, we a -> b is assumed. and we can have an empty proof (the length of the str of inferences is 0) to prove a -> b.
	///
	///
	/// 
	/// </summary>
	public class ModusPonens
	{
	}
}
