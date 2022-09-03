using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	public interface ConstantI
		:nilnul.obj.ConstantI<bool>
	{
	}

	public class Constant:nilnul.obj.Constant<bool>,  ConstantI
	{
		public Constant(bool result):base(result)
		{

		}

		static public Constant CreateTrue() { return new Constant(true); }
		static public Constant CreateFalse() { return new Constant(false); }

		public class Eq : IEqualityComparer<Constant>
		{
			public bool Equals(Constant x, Constant y)
			{
				return x.result == y.result;
				throw new NotImplementedException();
			}

			public int GetHashCode(Constant obj)
			{
				return obj.result.GetHashCode();
				throw new NotImplementedException();
			}


			static public readonly Eq Singleton = nilnul.obj.SingletonByDefault<Eq>.Instance;

		}
	}
}
