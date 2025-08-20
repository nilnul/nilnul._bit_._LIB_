using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str_.enumable.be_
{
	/// <summary>
	/// an consecutive ones;
	/// </summary>
	public class Adjacent : BeI
	{
		public bool be(Enumable obj)
		{
			return  enumable.op_.pair_.And.Singleton.op(obj).Any(x=> x==true);
			//throw new NotImplementedException();
		}

		public bool be(IEnumerable<bool> obj)
		{
			return  enumable.op_.pair_.And.Singleton.op(obj).Any(x=> x==true);
			//throw new NotImplementedException();
		}


		static public Adjacent Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Adjacent>.Instance;
			}
		}

	}
}
