using nilnul.bit.expr;
using nilnul.bit.var.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr._interpret
{
	/// <summary>
	/// use var.set, not var.sortie
	/// </summary>
	/// <remarks>
	/// <see cref="nameof(set.TruthTable)"/>
	/// </remarks>
	[Obsolete(nameof(bit.expr_.closed._ReifyX))]

	[
		PartialImplementation(
			nameof( nilnul.bit.vars.assignment.interpretations.TruthTable)
		)
	]
	public class Tabuleau

	{


		private nilnul.bit.var.Set2 _vars;

		public nilnul.bit.var.Set2 vars
		{
			get { return _vars; }
			//set { _vars = value; }
		}

		private Dictionary<nilnul.bit.var.set.Ballot,bool> _interprets;

		public Dictionary<nilnul.bit.var.set.Ballot,bool> interprets
		{
			get { return _interprets; }
			//set { _interprets = value; }
		}


		private nilnul.bit.expr._interpret.row.be_.ofVars.Vow _interpretAvowGivenVars;

		public nilnul.bit.expr._interpret.row.be_.ofVars.Vow interpretAvowGivenVars
		{
			get { return _interpretAvowGivenVars; }
			//set { _interpretAvowGivenVars = value; }
		}


		public Tabuleau(nilnul.bit.var.Set2 vars , IEnumerable<nilnul.bit.expr._interpret.Row> interprets)
		{
			_vars = vars;

			_interprets = new Dictionary<Ballot, bool>(
				new nilnul.bit.var.set.ballot.co_.sameKeys.be_.SameVals(_vars)
			);
			_interpretAvowGivenVars = new nilnul.bit.expr._interpret.row.be_.ofVars.Vow(_vars);



			foreach (var item in interprets)
			{
				_interpretAvowGivenVars.vow(item);

				_interprets.Add(
					item.state
					,
					item.result
					
				);

			}
		}
	}
}
