using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.adj
{
	/// <summary>
	/// an adjective applicable to T. subtyping Func(T,bool) till singleton.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>Adjective is a bool function which partitions the objects in the domain in two.
	/// 
	/// </remarks>
	public partial class FroAntonym<T,TAdj>
		:FroAntonym<T>,
		
		AdjI<T>
		where TAdj:AdjI<T>,new()
	{
		static public AdjI<T> Antonym = SingletonByDefaultNew<TAdj>.Instance;
		public FroAntonym()
			:base(Antonym)
		{

		}

		
	}
}
