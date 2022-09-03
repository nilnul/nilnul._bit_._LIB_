using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr._ident
{
	public  class Ident
	{
		protected ExprI_membered _precedent;
		public ExprI_membered precedent
		{
			get {
				return _precedent;
			}
			protected set
			{
				_precedent = value;
			}
		}


		protected ExprI_membered _subsequent;
		public ExprI_membered subsequent
		{
			get {
				return _precedent;
			}
			protected set
			{
				_precedent = value;
			}
		}


		public Ident(
			E p
			,
			E s
			
		)
		{
			_precedent = p;
			_subsequent = s;

			assert();
		}

		protected Ident()
		{

		}


		public ExprI_membered tauto {
			get {
				return nilnul.bit.expr.duo.Call.CreateEq(

					precedent
					,
					subsequent
				);

			}
		}

		
		public void assert()
		{
			nilnul.bit.expr.Tauto.Assert(tauto);
		}
	}
}
