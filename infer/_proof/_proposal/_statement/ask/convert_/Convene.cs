using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.proof.be_._valid.ask.convert_
{
	public class ConvenePresumption
	{
		static public Ask Eval(Ask ask) {
			return new Ask(

				new expr.Set1(
					new[] {
						nilnul.bit.expr.aggregate_.Conjunct.Eval(
							ask.antecedent
						)
					}
				)
				,ask.conclusion
				
			);
		}
	}
}
