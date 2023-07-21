using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.objs.be_.distinct.vow;
using nilnul.str_;

namespace nilnul.bit.var
{
	[Obsolete()]
	public interface SortieI1
		:nilnul.SortieI<nilnul.bit.VarI1,nilnul.bit.var.Eq>
	{
	}

	[Obsolete()]
	public class Sortie1 :
		nilnul.Sortie<nilnul.bit.VarI1, nilnul.bit.var.Eq>
		,
		SortieI1
	{
		public Sortie1(SeqI<VarI1> val) : base(val)
		{
		}
		public Sortie1():this( new nilnul.str_.Seq<VarI1>())
		{

		}

		public Sortie1(IEnumerable<VarI1> enumerable):this(new nilnul.str_.Seq<VarI1>(enumerable))
		{
		}

		public Sortie1 cloneAndAppend(nilnul.bit.VarI1 var)
		{
			nilnul.obj.vow_.False.Vow(this.contain(var));
			return new Sortie1(
				nilnul.str_.seq.convert_._AppendX.Str(
					this.en
					,var
				)
			);
		}

		public Sortie1 cloneAndPrepend(nilnul.bit.VarI1 var)
		{
			nilnul.obj.vow_.False.Vow(this.contain(var));
			return new Sortie1(
				nilnul.str_.seq.convert_._PrependX.Seq(
					this.en
					,var
				)
			);
		}


		public Sortie1 cloneAndDehead()
		{
			return new Sortie1(
				nilnul.str_.seq_.started.coerce_._DeheadX._Seq(this.en)
			);

			

		}


		public bool contain(nilnul.bit.VarI1 var) {
			return this.en.Contains(var, nilnul.bit.var.Eq.Singleton);
		}


	}
}
