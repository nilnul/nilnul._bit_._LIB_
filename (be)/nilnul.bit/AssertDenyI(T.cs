using System;
namespace nilnul.bit
{
	public interface AssertDenyI<T>
	:	AssertI<T>
			,
		DenyI<T>

	{
		
	}
}
