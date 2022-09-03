using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.minterm
{
	/// <summary>
	/// given a set of vars:
	///		for each var, the multiplied are both var, or are both negation of var
	/// </summary>
	public class Eq : IEqualityComparer<MintermI>
	{

		public bool Equals(MintermI x, MintermI y)
		{
			return nilnul.obj.dict_.poll.Eq<
				nilnul.bit.VarI1,
			
				nilnul.bit.var.Eq
				>.Singleton.Equals( x.poll,y.poll);


			//throw new NotImplementedException();
		}

		public int GetHashCode(MintermI obj)
		{
			return 0;
			throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq>.Instance;
			}
		}

	}

	
}
