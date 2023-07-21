using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		capsule
	///			, can be canonical, can replace canonical if it's more efficient, can be replaced by canonical if we find no other efficient capsule
	///			, like "c"losed
	///			, like "component"
	///			
	///		feedthru
	///		lucent
	///		tranparent
	///		blackbox
	///		rejoinder
	///		endogenous
	///		transistor|transitor|trans|transer
	///			like electronic transistor such as MosFet, there is a black box in between, but it can transist electricity thru
	///			
	/// </remarks>
	public interface ICapsule
	{
	}
	public interface CapsuleI
		:ICapsule
		,
		bit.ExprI_generi
		,
		bit.expr_._capsule_.vars_.AsSetI
	{
	}


}
