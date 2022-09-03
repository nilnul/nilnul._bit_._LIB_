using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op
{
	public partial class Assert
	{

		static public void Eval(bool val) {
			if (!val)
			{
				throw new AssertException();
				
			}
		}
		static public void Eval<T>(T val, Func<T,bool> func) {

			nilnul.bit.Assertion.True(func(val));
		
		}

		static public void Eval_dual<T>(T val, Func<T, bool> func) {
			Eval(val, x => !func(x));
		
		}

		[Serializable]
		public class AssertException : Exception
		{
			public AssertException() { }
			public AssertException(string message) : base(message) { }
			public AssertException(string message, Exception inner) : base(message, inner) { }
			protected AssertException(
			  System.Runtime.Serialization.SerializationInfo info,
			  System.Runtime.Serialization.StreamingContext context)
				: base(info, context) { }
		}
	}
}
