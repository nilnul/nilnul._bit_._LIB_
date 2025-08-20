namespace nilnul.bit.expr_.tauto_.call_.binary_
{
	/// <summary>
	/// a tauto that is <see cref="expr_.call_.binary_.Imply"/>
	/// </summary>
	/// vs:
	///		<see cref="bit.op_.binary_.Imply"/>, which returns a bit,
	///			,whileas this returns void, and might throw excetion if it turns out to be not a <see cref="expr_.ITautology"/>
	interface IInference:ITautology { }

	static  class _InferenceX
	{
		/// <summary>
		/// the "->" becomes this when the expr becomes <see cref="ITautology"/>
		/// </summary>
		/// <remarks>
		/// -> in expr would return bit, while => in tautology would return nothing, which might be exception;
		/// </remarks>
		/// vs:
		///		|-, |=, and triple turnstile
		///		, are used for <see cref="bit.ProofI"/>
		///		
		public const string SYMBOL = "=>";
	}



}
