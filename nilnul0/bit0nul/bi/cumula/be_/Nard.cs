using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi.cumula.be_
{
	/// <summary>
	/// the unard candidate is applied from left
	/// </summary>
	public class Nard
		:
		nilnul.obj.op_.binary.cumulator.be_.nilard_.LeftNilardDefault<
			bool?
			,
			_nard.semi_.LeftNard
		>,

		nilnul.obj.op_.binary.cumulator.be_.NilardableI<bool?>
		,
		nilnul.obj.BeI1<bit0nul.bi.Cumulator>
	{
		

		public bool be(Cumulator obj)
		{
			return base.be(obj);
			//throw new NotImplementedException();
		}

		public bool be(bool item1, BinaryI<bool?> item2)
		{
			return be(new Cumulator(item1,item2) );
			//throw new NotImplementedException();
		}
		


		static public Nard Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nard>.Instance;
			}
		}

	}
}
