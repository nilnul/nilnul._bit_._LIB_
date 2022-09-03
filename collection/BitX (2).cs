using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.collection
{
   static public partial class BitX
    {
       

        public static bool GetBit(this byte b, int bitNumber)
        {
            //black magic goes here 
            return ( b & GetUnitByte(bitNumber) ) != 0;

        }

        public static byte GetUnitByte(int bitNumber) {
            if (bitNumber<0 || bitNumber>7)
            {
                throw new ArgumentOutOfRangeException("bit position can only be in [0,8)");
                
            }

            byte b = 1;

            return (byte)(b << bitNumber);
         //   return (b << bitNumber);
        
        }

	

		public static int MostSignificantBitPosition(byte b) {
			int r=-1;
			int b2 = b;
			while (b2!=0)
			{
				b2=b2 >> 1;
				r++;
				
			}

			return r;
		
			
		
		}



    }
}
