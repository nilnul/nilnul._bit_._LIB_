using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary
{
	public class Sortie
		: nilnul.obj.Sortie3<
			bit.op_.BinaryI1
		>
	{
		public Sortie(ObjsI3<BinaryI1> val) : base(val)
		{
		}

		public Sortie(IEnumerable<BinaryI1> val) : base(val)
		{
		}

		public Sortie(params BinaryI1[] elements) : base(elements)
		{
		}

		public Sortie(IEqualityComparer<BinaryI1> eq, ObjsI3<BinaryI1> val) : base(eq, val)
		{
		}

		public Sortie(IEqualityComparer<BinaryI1> eq, IEnumerable<BinaryI1> val) : base(eq, val)
		{
		}

		public Sortie(IEqualityComparer<BinaryI1> eq, params BinaryI1[] elements) : base(eq, elements)
		{
		}

		static public op_.BinaryI1[] _Arr = new BinaryI1[] {
				// 0b 0000
				op_.binary_.Nil.Singleton
				,	///we need the minimal change, so: 

				//0b0001
				op_.binary_.Nor.Singleton	
				,
				// 0b0010
				op_.binary_.Lt.Singleton
				,
				//0b0011
				op_.binary_.Neghead.Singleton
				,
				//0b0100
				op_.binary_.Gt.Singleton
				,
				// 0b0101
				op_.binary_.NegTip.Singleton
				,
				//0b0110
				op_.binary_.Ne.Singleton	
				,
				//0b0111
				op_.binary_.Nand.Singleton
			,
				//0b1000
				op_.binary_.Min.Singleton
				,
				//0b1001
				op_.binary_.Eq.Singleton	
				,
				// 0b1010
				op_.binary_.Tip.Singleton  
				,
				// 0b1011
				op_.binary_.Le.Singleton
				,
				// 0b1100
				op_.binary_.Head.Singleton
				,
				//0b1101
				op_.binary_.Ge.Singleton
				,
				//0b1110
				op_.binary_.Max.Singleton   
				,
				//0b1111
				op_.binary_.One.Singleton
		};

		static public Sortie OfAll() {
			return new Sortie(
				binary.Eq.Singleton
				,
				_Arr

			);
		}
		static public Sortie All = OfAll();
	}
}
