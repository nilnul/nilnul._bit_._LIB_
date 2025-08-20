using nilnul.bit.str.to_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi
{
	static public class _TxtenX
	{
		static public string ToName(this bit.Bi x) {

			var n = nilnul.bit.str.to_._ToNumX.ToNum(x.outcome);//.ToNum();

			switch (n)
			{
				case 0b0000:
					return  bit.bi_._NilX.SYMBOL;
				case 0b0001:
					return bit.bi_._NorX.SYMBOL;
				case 0b0010:
					return bit.bi_._LtX.SYMBOL;
				case 0b0011:
					return bit.bi_._NegTopX.SYMBOL;
				case 0b0100:	//
					return bit.bi_._GtX.SYMBOL;
				case 0b0101:
					return bit.bi_._NegTipX.SYMBOL;
				case 0b0110:
					return bit.bi_._NeX.SYMBOL;
				case 0b0111:
					return bit.bi_._NandX.SYMBOL;
				case 0b1000:
					return bit.bi_._AndX.SYMBOL;
				case 0b1001:
					return bit.bi_._EqX.SYMBOL;
				case 0b1010:
					return bit.bi_._TipX.SYMBOL;
				case 0b1011:
					return bit.bi_._LeX.SYMBOL;
				case 0b1100:
					return bit.bi_._TopX.SYMBOL;
				case 0b1101:
					return bit.bi_._GeX.SYMBOL;
				case 0b1110:
					return bit.bi_._OrX.SYMBOL;
				case 0b1111:
					return bit.bi_._OneX.SYMBOL;




					//default:
					//	break;
			}
			throw new UnexpectedReachException($"the #({n}) shall be lt 16");

			//return x.ToString();

		}
	}
}
