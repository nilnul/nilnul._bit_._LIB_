using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	[Obsolete()]
	public interface VarI1:nilnul.VarI1<bool>, nilnul.obj.VarI1,nilnul.obj.VarI5<bool>
	{

	}

	[Obsolete()]
	public abstract class VarA1
:  nilnul.obj.Var,
		
		VarI1

	{

		//public override string ToString()
		//{
		//	return nilnul.obj.var.set.NamingContext.Instance.getEnsuredName(this);
		//}

	}


	[Obsolete()]
	public class Var2:VarA1
	{


	}

	



}
