using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.nulable.op_.unary_
{
	public class Not : nulable.op_.UnaryI
	{
		public bool? op(bool? par)
		{
			return par ==null ? null: !(par.Value);
			//throw new NotImplementedException();
		}


		static public Not Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Not>.Instance;
			}
		}


	}
}
