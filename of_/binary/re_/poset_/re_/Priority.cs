using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.combine.re_
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	[Obsolete(nameof(op_.binary.re_.Priority))]
	public class Priority : ReI
	{
		//public bool re(CombineI a, CombineI b)
		//{
		//	if (a is combine_.And)
		//	{
		//		return true;
		//	}
		//	if (a is combine_.Or)
		//	{
		//		if (b is combine_.And)
		//		{
		//			return false;
		//		}
		//		return true;
		//	}

		//	if (a is combine_.)
		//	{

		//	}
		//	throw new NotImplementedException();
		//}


		static public readonly Priority Instance = new Priority();

		public  bool re(CombineI x, CombineI y)
		{
			if (x is combine_.And)
			{
				return re(x as combine_.And, y);
			}
			else if (x is combine_.Or)
			{
				return re(x as combine_.Or, y);
			}
			else if (x is combine_.Le)
			{
				return re(x as combine_.Le , y);
			}

			else if (x is combine_.Le)
			{
				return re(x as combine_.Le, y);
			}
			else
			{
				throw new UnexpectedTypeException();
			}


		}

		public bool re(combine_.And left, combine_.And right)
		{
			return true;
		}

		public bool re(combine_.And left, CombineI right)
		{
			return true;
		}
		public bool re(combine_.Or left, combine_.And right)
		{
			return false;
		}

		public bool re(combine_.Or left, CombineI right)
		{
			if (right is combine_.And)
			{
				return re(left, right as combine_.And);
			}
			else
			{
				return true;
			}
		}

		public bool re(combine_.Le left, CombineI right)
		{
			if (right is combine_.And || right is combine_.Or
				|| right is combine_.Le//right associative
				)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool re(combine_.Eq left, CombineI right)
		{
			if (right is combine_.And || right is combine_.Or
				|| right is combine_.Le

				|| right is combine_.Eq//right associative
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
