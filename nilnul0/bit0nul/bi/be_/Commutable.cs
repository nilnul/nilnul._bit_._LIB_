using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi.be_
{
	static public class _CommutableX
	{
		static public bool IsCommutable(this obj.of_.BinaryI<bool?> op)
		{
			for (int i = 0; i < bit0nul._SortieX.COUNT; i++)
			{
				for (int j = i; j < bit0nul._SortieX.COUNT; j++)
				{

					bool? par = bit0nul._SortieX.ARRAY[i];
					bool? par1 = bit0nul._SortieX.ARRAY[j];
					if (op.op(par, par1) == op.op(par1,par))
					{
						continue;

					}
					return false;
				}

			}
			return true;

		}
	}

}
