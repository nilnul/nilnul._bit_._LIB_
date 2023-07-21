using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.var.set.allot
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		
	public class Vote
		:
		set.sel.IVote
	{
		private bit.expr_.var.set.Allot _state;

		public bit.expr_.var.set.Allot state
		{
			get { return _state; }
			set { _state = value; }
		}

		private bool _result;

		public bool result
		{
			get { return _result; }
			set { _result = value; }
		}

		public Vote(bit.expr_.var.set.Allot state, bool result)
		{
			_state = state;
			_result = result;
		}

		public Vote(KeyValuePair<bit.expr_.var.set.Allot, bool> a):this(a.Key,a.Value)
		{
		}

		public override string ToString()
		{
			return  $"({state})=>{ nilnul.bit.to.ToIntX.ToInt(result)}";
		}

	
	}
}
