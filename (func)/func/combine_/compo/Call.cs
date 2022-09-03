using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.expr_.PlainI;
using F = nilnul.bit.FuncI2;

namespace nilnul.bit.func.combine_.compo
{
	public class Call
	{
		private nilnul.bit.FuncI2 _func;

		public nilnul.bit.FuncI2 func
		{
			get { return _func; }
			set { _func = value; }
		}

		private F _arg;

		public F arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public Call(nilnul.bit.FuncI2 func, F arg)
		{
			_func = func;
			_arg = arg;
		}

		public override string ToString()
		{

			return $@"({func})({_arg})";
		}

		public nilnul.bit.FuncI2 eval() {
			return _CompoX.Op(_func,_arg);
		}


	}
}
