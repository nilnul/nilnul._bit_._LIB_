using nilnul.bit.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.state.interpret
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <see cref="nameof(set.TruthTable)"/>
	/// </remarks>
	[
		PartialImplementation(
			nameof( nilnul.bit.vars.assignment.interpretations.TruthTable)
		)
	]
	[Obsolete(nameof( nilnul.bit.vars.assignment.interpretations.TruthTable))]
	public class TruthTable

	{


		private nilnul.bit.var.Set1 _vars;

		public nilnul.bit.var.Set1 vars
		{
			get { return _vars; }
			//set { _vars = value; }
		}

		private Dictionary<nilnul.bit.var.set.State,bool> _interprets;

		public Dictionary<nilnul.bit.var.set.State,bool> interprets
		{
			get { return _interprets; }
			//set { _interprets = value; }
		}


		private nilnul.bit.var.set.state.interpret.be_.OfGivenVars.Avow _interpretAvowGivenVars;

		public nilnul.bit.var.set.state.interpret.be_.OfGivenVars.Avow interpretAvowGivenVars
		{
			get { return _interpretAvowGivenVars; }
			//set { _interpretAvowGivenVars = value; }
		}


		public TruthTable(nilnul.bit.var.Set1 vars , IEnumerable<Interpret> interprets)
		{
			_vars = vars;

			_interprets = new Dictionary<State, bool>(
				new nilnul.bit.var.set.state.eq_.sameVars.SameVals(_vars)
			);
			_interpretAvowGivenVars = new be_.OfGivenVars.Avow(_vars);



			foreach (var item in interprets)
			{
				_interpretAvowGivenVars.avow(item);

				_interprets.Add(
					item.state
					,
					item.result
					
				);

			}
		}
	}
}
