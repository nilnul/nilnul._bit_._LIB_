using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.expr_.PlainI;

namespace nilnul.bit.func.convert_.apply
{
	public class Call
	{
		private nilnul.bit.FuncI2 _func;

		public nilnul.bit.FuncI2 func
		{
			get { return _func; }
			set { _func = value; }
		}

		private E _arg;

		public E arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public Call(nilnul.bit.FuncI2 func, E arg)
		{
			_func = func;
			_arg = arg;
		}

		public override string ToString()
		{

			return $@"({func})({_arg})";
		}

		public nilnul.bit.FuncI2 eval() {
			return _ApplyX.Op(_func,_arg);
		}


	}
}
