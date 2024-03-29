﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	/// <summary>
	/// x >=y
	/// , means y -> x.
	/// 
	/// </summary>
	/// <remarks>
	/// converse of <see cref="binary_.Le"/>;
	/// </remarks>
	/// alias:
	///		since
	///		becuz
	///		as long as
	///		on condition that
	///		if
	///			,
	///			<see cref="binary_.Le"/> is "then"
	///		when
	///		whence
	///		
	///		
	public class Ge : BinaryI, BinaryI1
		,
		IBivariate
	{
		public bool op(bool par, bool par1)
		{
			return Gt.Singleton.op(par,par1) || Iff.Singleton.op(par,par1);
			//throw new NotImplementedException();
		}

		public const string TXT = ">=";
		public override string ToString()
		{
			return TXT;
		}


		static public Ge Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ge>.Instance;
			}
		}

	}
}
