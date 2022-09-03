using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj_.xpn_;

namespace nilnul.bit.vow_.true_
{

	public class Unacceptable
		:True<nilnul.obj_.xpn_.UnacceptableException<Unacceptable>>
	{ 
		
		public Unacceptable(UnacceptableException<Unacceptable> xpn) : base(xpn)
		{
		}

		public Unacceptable(string exceptionMsg) :this (new UnacceptableException<Unacceptable>(exceptionMsg))
		{
		}

		public Unacceptable():this("")
		{
		}

		static public Unacceptable Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Unacceptable>.Instance;
			}
		}
	}
}
