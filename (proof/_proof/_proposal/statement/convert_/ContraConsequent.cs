using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._proposal.statement.convert_
{
	public class ToBeProvenByContradiction
	{

		static public statement_.ContraConsequent Eval(_proposal.StatementI original) {
			return new statement_.ContraConsequent(
				original
			);
		}
	}
}
