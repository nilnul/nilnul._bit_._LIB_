using nilnul.bit.str.to_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi._txten_.by_
{
	static public class _CharsX
	{
		static public string ToName(this bit.Bi x) {

			var n = nilnul.bit.str.txten_._AsNumsX.AsBinary(x.outcome);//.ToNum();

			switch (n)
			{
				case "0000":
					return "0";
					break;
				case "1000":
					return bit.bi_._NorX.SYMBOL;
				case "0100":
					return bit.bi_._LtX.SYMBOL;
				case "1100":
					return bit.bi_._TopX.SYMBOL;
				case "0010":	//
					return bit.bi_._GtX.SYMBOL;
				case "1010":
					return bit.bi_._NegTipX.SYMBOL;
				case "1010":
					return bit.bi_._NegTipX.SYMBOL;

				case 3:
					return bit.bi_._TopX.SYMBOL;



				default:
					break;
			}

			return x.ToString();

		}
	}
}
