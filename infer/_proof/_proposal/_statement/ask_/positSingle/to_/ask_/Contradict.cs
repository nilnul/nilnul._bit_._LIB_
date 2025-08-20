using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.proof.be_._valid.ask_.positSingle.to_.ask_
{

	public class Contradict
	{
		static public Ask _Eval(Ask _positSingle) {

			return new Ask(
				new[] {
					_positSingle.antecedent.hashSet.First()
					,
					nilnul.bit.expr_.call_.Mono.CreateNeg(
						_positSingle.conclusion
					)
				}
				,
				nilnul.bit.expr_.call_.No.CreateNil()
			);

		}

	}
}
