using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func_.unary.apply.of.duo_
{
	/// <summary>
	/// if
	///		expr1==expr2	
	/// then
	///		(x=>expr )(expr1)  == 
	///		(x=>expr)(expr2) 
	///		
	/// </summary>
	public class Equiv
	{
		private nilnul.bit.FuncI2 _func;

		public nilnul.bit.FuncI2 func
		{
			get { return _func; }
			set { _func = value; }
		}

		private nilnul.bit.expr_.plain.duo_.Equiv _equiv;

		public nilnul.bit.expr_.plain.duo_.Equiv equiv
		{
			get { return _equiv; }
			set { _equiv = value; }
		}



		public nilnul.bit.func.convert_.apply.Call of=> new func.convert_.apply.Call(_func, _equiv.item);
		public nilnul.bit.func.convert_.apply.Call of1=> new func.convert_.apply.Call(_func, _equiv.item1);



	}
}
