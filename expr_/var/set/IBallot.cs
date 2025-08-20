using nilnul.bit.var.set;

namespace nilnul.bit.expr_.var.set
{
	/// <summary>
	/// a dictionary{var, bool}
	/// eg:
	///		{x,!y,z} -> 1
	///	eg:
	///		{} ->0
	/// </summary>
	/// <remarks>
	/// given a set of candidates, a voter gives each a yea or nay.
	/// equivalent to selection of some from many during an election.
	/// </remarks>
	///	alias:
	///		
	///		Poll
	///			vs Vote, which is yes/no for a single question, poll is yes/no for each and every memeber of a set.
	///			,short
	///			, same chars as vote
	///			, "ll" tinges "all"
	///			, subset of "po"werset
	///			vs Vote, which is yes/no for a single question, poll is yes/no for each and every memeber of a set.
	///			
	///		checklist
	///			, <see cref="obj._parse.CheckI"/>
	///		check
	///			,
	///			used in <see cref="obj._parse.CheckI"/>
	///	nomenclature:
	///		Ballot
	///			b all of biT
	///			
	///		Assignment
	///			assign value to each/every var
	///		allot
	///			all of typedVal
	///				vs assign: assign is for a single variable
	///			like ballot, but without B
	///			,
	///			<see cref="set.ballot.IVote"/>
	///		checklist
	///		check
	///		checks
	///		
	///		vote
	/// 
	interface IBallot { }

	static  class _BallotX
	{
		public const string RUNE = "\U0001f5f3";
	}
}
