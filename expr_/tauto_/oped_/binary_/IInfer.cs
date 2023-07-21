namespace nilnul.bit.expr_.tauto_.call_.binary_
{
	/// <summary>
	/// a tauto that is <see cref="expr_.call_.binary_.Imply"/>
	/// </summary>
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
