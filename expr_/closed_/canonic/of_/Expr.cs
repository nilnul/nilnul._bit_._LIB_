using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI2;
using C = nilnul.bit.var.poll.minterm.set_.sameVars.CanonicalI;

namespace nilnul.bit.var.poll.minterm.set_.sameVars.canonical.construct_
{
	 public class Expr:ConstructI<E>
	{
		 public CanonicalI op(E expr)
		{
			switch (expr)
			{
				case expr_.Var var:
					return Op(var);

				default:
					break;
			}
			///switch case
			throw new NotImplementedException();
		}

		static public C Op(nilnul.bit.expr_.Var var)
		{
			///v
			///	Sigma( Pi(v))
			throw new NotImplementedException();
		}

		static public C Op(nilnul.bit.expr_.call_.No nullary)
		{
			/// 1
			///   sigma()
			/// 0
			///		sigma( Pi())
			throw new NotImplementedException();
		}

		static public C Op(nilnul.bit.expr_.call_.Mono unary) {
			///for not(E)
			///	convert E to RetI R
			///	then !R = !(Sigma(minterms))  = Pi (!mintermS ) = Pi( the complement of each minterm ) = sum of the intersection of all minterms
			///	

			///for other unary call:
			/// if it's 1, 0, ret the op of nullary
			/// if it's noop. then return the operand's ret
			throw new NotImplementedException();

		}

		static public C Op(nilnul.bit.expr_.call_.unary_.NegI neg) {
			///for not(E)
			///	convert E to RetI R
			///	then !R = !(Sigma(minterms))  = Pi (!mintermS ) = Pi( the complement of each minterm ) = sum of the intersection of all minterms
			///	!E
			///	= ! Sop
			///	= ! Sigma(m0, m2,m3)
			///	=Sigma( m1 )

			
			throw new NotImplementedException();

		}


		static public C Op(nilnul.bit.expr_.call_.BinaryI binary) {

			//for all binary expr
			///  convert the binary expr into expr using only {not, and, or}
			///		this is possible for the conversion rule:
			///			A*B = the sum of minterms of A,B
			///	for and epxr


			throw new NotImplementedException();

		}


		static public C Op(nilnul.bit.expr_.call_.binary_.AndI and) {

			///A && B 
			///	convert A , B to Sop
			///	= Sop && Sop
			///	= the intersection of minterms


			throw new NotImplementedException();

		}


		static public C Op(nilnul.bit.expr_.call_.binary_.OrI and) {

			///A or B 
			///	= Sop or Sop
			///	= the union of minterms


			throw new NotImplementedException();

		}







	}
	/// <summary>
	/// given the vars of the expr to be converted.
	/// convert the expr into a sum of the set of minterms of those vars
	/// 
	/// 
	/// </summary>
	public class Sop
	{


	}
}
