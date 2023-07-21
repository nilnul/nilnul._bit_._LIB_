using System.Collections.Generic;
using nilnul.bit.expr.set.call;

namespace nilnul.bit.expr.infer._deduce
{
	public  class Deduce
	{
		protected nilnul.bit.expr.set.call.Conjunct _evidence;

		public nilnul.bit.expr.set.call.Conjunct evidence
		{
			get { return _evidence; }
			protected set { _evidence = value; }
		}


		protected ExprI_membered _conclusion;

		public ExprI_membered conclusion
		{
			get { return _conclusion; }
			protected set { _conclusion = value; }
		}

		public Deduce(
			Conjunct evidence
			,
			ExprI_membered conclusion
		)
		{
			_evidence = evidence;
			_conclusion = conclusion;
		}

		public Deduce()
		{

		}

		public nilnul.bit.expr._infer.Infer toInfer() {
			return new _infer.Infer(
				_evidence.toExpr()
				,
				_conclusion
			);
		}
		public void assert() {

			nilnul.bit.expr.Tauto.Assert(toInfer().tauto);

		}

		public override string ToString()
		{
			return $"{ _evidence.ToString() }=>{_conclusion.ToString()}"				;
		}

	}
}