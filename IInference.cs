namespace nilnul.bit
{
	///pop-sci.com/哥德尔不完全性定理-（一）/
	///作者 ：刘洁民博士
	///
	/// 17世纪德国哲学家、数学家莱布尼茨（Gottfried Wilhelm Leibniz，1646～1716）。他认为，哲学中很多问题争论不休的原因是概念和问题的表述不清楚理解不一致而推理过程又不够严谨。于是他提出一个构想：通过建立一种“普遍文字”使哲学概念和命题符号化，使哲学推理变成逻辑演算。也就是说，用一种严格单义的符号串来表示思想，通过这些符号串的变换来表示推理和论证。他在“通向一种普遍文字”一文中写道：“我思考出，必然会创造出一种人类思想的字母，通过由它组成的联系和词的分析，其他一切都能被发现和判断。”在“综合科学序言”一文中他进一步说：“倘若我们能找到一些字或符号适宜于表述我们的全部思想，象算术表明数字或几何学的分析表明线那样明确和正确的话，我们就能在一切科目中，在它们符合推理的范围内，完成象在算术和几何学中所完成的东西。”“所有依靠推理的探究都要通过字的变换和某一种演算，它们会直接促进完美答案的发现。我们没有必要象今天所需要的那样绞尽脑汁，在已知的论据所容许的范围内，我们会确有把握地完成一切。”莱布尼茨上述构想的本质就是用符号化的人工语言取代自然语言，这正是数理逻辑的基本思想。莱布尼茨提出了少量基本概念（例如逻辑加法、乘法、等同、否定和空集）、关系（例如包含和等价）、公理和推演规则，并在此基础上推演出若干命题。因为这些工作，他被认为是数理逻辑的创始人，但他并未完成自己的计划，只做了少量逻辑推演，没有形成一个完整的逻辑系统。
	///
	/// Here, for <see cref="nilnul.IBit"/>, it's boole agebra. For more complex algebra, see <see cref="nilnul.ILogic"/> later.
	///
	///
	/// ⊨
	/// <summary>
	/// It can be represented as a formal language:
	///		start symbols as axioms
	///		production rules, as decution rules.
	///	the resulted sentence is proven theorems.
	/// </summary>
	/// <remarks>
	/// symbols and a string of symbols.
	/// , some of those are well formed forumlas.
	/// , some well formed formulas are theorems.
	/// </remarks>
	///<seealso cref="nameof(ProofI)"/>
	/// vs:
	///		induction
	///			,with some probability
	///		reduction
	///			,as in language production rule reduction.
	///	alias:
	///		deduction, which is a proof method, in contrast with induction, etc;
	///		reduction, which is a production inferrence method used in lang production rules;
	///		reasoning;
	///
	public interface IInference { }
/*
A deductive system is used to demonstrate, on a purely syntactic basis, that one formula is a logical consequence of another formula.

	finite deductions themselves are often called derivations in proof theory. They are also often called proofs



	 */

}

