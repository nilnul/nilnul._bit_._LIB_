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
	public class RightUnard
		:
		nilnul.obj.op_.binary.cumulator.be_._unard.semi_.right_.byConversing_.LeftUnardDefault<
			bool
			,
			LeftUnard
		>,

		nilnul.obj.op_.binary.cumulator.be_._unard.semi_.IRightUnard
		,
		nilnul.obj.BeI1<bit.op_.binary.Cumulator>
	{
		

	


		static public RightUnard Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<RightUnard>.Instance;
			}
		}

		public bool be(Cumulator obj)
		{
			return base.be(obj);
			//throw new NotImplementedException();
		}
	}
}
