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
	public partial class Adjective_FroAntonym<T,TAntonym>
		:AdjectiveI2<T>
		where TAntonym:AdjectiveI2<T>,new()
	{


					

		public bool be(T val)
		{
			return  !Antonym.be(val);
		}
		static public AdjectiveI2<T> Antonym = SingletonByDefaultNew<TAntonym>.Instance;
	}
}
