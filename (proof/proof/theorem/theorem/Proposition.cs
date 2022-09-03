using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.set;
using nilnul.set;



namespace nilnulTheorem
{

	/// <summary>
	/// A proposal has a value:true or false, thus result in a trueProposal or falseProposal.
	/// 
	/// Note it cannot be undecided true or false. But it can be unknown, e.g. 2008-1-1 is sunny, though we don't know now, we can know in the future.
	/// 
	/// 断给定句子是否为命题，应该分两步：首先判定它是否为陈述句，其次判断它是否有唯一的真值。
	/// 
	/// 
	/// A proposition and it's negative proposition partitioned all the elements into too subsets, one of which contains all the elements that make the proposition true while the other make the proposition false. No subsets that whose elements can make the proposition both true or false.
	/// By doing so, we correspond the propostion with a set.
	/// 
	/// A Propostion can take no elements, that means no matter what elements you come up with, the propostion is true. So the corresponing set is Universal Set. A false proposition corresponds to an empty set.
	/// 
	/// An implication corresponds a subset relation. i.e., A->B means the elements make A true can alwasy make B true. So A is subset of B. This make it easy to understand truth Table.
	/// </summary>
	public class Proposition:Element
		
	{

		//an expression that's of type bool
		//a block of code return bool.


	}
}
