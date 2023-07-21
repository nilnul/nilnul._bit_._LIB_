namespace nilnul.bit.expr_.closed_
{
	/// <summary>
	/// involving only <see cref="bit.of_.IVec"/>;
	/// </summary>
	/// <remarks>
	/// as the variables are given in advance, we cannot have a str of vars;
	/// So for <see cref="IClosed"/>, requiring the op is vec is not necessary;
	/// </remarks>
	public interface ICall { }

	/// <summary>
	/// some expr can inherit <see cref="IClosed"/> (if they abide by the requirements), such as to become <see cref="IClosed"/>;
	/// eg:
	///		<see cref="expr_.IVar"/>
	///		,
	///		<see cref="expr_.capsule_._std.IMonomial"/>:<see cref="expr_.capsule_.std_._prod.IMaxterm"/>
	/// </summary>
	public interface INonCall { }

}
