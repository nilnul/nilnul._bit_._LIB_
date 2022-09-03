using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	/// <summary>
	/// based on a nullary func()==>bool, and returns void or exception.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Assertion
	{






		/// <summary>
		/// (()=>bool)=>{void if true,exception if false}
		/// </summary>
		/// <param name="x"></param>
		static public void True(bool x)
		{
			if (!x)
			{
				throw new Exception("Assert true fails.");


			}
		}

	

		/// <summary>
		/// (()=>bool)=>{void if false,exception if true}
		/// </summary>
		/// <param name="x"></param>

		static public void False(bool x)
		{
			if (x)
			{
				throw new Exception("Assert true fails.");


			}
		}


		public class Expr
		{

			
		}
		







	}



}

