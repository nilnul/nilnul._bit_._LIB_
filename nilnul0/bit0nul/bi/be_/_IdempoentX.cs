namespace nilnul.bit0nul.bi.be_
{
	/// <summary>
	/// x * x=x
	/// </summary>
	static public class _IdempotentX
	{
		static public bool IsIdempotent(this nilnul.obj.of_.BinaryI<bool?> op)
		{
			foreach (var item in bit0nul._SortieX.ARRAY)
			{
				if (op.op(item,item) == item)
				{
					continue;
				}
				return false;
			}
			return true;
		}
	}
}
