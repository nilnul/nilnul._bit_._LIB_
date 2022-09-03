using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.phrase_
{
	/// <summary>
	/// x2=>x1=>x=>expr
	/// </summary>
	static public class _EmbeddedX
	{
		static public string Phrase(nilnul.bit.FuncI2 func) {


			return $@"{
				string.Join(
					"", 
					func.pars.en.Select(
						x=>$"{x}{nilnul.obj._func_.GoesToSymbol.DEFAULT}"
					)
				)
			}{
				nilnul.obj._func_.GoesToSymbol.DEFAULT
			}{
				func.expr
			}
			";

		}
	}
}
