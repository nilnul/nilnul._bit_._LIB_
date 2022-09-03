using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_
{
	public interface NaryI
		:OpI2, 
		nilnul.obj.op_._nulary_.RetI<bool>
		,
		nilnul.obj.op_.NaryI<bool>//added 210725
	{
	}
	public abstract class NaryA
	{
		static public NaryI Create(bool ret) {
			return ret ? nary_.One.Singleton as NaryI : nary_.Nil.Singleton;
		}
	}

	public class Nary :
		nilnul.obj.op_.Nary<bool>
		,NaryI
		,
		bit.op_.of_.VecI
	{
		public Nary(bool ret) : base(ret)
		{
		}

		public Nary(Func<bool> op1):base(op1())
		{
		}

		static public implicit operator Nary(Func<bool> x)
		{
			return new Nary(x());
		}
		static public Nary Of(NaryI x)
		{
			return x is Nary y ? y : new Nary(x.op);
		}


	}

}
