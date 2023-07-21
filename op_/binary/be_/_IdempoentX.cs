namespace nilnul.bit.op_.binary.be_
{
	/// <summary>
	/// x * x=x
	/// </summary>
	static public class _IdempoentX
	{
		static public bool Be(BinaryI1 op)
		{
			var x = new nilnul.bit.Var2();

			return nilnul.bit.expr_.plain.be_.Tauto.Singleton.be(
				nilnul.bit.expr_.plain_.call_.Binary.CreateEq(
					new nilnul.bit.expr_.plain_.call_.Binary(
						op
						,
						x
						,
						x

					)
					,
					x
				)
			);
		}
	}
}
