namespace nilnul.bit
{
	public interface ITo
		:nilnul.obj.ITo1<bool>
	{ }

	public interface ITo<T> :
		obj.ITo<bool,T>
		,
		ITo {

	}
}
