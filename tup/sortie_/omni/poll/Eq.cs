using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.tup.sortie_.omni.poll
{
	public class Eq
		:
		nilnul.obj.eq_.homo_.EqDefault<Poll, bool[,], nilnul.obj.matrix.Eq<bool>>
		,
		IEqualityComparer<Poll>
	{
		public Eq() : base( p=>p.votes)
		{
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq>.Instance;
			}
		}

	}
}
