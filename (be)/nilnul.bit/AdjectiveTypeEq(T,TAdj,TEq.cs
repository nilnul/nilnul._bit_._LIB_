using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public abstract partial class AdjectiveTypeEq2<T, TAdj, TNoun, TEq>

		: AdjectiveType2<T, TAdj>


		where TAdj : AdjectiveI3<T>, new()
		where TNoun:AdjectiveType2<T,TAdj>

		where TEq : IEqualityComparer<T>, new()
	{

		public AdjectiveTypeEq2(T val)
			: base(val)
		{
		}


		public partial class Eq
			: IEqualityComparer<TNoun>
		{
			public bool Equals(TNoun x, TNoun y)
			{
				return SingletonByDefaultNew<TEq>.Instance.Equals(x.val, y.val);
				throw new NotImplementedException();
			}

			public int GetHashCode(TNoun obj)
			{
				return Instance.GetHashCode(obj.val);
				throw new NotImplementedException();
			}
			
			static public TEq Instance = SingletonByDefaultNew<TEq>.Instance;
		}


	}

}
