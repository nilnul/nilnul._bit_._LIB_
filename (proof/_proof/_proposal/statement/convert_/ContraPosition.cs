using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._proposal.statement.convert_
{
	public class ContraPosition
	{

		static public statement_.MultiHypothesis Eval(_proposal.StatementI original) {
			return statement_.MultiHypothesis.CreatePositSingle(
				nilnul.bit.expr_.call_.Mono.CreateNeg(
					original.consequent
				)
				,
				nilnul.bit.expr_.call_.Mono.CreateNeg(
					original.antecedent
				)
			);
		}
	}
}
