using nilnul.bit.str_.seq_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str.where_.one
{
	/// <summary>
	/// populated bits count;
	/// </summary>
	/// alias:
	///		popcount
	///		sideways addition
	///		HammingWeight
	static public class _CountX
	{
		static public int CountOfOnes(byte x) {
			return new BitArray(x).AsSeq().Where(x=>x).Count();
		}
		static public int CountOfOnes(sbyte x) {
			return new BitArray(x).AsSeq().Where(x=>x).Count();
		}
		static public int CountOfOnes(short x) {
			return new BitArray(x).AsSeq().Where(x=>x).Count();
		}
		static public int CountOfOnes(ushort x) {
			return new BitArray(x).AsSeq().Where(x=>x).Count();
		}
		static public int CountOfOnes(int x) {
			return new BitArray(x).AsSeq().Where(x=>x).Count();
		}

		static public int CountOfOnes(uint x) {
			return  new BitArray(
				BitConverter.GetBytes(x)
			)
			.AsSeq().Where(x=>x).Count();
		}

	



	}
}
