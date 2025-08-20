using nilnul.bit0nul.bi.cumula.be_._unard.semi_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi.cumula.be_
{
	/// <summary>
	/// the unard candidate is applied right
	/// </summary>
	public class Unard
		:
		nilnul.obj.op_.binary.cumulator.be_.unard_.LeftUnardDefault<
			bool?
			,
			LeftUnard
		>,

		nilnul.obj.op_.binary.cumulator.be_.UnardableI<bool?>
		,
		nilnul.obj.BeI1<bit0nul.bi.Cumulator>
	{
		

		


		static public Unard Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unard>.Instance;
			}
		}

		public bool be(Cumulator obj)
		{
			return base.be(obj);
			//throw new NotImplementedException();
		}

		public bool be(bool? item11, obj.of_. BinaryI<bool?> item12)
		{
			return be(
				new Cumulator(item11,item12)
			);
			//throw new NotImplementedException();
		}
	}
}
