using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.bit.var.set.state.interpret.be_
{
	[Obsolete()]
	public class OfGivenVars : BeI
	{
		private nilnul.bit.var.Set1 _vars;

		public nilnul.bit.var.Set1 vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		public OfGivenVars(nilnul.bit.var.Set1 vars)
		{
			_vars = vars;
		}
		public bool be(Interpret obj)
		{
			return nilnul.obj.var.set.Eq.Lazy.Equals(_vars,obj.state.Keys);
			//throw new NotImplementedException();
		}

		public class Avow : nilnul.obj.be.Avow1<Interpret>
		{
			public Avow(nilnul.bit.var.Set1 vars) : base(new OfGivenVars(vars))
			{
			}
		}
	}
}
