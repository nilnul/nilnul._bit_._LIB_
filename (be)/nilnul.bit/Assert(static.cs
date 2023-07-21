using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	[Obsolete()]
	public  class Assert
	{


        static public void AssertFuncTrue<P>(Func<P,bool> func,P arg) {
            if (!func(arg) ) {
                throw new Exception(string.Format("{1} doesn't pass {0}.",func,arg));
           
            }

        
        }

		static public T Ensure<T>(T val,bool x) {

			nilnul.bit.Assert.True(x);

			return val;

		
		}
		static public void Eval(bool x) {
			if (!x)
			{
				throw new Exception("Assert true fails.");
				
				
			}
		}

		static public void True(bool x)
		{
			if (!x)
			{
				throw new Exception("Assert true fails.");


			}
		}

	
		static public void Eq<T>(T x,T y)
			where T:struct,IEquatable<T>
		{
			AssertX.True(x.Equals( y));
		
		}


		static public void Eq2<T>(T x, T y)
			where T: IEquatable<T>
		{
			AssertX.True(x.Equals(y));

		}


	


	

		static public void False(bool x)
		{
			if (x)
			{
				throw new Exception("Assert false fails.");


			}
		}

		
	}
}
