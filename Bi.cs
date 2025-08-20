using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.bit
{
	public interface BiI:nilnul.obj.of_.BinaryI<bool>
		,
		nilnul.obj.BiI<bool>
	{ }
	public class Bi
		:
		nilnul.obj.Box_ofIn<bool[]>
		,
		nilnul.bit.BiI
	{
		public const int ARITY = 2;

		public Bi(in bool[] val) : base(val)
		{
			int length = val.Length;

			nilnul.bit.vow_._TrueX1.Vow(
				length == co._SortieX.COUNT
				,
				$"the length of outcome, being {length}, must be {co._SortieX.COUNT};"
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Bi(bool[] x) : this(in x)
		{
		}


		public ref bool[] outcome {
			get {
				return ref boxed;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool op(in bool par, in bool par1)
		{
			return boxed[
				Array.IndexOf(
					bit.co._SortieX.Array, (par,par1)
				)
			];

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool op(bool par, bool par1)
		{
			return op(in par, in par1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  Bi Of(nilnul.bit.op_.BinaryI1 bi) {
			return new Bi(
				bit.co.Sortie.All.objs.ee.Select(x=> bi.op(x.Item1,x.Item2) ).ToArray()
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return bits.to_._BicimalX.Prefixed(boxed);
			return "0b"+ bit.str.to_._ToNumX.ToNum(boxed).ToString("b"); ///only since .net8;


			/// return bit0nul.bi.txten_._AsTernaryX.AsTernary(this);
			//return bit0nul.str.to_._ToNumX.ToNum(this.boxed).ToString();
		}


	}


}
