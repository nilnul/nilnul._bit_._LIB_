using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str
{
	static public class FroX
	{
		static public IEnumerable<bool> ToBits(this int x) {

			foreach (var item in new BitArray(new int[] { x }))
			{
				yield return (bool)item;
			}


			//for (int i = 0,j=31; i < 32; i++,j--)
			//{
			//	yield return (x << j) ==1;
			//}
		}


		static public IEnumerable<bool> ToBits(this byte x) {
			//const int len = 8;
			//const int lenDecreaased = len - 1;

			BitArray bitArray = new BitArray(new byte[] { x });//The first byte in the array represents bits 0 through 7, the second byte represents bits 8 through 15, and so on. The Least Significant Bit of each byte represents the lowest index value: " bytes [0] & 1" represents bit 0, " bytes [0] & 2" represents bit 1, " bytes [0] & 4" represents bit 2, and so on. https://msdn.microsoft.com/en-us/library/x1xda43a(v=vs.110).aspx
			foreach (var item in bitArray)
			{
				yield return (bool)item;
			}
			
		}

		static public IEnumerable<bool> ToBits_indexBigFirst(this byte x) {

			return ToBits(x).Reverse();
			
		}




	}
}
