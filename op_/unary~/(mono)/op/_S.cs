using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op
{
	public sealed class Zero : Op
	{
		static public Zero Singleton = SingletonByDefault<Zero>.Instance;


		[Obsolete()]

		public Zero()
			: base(x => false)
		{

		}
	}

	public sealed class On : Op
	{
		static public On Singleton = SingletonByDefault<On>.Instance;


		[Obsolete()]
		public On() : base(x => true)
		{

		}
	}

	public sealed class Not : Op
	{

		static public Not Singleton = SingletonByDefault<Not>.Instance;

		[Obsolete()]
		public Not() : base(x => !x)
		{

		}

		public override string ToString()
		{
			return "!";
		}
	}


	public sealed class Nop : Op
	{
		static public Nop Singleton = SingletonByDefault<Nop>.Instance;

		[Obsolete()]

		public Nop() : base(x => x)
		{

		}
	}
}
