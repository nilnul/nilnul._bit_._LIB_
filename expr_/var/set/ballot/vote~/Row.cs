using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr._interpret
{
	/// <summary>
	/// vote(yes0no) on <see cref="bit.expr_.var.set.IBallot"/>
	/// </summary>

	[Obsolete(nameof(bit.expr_.var.set.allot.Vote))]
	public class Row
	{
		private bit.var.set.Ballot _state;

		public bit.var.set.Ballot state
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

		public Row(bit.var.set.Ballot state, bool result)
		{
			_state = state;
			_result = result;
		}

		public Row(KeyValuePair<bit.var.set.Ballot, bool> a):this(a.Key,a.Value)
		{
		}

		public override string ToString()
		{
			return  $"({state})=>{ nilnul.bit.to.ToIntX.ToInt(result)}";
		}

	
	}
}
