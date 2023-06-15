using nilnul.bit.op_.binary_;
using nilnul.bit.op_.unary_;
using nilnul.bit.tup.sortie_.omni;
using nilnul.bit.vars.assignment.interpretations;
using nilnul.obj.matrix;
using nilnul.obj.seq_.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.of_.vec.set.be_
{
	/// <summary>
	/// if any positive-ary function can be expressed.
	/// nullary func may not be expressed.
	/// If we want to express nullary function <see cref=""/>
	/// </summary>
	public interface IComplete {

	}
	/// <summary>
	/// If it includes all binary_.op, then it's complete; <see cref="nilnul.bit.expr_.closed_.canonic.op_.of_.OfClosed"/>
	/// </summary>
	/// <remarks>
	/// by composing truth tables.
	/// 
	/// </remarks>
	/// vs: 
	///  E. L. Post, The two-valued iterative systems of mathematical logic, Annals of Mathematics studies, no. 5, Princeton University Press, Princeton 1941, 122 pp.
	public class Complete
	{
		public bit.op_.of_.VecI[] ops;
		public List<Poll> truthTables = new List<Poll>();

		public List<Poll> newTables = new List<Poll>();

		public Complete(IEnumerable<bit.op_.of_.VecI> ops)
		{
			this.ops = ops.ToArray();
		}

		public Complete(IEnumerable<nilnul.bit.OpI2> singleton1)
			: this(
singleton1.Select(
				op => op switch
				{
					nilnul.bit.op_.NaryI x => nilnul.bit.op_.Nary.Of(x)
					,

					bit.op_.UnaryI1 x => nilnul.bit.op_.Unary.Of(x)
,

					nilnul.bit.op_.BinaryI1 x => nilnul.bit.op_.Binary.Of(x)
					,

					nilnul.bit.op_.of_.VecI x => x,
					_ => throw

			   new ArgumentOutOfRangeException($"{op} must be converted to {typeof(nilnul.bit.op_.of_.VecI).FullName}")
				}
			)

				 )

		{



		}

		public Complete(params nilnul.bit.OpI2[] ops) : this(
			(IEnumerable<nilnul.bit.OpI2>)ops
		)
		{




		}




		public Complete(params nilnul.bit.op_.of_.VecI[] ops)
			:
this(
			(IEnumerable<nilnul.bit.op_.of_.VecI>)ops
		)
		{


		}

		public bool compute()
		{
			initProjection();
			//initOnVarPrimitives();
			keepComposite();
			return truthTables.Count == 16;
		}
		void initProjection()
		{
			// in composite, we may use the var itself. var itself is not a nilary op, but it's more primitive than nilary op as it's used expr_.VarAsExpr
			/// todo: shall we automatically incude the projection as an op? or including the projection or not, would it affect the op.Set 's completeness?
			///  once we include the projection op, it would not only be used as input, but also can act as an op to take any other constructed exprs. we would have the following func at hand:
			///		(x,y) => x.
			///	To apply this func to a subexpr, doesnot add value, as we allow that a subexpr (except the var itself) to return directly.
			///	
			///		
			///	conjecture:
			///		if op.Set is incomplete, then adding projection to the set would not make it complete.
			///		proof:
			///			if the op.Set is empty, then adding both projections to it is not incomplete.
			///			only projections, of various arity, are not complete.
			///		  for any subexpr that is projection expr, we donot increase the count of truthtables, as projection is just to choose between an expr from the inputs.
			///		  for any expr that takes projection as input:
			///			it can take the par directly. So this nor increases the truthTables.
			///		proof by contradction:
			///			when added projection(s), the op.Set gets complete.
			///			Then we can remove the use of projections to make it still complete. This contradicts the assumption that it's incomplete.
			///
			/// 
			///		if op.Set is complete, removing projection wouldnot make it incomplete.
			///			we can just replace the projection with the selected input subexpr. Then the projection op is not used.
			///

			/// the proof is import for us to feel comfortable to directly use
			///		f(x,y) =x     //we don't apply any op here. or in other words, we applied the projection op, which is implicit op whenever we need it. Or we can say that x itself is a projection of the various values of the input (a tup of args)
			///		in checking completeness of <see cref="op_.of_.vec.set.be_.Complete"/>
			///

			truthTables.Add(
				bit.tup.sortie_.omni.Poll.OfAllots1results(
						nilnul.bit.co.Sortie.All.ee.Select(
							allot => nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
								allot
							)
						)
						,
						new bool[] {
							false,false,true,true
						}
					)
			);
			truthTables.Add(

				bit.tup.sortie_.omni.Poll.OfAllots1results(
						nilnul.bit.co.Sortie.All.ee.Select(
							allot => nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
								allot
							)
						)
						,
						new bool[] {
							false,true,false,true
						}
					)
			);

		}

		public void keepComposite()
		{
			/// get the var.assignments
			///
			var bits = nilnul.bit.Sortie.OfAll();
			var bitCoEs = nilnul.bit.co.Sortie.All;

			///the pars for the expected biOp
			var varIndexs = Enumerable.Range(0, 2);

			foreach (var op in ops)
			{
				var currentTablesCount = truthTables.Count;
				var currentTableIndexRange = Enumerable.Range(0, currentTablesCount);

				//combinate for the arity
				var funcRange = nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<int>.Singleton.cumulate_each2monos(
					Enumerable.Repeat(

						currentTableIndexRange       //the pars for the expected biOp
						,
						op.arity
					)
				);

				foreach (var funcsSelected in funcRange)
				{


					//generate a truth table

					var results = new List<bool>();

					foreach (var allot4biopInput in Enumerable.Range(0, 4))
					{
						var r = op.op(

							funcsSelected.Select(
								funcIndex => truthTables[funcIndex].votes.Col(2).ElementAt(allot4biopInput)
							)

						);
						results.Add(r);
					}

					var truthTable = bit.tup.sortie_.omni.Poll.OfAllots1results(
						bitCoEs.ee.Select(
							allot => nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
								allot
						))
						,
						results

					);

					if (
						this.containInBothTables(
truthTable
							))


					{

					}
					else
					{
						newTables.Add(truthTable);
					}

				}
			}

			if (newTables.Any())
			{
				truthTables.AddRange(newTables);
				newTables.Clear();
				keepComposite();
			}
			else
			{

			}


		}

		public bool containInBothTables(Poll truthTable)
		{
			return
			newTables.Contains(
				truthTable, nilnul.bit.tup.sortie_.omni.poll.Eq.Singleton
			)
							||
							truthTables.Contains(
								truthTable, nilnul.bit.tup.sortie_.omni.poll.Eq.Singleton
					);
		}
	}
}
