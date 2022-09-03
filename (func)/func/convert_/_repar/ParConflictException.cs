using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.convert_._repar
{

	/// <summary>
	/// when newPar is conflicted with current bound vars or unboundVars
	/// </summary>
	[Serializable]
	public class ParConflictException : Exception
	{
		public ParConflictException() { }
		public ParConflictException(string message) : base(message) { }
		public ParConflictException(string message, Exception inner) : base(message, inner) { }
		protected ParConflictException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
