using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Asserted<T>
	{
		public Asserted(T val, Func<T, bool> be)
		{
			set(val, be);


		}

		protected Asserted(Func<T,bool> be) {

			this._be = be;
		
		}

		protected static Asserted<T> Create(T val,Func<T,bool> be){
			var r=new Asserted<T>(be);
			r.valSetter=val;
			return r;


		}


		private T _val;
		public T val
		{
			get { return _val; }
			set
			{
				nilnul.bit.be.Assert.Eval(value, be);

				_val = value;
			}
		}

		public T valSetter{

			 get {
				return _val;
			}

			protected set {
				this._val = value;
			}
		
		}
		public T valProtected{

			 get {
				return _val;
			}

			protected set {
				this._val = value;
			}
		
		}

		private Func<T, bool> _be;

		public Func<T, bool> be
		{
			get { return _be; }
			set
			{
				_be = value;
				validate();
			}
		}

		public void validate() { 
				nilnul.bit.be.Assert.Eval(val, be);

		}

		public void set(T val, Func<T, bool> be)
		{
			this._be = be;

			this._val = val;
			validate();


		}

		public override string ToString()
		{
			return val.ToString();
		}



		public override int GetHashCode()
		{
			return _val.GetHashCode();
		}

	}
}
