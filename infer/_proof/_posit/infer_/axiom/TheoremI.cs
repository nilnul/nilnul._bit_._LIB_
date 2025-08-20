using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.axiom
{
	/// <summary>
	/// note according to inference rule, A therefore A is a valid proof. so every principal in the set Axiom is also theroem.
	/// Thus we have an intial theorem set, which is growing large with new theorems added in.
	/// Because theorems are infered from axiom. so they are consistent as long as the axiom is consistent. (Note inconsistent axiom will not throw exception, but prove all expr including 0 as theorems). The inclusiong of theorem, will add redundancy, keeping consistency. 
	/// </summary>
	public interface TheoremI
	{
	}
}
