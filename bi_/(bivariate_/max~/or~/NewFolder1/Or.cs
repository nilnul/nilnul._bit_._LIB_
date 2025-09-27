using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.binary
{
	/// <summary>
	/// Alias Max
	/// </summary>
	/// 

	[Obsolete("see Max")]
	public partial class Or:BinaryI
	{

		static public bool Eval() {

			return false;	/// 0 || 1= 1, 0||0=0. so 0 is identity
		
		}
		static public bool Eval(bool arg) {
			return arg;	//same as Eval() || arg
		}

		static public bool Eval(params bool[] args) {
			var r = Eval();

			foreach (var item in args)
			{
				r |= item;
				
			}

			return r;
		}


		static public bool Eval(IEnumerable< bool> args) {
			var r = Eval();

			foreach (var item in args)
			{
				r |= item;
				
			}

			return r;
		}




		static private readonly Or _Instance = new Or();
		static public Or Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Or()
		{
		}



				
		public bool exec(bool operand1, bool operand2)
		{
			return operand1 || operand2;
		}



		public bool eval(bool x, bool y)
		{

			return x || y;

			throw new NotImplementedException();
		}
	}
}
