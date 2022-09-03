using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.axiom
{
	/// <summary>
	/// 
	/// some theorems can be used in the proof of another theorem in the form of:
	/// (axiom A, theorem B)
	/// B therefore C   // c is temporary, not stored
	/// C therefore D   // d is stored as theorem
	/// 
	/// </summary>
	public interface TheoremsI
	{
	}
}
