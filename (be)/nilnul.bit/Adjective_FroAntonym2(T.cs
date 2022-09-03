using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	/// <summary>
	/// an adjective applicable to T. subtyping Func(T,bool) till singleton.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>Adjective is a bool function which partitions the objects in the domain in two.
	/// 
	/// </remarks>
	public partial class Adjective_FroAntonym2<T,TAntonym>
		:AdjectiveI3<T>
		where TAntonym:AdjectiveI3<T>,new()
	{
		public bool be(NotNull2<T> val)
		{
			return  !Antonym.be(val);
		}
		static public AdjectiveI3<T> Antonym = SingletonByDefaultNew<TAntonym>.Instance;
	}
}
