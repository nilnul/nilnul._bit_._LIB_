using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	/// <summary>
	/// vote(yes0no) on <see cref="bit.expr_.var.set.IBallot"/>
	/// </summary>
	[Obsolete(nameof(nilnul.bit.var.set.state.Interpret))]
	public class Interpretation
	{
		private bit.var.set.Assignment _assignment;

		public bit.var.set.Assignment assignment
		{
			get { return _assignment; }
			set { _assignment = value; }
		}

		private bool _result;

		public bool result
		{
			get { return _result; }
			set { _result = value; }
		}

		public Interpretation(bit.var.set.Assignment assignment, bool result)
		{
			_assignment = assignment;
			_result = result;
		}

		public override string ToString()
		{
			return  $"({assignment})=>{ nilnul.bit.to.ToIntX.ToInt(result)}";
		}

	public   string toTxt_sortVar()
		{
			return  $"({assignment.ToTxtOrdered()})=>{ nilnul.bit.to.ToIntX.ToInt(result)}";
		}
	}
}
