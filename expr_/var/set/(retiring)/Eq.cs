using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set
{

	/// <summary>
	/// the eq of the set, not the var.
	/// </summary>

	[Obsolete()]
	public class Eq1:
		nilnul.obj.set.Eq<nilnul.bit.VarI1, nilnul.bit.var.Eq, var.Set2>
			{

		


		static public Eq1 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq1>.Instance;
			}
		}

		
	}
}
