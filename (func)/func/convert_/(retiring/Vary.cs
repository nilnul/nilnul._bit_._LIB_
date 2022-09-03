using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.convert_
{
	[Obsolete()]
	public class Vary : ConvertI
	{
		private nilnul.bit.VarI1 _var;

		public nilnul.bit.VarI1 var
		{
			get { return _var; }
			set { _var = value; }
		}

		public Vary(nilnul.bit.VarI1 var)
		{
			_var = var;
		}
		public FuncI1 eval(FuncI1 arg)
		{
			nilnul.obj.vow_.False.Vow(arg.vars.contain(_var),"the variable is already included in the sortie");

			return new Func1(
				arg.vars.cloneAndAppend(_var)		///note, new var is put at the end
				,
				arg.expr
				
			);
			//throw new NotImplementedException();
		}

		public FuncI1 eval_nopIfVarIsAlreadyIncluded(FuncI1 arg)
		{
			if (arg.vars.contain(_var))
			{
				return arg;
			}

			return new Func1(
				arg.vars.cloneAndAppend(_var)		///note, new var is put at the end
				,
				arg.expr
				
			);
			//throw new NotImplementedException();
		}

	}
}
