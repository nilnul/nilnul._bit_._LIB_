using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.re_
{
	/// <summary>
	/// 
	/// </summary>
	public class Priority1 : ReI1
	{
		


		static public readonly Priority1 Instance = new Priority1();

		public  bool re(op_.BinaryI1 x, op_.BinaryI1 y)
		{
			if (x is op_.binary_.And)
			{
				return re(x as op_.binary_.And, y);
			}
			else if (x is op_.binary_.Or)
			{
				return re(x as op_.binary_.Or, y);
			}
			else if (x is op_.binary_.Imply)
			{
				return re(x as op_.binary_.Imply, y);
			}

			else if (x is op_.binary_.Iff)
			{
				return re(x as op_.binary_.Iff, y);
			}
			else
			{
				throw new UnexpectedTypeException();
			}


		}

		public bool re(op_.binary_.And left, op_.binary_.And right)
		{
			return true;
		}

		public bool re(op_.binary_.And left, op_.BinaryI1 right)
		{
			return true;
		}
		public bool re(op_.binary_.Or left, op_.binary_.And right)
		{
			return false;
		}

		public bool re(op_.binary_.Or left, op_.BinaryI1 right)
		{
			if (right is op_.binary_.And)
			{
				return re(left, right as op_.binary_.And);
			}
			else
			{
				return true;
			}
		}

		public bool re(op_.binary_.Imply left, op_.BinaryI1 right)
		{
			if (right is op_.binary_.And || right is op_.binary_.Or
				|| right is op_.binary_.Imply//right associative
				)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool re(op_.binary_.Iff left, op_.BinaryI1 right)
		{
			if (right is op_.binary_.And || right is op_.binary_.Or
				|| right is op_.binary_.Imply

				|| right is op_.binary_.Iff//right associative
				)
			{
				return false;
			}
			else
			{
				return true;
			}
		}



	}
}
