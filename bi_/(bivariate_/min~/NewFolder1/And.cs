using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	[Obsolete()]
	public partial class And
		:BinaryI
	{

		static private readonly And _Instance = new And();
		static public And Instance
		{
			get
			{
				return _Instance;
			}
		}
		private And()
		{
		}
				
		public bool exec(bool operand1, bool operand2)
		{
			return operand1 && operand2;
		}

		static public bool Eval() {
			return true;
		}

		static public bool Eval(bool arg) {
			return arg;
			
		}

		static public bool Eval(IEnumerable<bool> operands_notNull) {

			var result = Eval();

			foreach (var item in operands_notNull)
			{
				result &= item;
				
			}

			return result;

			///a group of {0,1} with and.   0&0=0, 0&1=0, so 0 is the Zero element.


			
		
		}

		public bool eval(bool a, bool b)
		{

			return a && b;

			throw new NotImplementedException();
		}
	}
}
