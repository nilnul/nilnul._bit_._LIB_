using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.set_.complete_.singular_.xpn_
{
	/// <summary>
	/// we cannot derive a "not" from xor.
	/// </summary>
	[Serializable]
	public class XorException : Exception
	{
		public XorException() { }
		public XorException(string message) : base(message) { }
		public XorException(string message, Exception inner) : base(message, inner) { }
		protected XorException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	} 
	
}
