using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.type;

namespace nilnul.bit
{
	public partial class PredicateSingleton
		:nilnul.type.Singleton<PredicateSingleton>

	{

		static private readonly PredicateSingleton _Instance = new PredicateSingleton();
		static public PredicateSingleton Instance
		{
			get
			{
				return _Instance;
			}
		}
		private PredicateSingleton()
		{

		}
				
		static PredicateSingleton() {
			nilnul.type.Singleton<PredicateSingleton>._Instance = _Instance;
			
		}
	}
}
