using nilnul.bit.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set
{
	[Obsolete(nameof(nilnul.bit.var.set.state.interpret.TruthTable))]
	public class TruthTable

	{
		private IEnumerable<VarI1> _vars;
		public IEnumerable<VarI1> vars
		{
			get { return _vars; }
		}

		//private nilnul.bit.var.Set _vars;

		//public nilnul.bit.var.Set vars
		//{
		//	get { return _vars; }
		//	private set { _vars = value; }
		//}


		private IEnumerable<bool> _results;


		/// <summary>
		/// the results; the result column of the truth table;
		/// </summary>
		public IEnumerable<bool> results
		{
			get { return _results; }
			private set { _results = value; }
		}



		public TruthTable(IEnumerable<VarI1> vars_orderSignificat
					, bool[] results
				)
		{

			nilnul.Assert1.True(
				results.Count() == 1 << vars_orderSignificat.Count()
			);

			_vars = vars_orderSignificat;
			_results = results;

		}


		public TruthTable(nilnul.bit.var.Set vars
			, bool[] results
		) : this(vars as IEnumerable<VarI1>, results)
		{


		}



		public TruthTable(
			nilnul.bit.var.Set vars
			, IEnumerable<bool> results
		)
		{

			nilnul.Assert1.True(
				results.Count() == (1 << vars.Count)
			);

			_vars = vars;
			_results = results;


		}

		public TruthTable(
			IEnumerable<VarI1> vars
			, IEnumerable<bool> results
		)
		{

			nilnul.Assert1.True(
				results.Count() == (1 << vars.Count())
			);

			_vars = vars;
			_results = results;


		}   /// <summary>
			/// ordered
			/// </summary>
			/// <returns></returns>
		public IEnumerable<Interpretation> getInterpretatios()
		{

			return nilnul.bit.var.set.Assignment._Enumerate(this.vars).Zip(
				_results
				, (vals, result) => new Interpretation(
					  set.Assignment._Create__sameCount(vars, vals),
					 result
				 )
			);


		}
		[Obsolete(" the following is wrong in that results is not sorted accoordingly.", true)]
		public IEnumerable<Interpretation> getInterpretatios_sorted()
		{


			#region the following is wrong in that results is not sorted accoordingly.

			#endregion

			throw new NotImplementedException();
			//var varsOrdered = _vars.OrderBy( a=>a,nilnul.obj.var.comparer_.FroNaming.Lazy);



			//return nilnul.bit.var.set.Assignment._Enumerate(varsOrdered).Zip(
			//	_results
			//	, (vals, result) => new Interpretation(
			//		  set.Assignment._Create__sameCount(varsOrdered, vals),
			//		 result
			//	 )
			//);


		}

		public override string ToString()
		{
			var interpretations = getInterpretatios();
			return nilnul.str.ToTxtX.ToTxt1(interpretations, ",");
			//return nilnul.str.ToTxtX.ToTxt1(interpretations,nilnul.Txt.WindowLineBreak_byEnv);


		}
		public string toTxt(string lineSeperator)
		{
			var interpretations = getInterpretatios();
			return nilnul.str.ToTxtX.ToTxt1(interpretations, lineSeperator);
			//return nilnul.str.ToTxtX.ToTxt1(interpretations,nilnul.Txt.WindowLineBreak_byEnv);


		}
		public string toTxt_sortVars(string lineSeperator)
		{
			var interpretations = getInterpretatios();
			return nilnul.str.ToTxtX.ToTxt1(interpretations, lineSeperator);
			//return nilnul.str.ToTxtX.ToTxt1(interpretations,nilnul.Txt.WindowLineBreak_byEnv);


		}
		public string toTxt_inLines()
		{

			return toTxt(Environment.NewLine);


		}

		public string toTxt_inLines_sortVars()
		{

			return toTxt_sortVars(Environment.NewLine);


		}
		static public TruthTable Create(IEnumerable<VarI1> vars, IEnumerable<bool> results)
		{

			return new TruthTable(
				 vars
				,
				results
			);
		}






	}
}
