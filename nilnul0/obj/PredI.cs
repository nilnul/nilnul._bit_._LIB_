using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TInput"></typeparam>
	/// <typeparam name="TOutput"></typeparam>
	/// <remarks>
	///see: propostion, proof
	/// </remarks>
	public interface PredI<TInput, TOutput>
		:_pred_.InputI<TInput>
		,
		_pred_.OutputI<TOutput>
		where TOutput: nilnul.bit._expr_.BlankI
		where TInput: nilnul.obj._func._input_.BlankI

	{
	}
}
