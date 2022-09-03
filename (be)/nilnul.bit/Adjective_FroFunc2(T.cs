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
	public partial class Adjective_FroFunc2<T>
		:AdjectiveI3<T>
	{
		private Func<T,bool> _func;

		public NotNull2<Func<T,bool>> notNullFunc
		{
			get { return _func; }
			set { _func = value; }
		}

		public Func<T, bool> func {
			get {
				return _func;
			}
			set {
				_func = value.EnsureNotNull();
			}
		}
		

		public Adjective_FroFunc2(NotNull2< Func<T,bool>> notNullFunc)
		{
			this.notNullFunc = notNullFunc;
		}

		public Adjective_FroFunc2(Func<T,bool> func)
			:this(func.ToNotNull())
		{
		}
					
					

		public bool be(T val)
		{
			return func(val);
		}

		public bool not(T val) {
			return !be(val);
		}
		public void assert(T val) {
			nilnul.bit.AssertionNullaryFunc.Assert(be(val));
		}
		public void disavow(T val) {
			nilnul.bit.AssertionNullaryFunc.Assert(not(val));
		}

		public bool be(NotNull2<T> val)
		{
			throw new NotImplementedException();
		}
	}
}
