using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	[Obsolete("see Gt")]
	public partial class NotImply:BinaryI
	{

		static public bool Eval(bool x, bool y)
		{
			return !(ImplyX.Eval_byExpr(x, y));

		}




		//static private readonly NotImply _Instance = new NotImply();
		static private readonly NotImply _Instance = SingletonByDefaultNew<NotImply>.Instance;
		static public NotImply Instance
		{
			get
			{
				return _Instance;
			}
		}
		public NotImply()
		{
		}
				

		public bool exec(bool a, bool b)
		{
			return Eval(a, b);
		}

		public bool eval(bool x, bool y)
		{
			return Eval(x, y);
			throw new NotImplementedException();
		}
	}
}
