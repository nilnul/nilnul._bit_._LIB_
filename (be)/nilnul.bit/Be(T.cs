using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Be<T>
		:
		BeI<T>
	{
		private Func<T,bool> _func;

		public Func<T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public Be(Func<T,bool> func)
		{
			this._func = func;
		}


		#region static

		static public Be<T> Create(Func<T,bool> func) {
			return new Be<T>(func);
		
		}

		static public Be<T> CreateInverse(Func<T, bool> func)
		{
			return new Be<T>(c => !func(c));

		}
		static public Be<T> CreateDual(Func<T, bool> func)
		{
			return new Be<T>(c => !func(c));

		}
					


		#endregion




		public bool be(T obj)
		{
				return func(obj);
		}
	}
}
