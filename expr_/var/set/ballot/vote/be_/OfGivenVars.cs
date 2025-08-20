using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.bit.expr._interpret.row.be_
{

	public class OfGivenVars : BeI
	{
		private nilnul.bit.var.Set2 _vars;

		public nilnul.bit.var.Set2 vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		public OfGivenVars(nilnul.bit.var.Set2 vars)
		{
			_vars = vars;
		}
		public bool be(Row obj)
		{
			return nilnul.obj.var.set.Eq.Lazy.Equals(_vars,obj.state.Keys);
			//throw new NotImplementedException();
		}

		
	}
}
