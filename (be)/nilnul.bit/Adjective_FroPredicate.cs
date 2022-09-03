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
	public partial class Adjective_FroPredicate<T>
		:AdjectiveI2<T>
	{
		private System.Predicate<T> _func;

		public NotNull2<System.Predicate<T>> notNullFunc
		{
			get { return _func; }
			set { _func = value; }
		}

		public System.Predicate<T> func {
			get {
				return _func;
			}
			set {
				_func = value.EnsureNotNull();
			}
		}
		

		public Adjective_FroPredicate(NotNull2< System.Predicate<T>> notNullFunc)
		{
			this.notNullFunc = notNullFunc;
		}

		public Adjective_FroPredicate(System.Predicate<T> func)
			:this(func.ToNotNull())
		{
		}
					
					

		public bool be(T val)
		{
			return func(val);
		}
	}
}
