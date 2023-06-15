using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary.rel
{
	public  class Dual
	{

		/// <summary>
		/// or by typeof to get types, which would be better since no instancs are needed to be created.
		/// </summary>
		public static readonly op.BinaryI[,] IN_ROWS = { 
				{SingletonByDefault<Xor_pubCtor>.Instance, SingletonByDefault<Eq>.Instance}
				,
				{SingletonByDefault<Nil>.Instance,SingletonByDefault<One>.Instance				}
				,
				{SingletonByDefault<Gt>.Instance,SingletonByDefault<Le>.Instance  }
				,
				{SingletonByDefault<Ge>.Instance,SingletonByDefault<Lt>.Instance},
				{SingletonByDefault<And_defaultCtor>.Instance,SingletonByDefault<Nand>.Instance}
				,
				{SingletonByDefault<Or_defaultCtor>.Instance, SingletonByDefault<Nor>.Instance}
				,
				{SingletonByDefault<C0>.Instance, SingletonByDefault<NegC0>.Instance}
				,
				{SingletonByDefault<C1>.Instance, SingletonByDefault<NegC1>.Instance}

		};
	}
}
