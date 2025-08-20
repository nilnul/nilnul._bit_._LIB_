using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._deduction.inference_
{
	/*
one common rule of inference is the rule of substitution. If t is a term and φ is a formula possibly containing the variable x, then φ[t/x] is the result of replacing all free instances of x by t in φ. 

		 The substitution rule states that for any φ and any term t, one can conclude φ[t/x] from φ provided that no free variable of t becomes bound during the substitution process. (If some free variable of t becomes bound, then to substitute t for x it is first necessary to change the bound variables of φ to differ from the free variables of t.)
		 */
	class Substitution
	{
	}
}
