using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.eq_
{

	/// <summary>
	/// if the new par is the same as old par 
	/// or the new par is free (not occuring) in old expr.
	/// </summary>
	public class Repar : IEqualityComparer<nilnul.bit.FuncI2>
	{
		public bool Equals(FuncI2 x, FuncI2 y)
		{
			if (x.pars.en.Count()==y.pars.en.Count())
			{
				var newPars = nilnul.bit.var.str_.seq_.distinct.constuct_._OfCountX.Construct(x.pars.en.Count());

				return nilnul.bit.expr_.plain.eq_.Equiv.Singleton.Equals(
					nilnul.bit.func.convert_.apply.repeat_.of_._VarsX.Op(
						x
						,
						newPars
					).expr
					,
					nilnul.bit.func.convert_.apply.repeat_.of_._VarsX.Op(
						y
						,
						newPars
					).expr

					
				);
			}
			else
			{
				return false;
			}
			//throw new NotImplementedException();
		}

		public int GetHashCode(FuncI2 obj)
		{
			return 0;
			//throw new NotImplementedException();
		}




		static public Repar Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Repar>.Instance;
			}
		}



	}
}
