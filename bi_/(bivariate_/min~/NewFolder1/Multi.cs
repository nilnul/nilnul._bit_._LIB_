using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	[Obsolete()]
	public partial class Multi
		: BinaryI
	{

		static private readonly Multi _Instance = new Multi();
		static public Multi Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Multi()
		{
		}


		static public bool Eval(bool a, bool b)
		{
			return a && b;

		}
		public bool exec(bool operand1, bool operand2)
		{
			return operand1 && operand2;
		}

		public bool eval(bool x, bool y)
		{
			return x && y;
			throw new NotImplementedException();
		}
	}

}
