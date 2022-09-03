using nilnul.obj._vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	public interface VowI:nilnul.obj.VowI<bool>
	{
	}

	public class Vow<TXpn> :
		nilnul.bit.Boxed,

		VowI, nilnul.obj.VowI2<bool>
		where TXpn: Exception,new()
	{
		private TXpn _xpn;

		public TXpn xpn
		{
			get { return _xpn; }
			set { _xpn = value; }
		}

		public Vow(bool val, TXpn xpn) : base(val)
		{
			_xpn = xpn;
		}

		public Vow(bool val, string msg):this(val, new TXpn() { Source=msg })
		{

		}

		public Vow(bool val):this(val, null as string)
		{

		}

		public void vow(bool obj)
		{
			if (obj != this.boxed)
			{
				throw this._xpn;
			}
		}
	}

	public class Vow : Vow<nilnul.obj._vow.FailException<Vow>>
	{
		public Vow(bool val) : base(val)
		{
		}

		public Vow(bool val, FailException<Vow> xpn) : base(val, xpn)
		{
		}

		public Vow(bool val, string msg) : this(val,new FailException<Vow>(msg))
		{
		}
	}
}
