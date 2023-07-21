using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.unary_.not
{
	public class Recur :
		nilnul.obj.op_.unary.recur_.OpDefault<bool, op_.unary_.Not1>
		//,
		//nilnul.obj.op_.unary.RecurI<bool>
	{
		public Recur(bool initial0) : base(initial0)
		{
		}

		public Recur():this(false)
		{
		}

		static public Recur IniOfTrue() {
			return new Recur(true);
		}


		static public Recur Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Recur>.Instance;
			}
		}

		//UnaryI<bool> obj.op_.unary._recur_.OpI<UnaryI<bool>>.op => this.op;
	}
}
