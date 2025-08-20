namespace nilnul.bit.bi_
{

	public class Or :
		nilnul.bit.IBi
		,
		nilnul.bit.op_.BinaryI1
		,
		nilnul.obj.of_.BinaryI<bool>
	{
		public bool op(bool par, bool par1)
		{
			return _OrX.Bi(par, par1);
		}


		static public Or Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Or>.Instance;
			}
		}

	}




}
