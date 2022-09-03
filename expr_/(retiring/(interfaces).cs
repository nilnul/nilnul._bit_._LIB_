using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	
	[Obsolete()]
	public interface LiteralI:AtomI{ }

	[Obsolete()]
	public interface AtomI : NoMonoCallI {

	}

	/// <summary>
	/// atom of notExpr
	/// </summary>
	/// 
	[Obsolete()]
	public interface NoMonoCallI : ExprI_membered {

	}
}
