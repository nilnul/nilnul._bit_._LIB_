using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary
{
	/// <summary>
	/// Alias Max
	/// </summary>
	///
	[Obsolete()]
	public  class Or_defaultCtor:op.BinaryI
	{

				
		static public bool Eval(bool operand1, bool operand2)
		{
			return operand1 || operand2;
		}



		public bool exec(bool a, bool b)
		{
			return Eval(a, b);
			throw new NotImplementedException();
		}

		public bool eval(bool a, bool b)
		{
			return Eval(a, b);
			throw new NotImplementedException();
		}
	}
}
