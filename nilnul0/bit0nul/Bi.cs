using System;

namespace nilnul.bit0nul
{
	public class Bi
		:
		nilnul.obj.Box_ofIn<bool?[]>
		,
		BiI
	{
		public const int ARITY = 2;
		public Bi(in bool?[] val) : base(val)
		{
			int length = val.Length;

			nilnul.bit.vow_._TrueX1.Vow(
				length == co._SortieX.COUNT
				,
				$"the length of outcome, being {length}, must be {co._SortieX.COUNT};"
			);
		}

		public Bi(bool?[] x) : this(in x)
		{
		}
		public ref bool?[] outcome {
			get {
				return ref boxed;
			}
		}

		public bool? op(bool? par, bool? par1)
		{
			return boxed[
				Array.IndexOf(
					bit0nul.co._SortieX.Array, (par,par1)
				)
			];
		}

		public override string ToString()
		{
			return bit0nul.str.txten_._AsNumsX.AsTernary(boxed);

			return bit0nul.bi.txten_._AsTernaryX.AsTernary(this);
			//return bit0nul.str.to_._ToNumX.ToNum(this.boxed).ToString();
		}
	}


}
