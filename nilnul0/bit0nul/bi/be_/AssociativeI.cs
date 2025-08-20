using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi.be_
{
	static public class _AssociativeX
	{
		static public bool IsAssociative(this obj.of_.BinaryI<bool?> op) {
			for (int i = 0; i < bit0nul._SortieX.COUNT; i++)
			{
				for (int j = 0; j < bit0nul._SortieX.COUNT; j++)
				{

					for (int k = 0; k < bit0nul._SortieX.COUNT; k++)
					{
					bool? par = bit0nul._SortieX.ARRAY[i];
					bool? par1 = bit0nul._SortieX.ARRAY[j];
					bool? par2 = bit0nul._SortieX.ARRAY[k];

					if (
							op.op( op.op(par, par1)		,par2)
							==
							op.op(par					,op.op( par1,par2) ))
					{
						continue;

					}
					return false;




					}

				}

			}
			return true;


		}


	}

}
