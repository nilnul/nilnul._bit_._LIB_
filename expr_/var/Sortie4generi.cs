using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.objs.be_.distinct.vow;
using nilnul.str_;
using V = nilnul.bit.expr_.Var2;

namespace nilnul.bit.expr_.var
{


	public class Sortie4generi :
		nilnul.obj.sortie_.EqDefault1<nilnul.bit.expr_.Var2, nilnul.bit.expr_.var.Eq>
		
	{

		public Sortie4generi(ObjsI3<V> val) : base(val)
		{
		}

		public Sortie4generi(IEnumerable<Var2> val) : base(val)
		{
		}

		public Sortie4generi(params V[] elements) : base(elements)
		{
		}

		public Sortie4generi cloneAndAppend(V var)
		{
			nilnul.obj.vow_.False.Vow(this.contain(var));

			return new Sortie4generi(
				nilnul.str_.seq.convert_._AppendX.Str(
					this.ee
					,var
				)
			);
		}

		public Sortie4generi cloneAndPrepend(V var)
		{
			nilnul.obj.vow_.False.Vow(this.contain(var));
			return new Sortie4generi(
				nilnul.str_.seq.convert_._PrependX.Seq(
					this.ee
					,var
				)
			);
		}


		public Sortie4generi cloneAndDehead()
		{
			return new Sortie4generi(
				nilnul.str_.seq_.started.coerce_._DeheadX._Seq(this.ee)
			);

			

		}


		public bool contain(V var) {
			return this.ee.Contains(var, nilnul.bit.expr_.var.Eq.Singleton);
		}

		public override string ToString()
		{
			return string.Join(",",this.boxed);
		}


	}
}
