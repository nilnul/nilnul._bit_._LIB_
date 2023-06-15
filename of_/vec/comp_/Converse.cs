using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.of_.vec.comp_
{
	/// <summary>
	/// just view its truth table.
	/// </summary>
	public class Converse :
		nilnul.obj.comp.converse_.ComparerDefault< op_.BinaryI1, binary.Comp>
		,
		IComparer<nilnul.bit.op_.BinaryI1>
	{
		


		static public Converse Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Converse>.Instance;
			}
		}

	}
}
