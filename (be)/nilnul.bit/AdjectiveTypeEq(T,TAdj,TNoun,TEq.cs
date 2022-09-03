using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	 public abstract partial class AdjectiveTypeEq<T,TAdj,TAdjNoun,TEq>
		 :IEqualityComparer<TAdjNoun>
		
		 where TAdj:AdjectiveI3<T>,new()
		where TAdjNoun:AdjectiveType2<T,TAdj>,new()
		 where TEq:IEqualityComparer<T>,new()
	{


		 static public TEq Eq = SingletonByDefaultNew<TEq>.Instance;

		public bool Equals(TAdjNoun x, TAdjNoun y)
		{
			return SingletonByDefaultNew<TEq>.Instance.Equals(x.val, y.val);
			throw new NotImplementedException();
		}

		public int GetHashCode(TAdjNoun obj)
		{
			return Eq.GetHashCode(obj.val);
			throw new NotImplementedException();
		}
	}

}
