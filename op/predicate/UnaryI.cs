using System;
namespace nilnul.bit.op.predicate
{
	public interface UnaryI<in TArg>
	{
		bool eval(TArg x);
	}
}
