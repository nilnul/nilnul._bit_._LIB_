using System;
using System.Collections.Generic;

namespace nilnul.bit.of_
{
	public class Scala :
		nilnul.obj.of_.vec_.Scala<bool>
		,

		ScalaI
	{
		public Scala(int arity, Func<IEnumerable<bool>, bool> func) : base(arity, func)
		{
		}
	}

}
