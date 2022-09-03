using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.objs.be_.distinct.vow;
using nilnul.str_;

namespace nilnul.bit.expr_.var
{
	

	public class Sortie1 :
		nilnul.obj.sortie_.EqDefault1<nilnul.bit.expr_.Var_sys, nilnul.bit.expr_.var.Eq>
		
	{

		public Sortie1(ObjsI3<Var_sys> val) : base(val)
		{
		}

		public Sortie1(IEnumerable<Var_sys> val) : base(val)
		{
		}

		public Sortie1(params Var_sys[] elements) : base(elements)
		{
		}

		public Sortie1 cloneAndAppend(nilnul.bit.expr_.Var_sys var)
		{
			nilnul.obj.vow_.False.Vow(this.contain(var));

			return new Sortie1(
				nilnul.str_.seq.convert_._AppendX.Str(
					this.ee
					,var
				)
			);
		}

		public Sortie1 cloneAndPrepend(nilnul.bit.expr_.Var_sys var)
		{
			nilnul.obj.vow_.False.Vow(this.contain(var));
			return new Sortie1(
				nilnul.str_.seq.convert_._PrependX.Seq(
					this.ee
					,var
				)
			);
		}


		public Sortie1 cloneAndDehead()
		{
			return new Sortie1(
				nilnul.str_.seq_.started.coerce_._DeheadX._Seq(this.ee)
			);

			

		}


		public bool contain(nilnul.bit.expr_.Var_sys var) {
			return this.ee.Contains(var, nilnul.bit.expr_.var.Eq.Singleton);
		}

		public override string ToString()
		{
			return string.Join(",",this.boxed);
		}


	}
}
