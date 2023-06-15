namespace nilnul.bit
{
	public interface ITo
		:nilnul.bit.IOp
	{ }

	public interface ITo<T> :
		obj.IOp<bool,T>
		,
		ITo {

	}
}
