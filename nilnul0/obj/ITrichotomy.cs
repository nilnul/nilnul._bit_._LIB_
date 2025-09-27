namespace nilnul.obj
{
	/// <summary>
	/// <see cref="obj.categorize_.ITrichotomy"/>
	/// </summary>
	/// <remarks>
	/// once trichotomized, we have such categories:
	///		true
	///		null
	///		false
	///		nontrue
	///		nonfalse
	///		nonnull
	///		: this is a topology, that is union of one category, and union of two category; we have also union of 0categroy, which is in fact empty|xpn, and union of 3categroy, which is de facto the type being categorized itself;
	///	<seealso cref="nilnul.obj.categorize.Topology"/>, where for n categories, we have a union of n-2 categories expressioned as cat0dog0hen, and express a union of n-1 categories as noncow, noncat, etc;
	/// </remarks>
	public interface ITrichotomy
		:nilnul.obj.categorize_.ITrichotomy
	{ }


}
