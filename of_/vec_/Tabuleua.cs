using nilnul.bit.tup.sortie_.omni;
using nilnul.obj.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.of_.vec_
{


	public class Tabuleau :
		nilnul.obj.Box1<bit.tup.sortie_.omni.Poll>,

		VecI
	{
		public Tabuleau(Poll val) : base(val)
		{
		}

		public int arity => boxed.varsCount;

		public bool op(IEnumerable<bool> vec)
		{
			if (vec.Count()!=this.arity)
			{
				throw new ArgumentException($"{nameof(vec)}:{vec}'arity is not {this.arity}.");

			}


			return boxed.votes.Rows().First(
				v =>
				nilnul.objs.re_.InitialSegment<bool>.Singleton.re( vec,v)
			).Last();


		}
	}

}
