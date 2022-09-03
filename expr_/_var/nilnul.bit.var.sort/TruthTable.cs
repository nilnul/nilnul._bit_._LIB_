using nilnul.bit.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.toset
{
	public class TruthTable

	{
		private nilnul.bit.var.stati.str.be.Distinct.Asserted _vars;

		public nilnul.bit.var.stati.str.be.Distinct.Asserted vars
		{
			get { return _vars; }
			private set { _vars = value; }
		}

		private IEnumerable<bool> _results;

		public IEnumerable<bool> results
		{
			get { return _results; }
			private set { _results = value; }
		}

		public TruthTable(nilnul.bit.var.stati.str.be.Distinct.Asserted vars
			,bool[] results	
		)
		{

			nilnul.Assert.True(
				results.Count() == 1 << vars.length
			);

			_vars = vars;
			_results = 	results;
			
		}



		public TruthTable(
			nilnul.bit.var.stati.str.be.Distinct.Asserted vars
			, IEnumerable< bool> results	
		)
		{

			nilnul.Assert.True(
				results.Count() == 1 << vars.length
			);

			_vars = vars;
			_results = 	results;


		}

		public IEnumerable<Interpretation> getInterpretatios() {
			return 	nilnul.bit.var.toset.Assignments.Enumerate(_vars).Zip(
				_results
				,(vals,result)=> new Interpretation(
					 set.Assignment._Create__sameCount( vars,vals),
					result
				) 
			);

			
		}

		static public TruthTable Create(IEnumerable<var.stati.Stati> vars, IEnumerable<bool> results) {

			return new TruthTable(
				new stati.str.be.Distinct.Asserted(vars)
				,
				results
			);
		}

	




	}
}
