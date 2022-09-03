using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.convert_
{
	public class Abstra : ConvertI1
	{
		private nilnul.bit.VarI1 _var;

		public nilnul.bit.VarI1 var
		{
			get { return _var; }
			set { _var = value; }
		}

		public Abstra(nilnul.bit.VarI1 var)
		{
			_var = var;
		}
		public FuncI2 op(FuncI2 arg)
		{
			

			return _AbstraX.Op(arg,_var);
			//throw new NotImplementedException();
		}

		

	}
}
