using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.convert_
{
	/// <summary>
	/// 增元
	/// </summary>
	static public class _AbstraX 
	{
		
		static public FuncI2 Op(FuncI2 arg, nilnul.bit.VarI1 _var)
		{
			nilnul.obj.vow_.False.Vow(arg.pars.contain(_var),"the variable is already included in the sortie");

			return new Func2(
				nilnul.bit._func_.pars._PrependX.Prepend(arg.pars,_var)		
				,
				arg.expr
				
			);
			//throw new NotImplementedException();
		}

		[Obsolete()]
		static public FuncI2 Op_nopIfVarIsAlreadyIncluded(FuncI2 arg, nilnul.bit.VarI1 _var)
		{
			if (arg.pars.contain(_var))
			{
				return arg;
			}

			return new Func2(
				nilnul.bit._func_.pars._PrependX.Prepend(arg.pars,_var)		

				,
				arg.expr
				
			);
			//throw new NotImplementedException();
		}

	}
}
