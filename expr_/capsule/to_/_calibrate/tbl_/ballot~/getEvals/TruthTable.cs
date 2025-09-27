using nilnul.bit.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.sort
{

	[Obsolete(nameof(expr_.var.sortie.sels_.omni.IPoll))]

	public class TruthTable

	{
		private nilnul.bit.var.sortedSet.be.Distinct.Asserted _vars;

		public nilnul.bit.var.sortedSet.be.Distinct.Asserted vars
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

		public TruthTable(nilnul.bit.var.sortedSet.be.Distinct.Asserted vars
			,bool[] results	
		)
		{

			nilnul.Assert1.True(
				results.Count() == 1 << vars.length
			);

			_vars = vars;
			_results = 	results;
			
		}



		public TruthTable(
			nilnul.bit.var.sortedSet.be.Distinct.Asserted vars
			, IEnumerable< bool> results	
		)
		{

			nilnul.Assert1.True(
				results.Count() == 1 << vars.length
			);

			_vars = vars;
			_results = 	results;


		}

		public IEnumerable<Interpretation> getInterpretatios() {
			return 	nilnul.bit.var.set.Assignment._Enumerate(_vars.val).Zip(
				_results
				,(vals,result)=> new Interpretation(
					 nilnul.bit.var.set.Assignment._Create__sameCount( vars,vals),
					result
				) 
			);

			
		}

		static public TruthTable Create(IEnumerable<bit.VarI1> vars, IEnumerable<bool> results) {

			return new TruthTable(
				new bit.var.sortedSet.be.Distinct.Asserted(vars)
				,
				results
			);
		}

	




	}
}
