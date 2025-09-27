using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.mono.op
{
	public sealed class Zero:Op
	{
		public Zero()
			:base(x=>false)
		{

		}
	}

	public sealed class On:Op
	{
		public On():base(x=> true)
		{

		}
	}

	public sealed class Not:Op
	{

		static public Not Singleton = SingletonByDefault<Not>.Instance;


		public Not():base(x=>!x)
		{

		}

		public override string ToString()
		{
			return "!";
		}
	}

	public sealed class Nop:Op
	{
		public Nop():base(x=>x)
		{

		}
	}
}
