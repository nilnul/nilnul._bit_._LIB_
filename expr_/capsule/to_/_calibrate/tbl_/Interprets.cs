using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.sortedSet.state_.fixedVars
{
	public class Interprets
	{
		private SortedDictionary<nilnul.bit.var.sortedSet.State,bool> _dict;

		public SortedDictionary<nilnul.bit.var.sortedSet.State,bool> dict
		{
			get { return _dict; }
			//set { _dict = value; }
		}

		private nilnul.bit.var.sortedSet.state.be.aver_.OfGivenVars _aver;

		public nilnul.bit.var.sortedSet.state.be.aver_.OfGivenVars aver
		{
			get { return _aver; }
			//set { _aver = value; }
		}


		public Interprets( nilnul.bit.var.SortedSet vars):base(
			
		)
		{

			_dict = new SortedDictionary<State, bool>( 
				new nilnul.bit.var.sortedSet.state_.fixedVars.Comparer(vars)
			);

			_aver = new state.be.aver_.OfGivenVars(vars);

		}

		public void add(nilnul.bit.var.sortedSet.State state, bool ret) {

			_aver.aver(state);

			_dict.Add(state, ret);
		}

	}
}
