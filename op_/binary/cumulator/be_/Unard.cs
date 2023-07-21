using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.cumulator.be_
{
	/// <summary>
	/// the unard candidate is applie right
	/// </summary>
	public class Unard
		:
		nilnul.obj.op_.binary.cumulator.be_.unard_.LeftUnardDefault<
			bool
			,
			LeftUnard
		>,

		nilnul.obj.op_.binary.cumulator.be_.UnardableI<bool>
		,
		nilnul.obj.BeI1<bit.op_.binary.Cumulator>
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

		public bool be(bool item11, BinaryI1 item12)
		{
			return be(
				new Cumulator(item11,item12)
			);
			//throw new NotImplementedException();
		}
	}
}
