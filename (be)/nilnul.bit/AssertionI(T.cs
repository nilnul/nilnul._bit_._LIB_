using System;
namespace nilnul.bit
{
	public interface AssertionI<T>
	{
		void assert(T obj);
		void deny(T obj);
		T ensure(ref T obj);
		T ensureNot(ref T obj);
	}
}
