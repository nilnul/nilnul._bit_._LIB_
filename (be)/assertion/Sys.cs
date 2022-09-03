using nilnul.bit.var.expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Expr = nilnul.bit.var.expr.ExprI;

namespace nilnul.bit.assertion
{
	public partial class Sys
	{
		private HashSet<var.VarI> _symbols;

		public HashSet<var.VarI> symbols
		{
			get { return _symbols; }
			set { _symbols = value; }
		}

		private HashSet<var.expr.ExprI> _axioms;

		public HashSet<var.expr.ExprI> axioms
		{
			get { return _axioms; }
			set { _axioms = value; 
				///todo: axioms must be express of those symbols.
			}
		}

		public var.expr.ExprI Axiom0(var.expr.ExprI a,var.expr.ExprI b ) {

			return new var.expr.Imply(a, new var.expr.Imply(a, b));
		
		
		}

		public var.expr.ExprI Axiom1(var.expr.ExprI a, var.expr.ExprI b, var.expr.ExprI c)
		{

			return var.expr.Imply.Call(
				var.expr.Imply.Call(
					a,
					var.expr.Imply.Call(b, c)
				)
				,
				var.expr.Imply.Call(
					var.expr.Imply.Call(a, b)
					,
					var.expr.Imply.Call(a, c)

				)
			);


		}

		public var.expr.ExprI Axiom2(var.expr.ExprI a, var.expr.ExprI b)
		{

			return var.expr.Imply.Call(
				var.expr.Imply.Call(
					 new var.expr.Negate( a),
					new var.expr.Negate(b)
				)
				,
				var.expr.Imply.Call(
					b
					,
					a
				)
			);

		}

		public bool isAxiom0(Imply a) {

			var aConsequent=a.consequent;
			if (aConsequent is Imply)
			{
		 
			}


			throw new NotImplementedException();
			
		}



		public var.expr.ExprI rule(var.expr.ExprI a, var.expr.Imply b) {

			if (b.precedent==a)
			{
				return b.consequent;
				
			}
			throw new Exception("no such rule");
		
		}

		public bool isAProof(Expr a) {
			throw new NotImplementedException();
		
		}

		public bool isAProof(
			List<Expr> exprs	
		) {


			throw new NotImplementedException();
		}



		
		
	}
}
