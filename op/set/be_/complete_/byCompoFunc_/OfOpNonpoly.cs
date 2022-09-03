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

namespace nilnul.bit.op.set.be_.complete_.byCompoFunc_
{
	/// <summary>
	/// assume ops with arity le2.
	/// there must be one binary_op, or else it's not complete.
	/// If it includes all binary_.op, then it's complete; <see cref="nilnul.bit.expr_.closed_.canonic.op_.of_.OfClosed"/>
	/// </summary>
	/// <remarks>
	/// by composing truth tables.
	/// 
	/// </remarks>
	///
	[Obsolete(nameof(op_.of_.vec.set.be_.Complete))]
	public class AssumeArityNonpoly
	{
		public bit.OpI2[] ops;
		public List<Poll> truthTables = new List<Poll>();

		public List<Poll> newTables = new List<Poll>();

		public AssumeArityNonpoly(IEnumerable<bit.OpI2> ops)
		{
			this.ops = ops.ToArray();
		}

		public AssumeArityNonpoly(params nilnul.bit.OpI2[] singleton1)
		{
			nilnul.bit.vow_._TrueX.Vow(
				singleton1.All(
					x => x is nilnul.bit.op_.UnaryI1
					||
					x is nilnul.bit.op_.BinaryI1
					||
					x is nilnul.bit.op_.NaryI
					||
					x is nilnul.bit.op_.of_.VecI

					)
				,
				new ArgumentOutOfRangeException($"{singleton1} has some op with arity gt 2.")
			);

			this.ops = singleton1;
		}

		public bool compute()
		{
			initProjection();
			initOnVarPrimitives();
			keepComposite();
			return truthTables.Count == 16;
		}
		void initProjection() {
			// in composite, we may use the var itself. var itself is not a nilary op, but it's more primitive than nilary op as it's used expr_.VarAsExpr
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

		public void initOnVarPrimitives()
		{
			//head and tail operators are implied. but we cannot take that as operators, we they can only applied to the original vars, not on subexpression later assembled.

			if (ops.None(
				o => o is nilnul.obj.op_.BinaryI<bool>
			))
			{
				return;
			}

			/// get the var.assignments
			///

			var bits = nilnul.bit.Sortie.OfAll();
			var bitCoEs = nilnul.bit.co.Sortie.All;

			var varIndexs = Enumerable.Range(0, 2);




			foreach (var op in ops)
			{

				if (op is op_.NaryI naryOp)
				{
					var truthTable = bit.tup.sortie_.omni.Poll.OfAllots1results(
						bitCoEs.ee.Select(allot => nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
							allot
						))
						,
						Enumerable.Repeat(
							naryOp.op(),4
						)
					);

					if (
						this.containInBothTables(
truthTable
							)

					//newTables.Contains(
					//	,
					//	nilnul.bit.tup.sortie_.omni.poll.Eq.Singleton
					//)
					)
					{

					}
					else
					{
						newTables.Add(truthTable);
					}

				}
				else if (op is op_.UnaryI1 uniop)
				{
					/// for unary op, change it to binary op.
					///  for neg(x), change it to negHead(x,y), negTail(x,y); or to nand(x,x).
					///

					//select one from {x,y}. element can be repeatedly selected.

					for (int varIndex = 0; varIndex < 2; varIndex++)
					{
						//generate a truth table

						var results = new List<bool>();

						foreach (var allot in bitCoEs.ee)
						{
							var r = uniop.op(
								nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
								allot
							).ElementAt(varIndex)
							);
							results.Add(r);

						}

						var truthTable = bit.tup.sortie_.omni.Poll.OfAllots1results(
							bitCoEs.ee.Select(allot => nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
								allot
							))
							,
							results

						);
						if (
							this.containInBothTables(
truthTable
								)

						//newTables.Contains(
						//	,
						//	nilnul.bit.tup.sortie_.omni.poll.Eq.Singleton
						//)
						)
						{

						}
						else
						{
							newTables.Add(truthTable);
						}


					}

				}
				else if (op is op_.BinaryI1 biOp)
				{

					//combinate two
					var varsSelected = nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<int>.Singleton.cumulate_each2monos(
						varIndexs, varIndexs
					);

					foreach (var varsSelectionEntry in varsSelected)
					{


						//generate a truth table

						var results = new List<bool>();

						foreach (var allot in bitCoEs.ee)
						{
							var r = biOp.op(
								nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
									allot
								).ElementAt(varsSelectionEntry.First())
								,
								nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
									allot
								).ElementAt(varsSelectionEntry.Last())

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
				else if(op is nilnul.bit.op_.of_.VecI ofVec)
				{

//combinate two
					var varsSelected = nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<int>.Singleton.cumulate(
						Enumerable.Repeat(

						varIndexs		//the pars for the expected biOp
						,
						ofVec.arity
						)
					);

					foreach (var varsSelectionEntry in varsSelected)
					{


						//generate a truth table

						var results = new List<bool>();

						foreach (var allot in bitCoEs.ee)
						{
							var r = ofVec.op(
								varsSelectionEntry.Select(
									varIndex=>nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
									allot
								).ElementAt(varIndex)
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
				else
				{
					throw new UnexpectedTypeException($"{op} must be nilary, unary, binary, or {nameof(bit.op_.of_.VecI)}");
				}



			}
			truthTables.AddRange(newTables);
			newTables.Clear();






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

				if (op is op_.NaryI naryOp)
				{
					var truthTable = bit.tup.sortie_.omni.Poll.OfAllots1results(
						bitCoEs.ee.Select(allot => nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
							allot
						))
						,
						Enumerable.Repeat(
							naryOp.op(), 4
						)
					);

					if (
						this.containInBothTables(
truthTable
							)

					//newTables.Contains(
					//	,
					//	nilnul.bit.tup.sortie_.omni.poll.Eq.Singleton
					//)
					)
					{

					}
					else
					{
						newTables.Add(truthTable);
					}
				}

					///for nilary op, no new tables can be added.

				else	if (op is op_.UnaryI1 uniop)
				{

				/// for unary op, change it to binary op.
				///  for neg(x), change it to negHead(x,y), negTail(x,y); or to nand(x,x).
				///

					//select one from current truthtable element can be repeatedly selected.

					for (int varIndex = 0; varIndex < truthTables.Count; varIndex++)
					{
						//generate a truth table

						var results = new List<bool>();

						foreach (var allot in truthTables[varIndex].votes.Col(2))
						{
							var r = uniop.op(

								allot

							);
							results.Add(r);

						}


						var truthTable = bit.tup.sortie_.omni.Poll.OfAllots1results(
							bitCoEs.ee.Select(allot => nilnul.obj.str.op_.of_._OfTupleX.ToSeq<bool>(
								allot
							))
							,
							results

						);
						if (
							containInBothTables(truthTable)
						//newTables.Contains(truthTable, nilnul.bit.tup.sortie_.omni.poll.Eq.Singleton)

						)
						{

						}
						else
						{
							newTables.Add(truthTable);
						}


					}

				}
				else if (op is op_.BinaryI1 biOp)
				{
					var currentTablesCount = truthTables.Count;
					var currentTableIndexRange = Enumerable.Range(0, currentTablesCount);


					//combinate two
					var varsSelected = nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<int>.Singleton.cumulate_each2monos(
						currentTableIndexRange, currentTableIndexRange
					);


					foreach (var varsSelectionEntry in varsSelected)
					{


						//generate a truth table

						var results = new List<bool>();

						foreach (var allot in Enumerable.Range(0, 4))
						{


							var r = biOp.op(
								truthTables[varsSelectionEntry.First()].votes.Col(2).ElementAt(allot)

								,
								truthTables[varsSelectionEntry.Last()].votes.Col(2).ElementAt(allot)

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
							newTables.Contains(truthTable, nilnul.bit.tup.sortie_.omni.poll.Eq.Singleton)
							||
							truthTables.Contains(truthTable, nilnul.bit.tup.sortie_.omni.poll.Eq.Singleton)
						)
						{

						}
						else
						{
							newTables.Add(truthTable);
						}

					}

				}

				else if (op is nilnul.bit.op_.of_.VecI ofVec)
				{

					var currentTablesCount = truthTables.Count;
					var currentTableIndexRange = Enumerable.Range(0, currentTablesCount);




					//combinate two
					var funcRange = nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<int>.Singleton.cumulate(
						Enumerable.Repeat(

							currentTableIndexRange       //the pars for the expected biOp
							,
							ofVec.arity
						)
					);

					foreach (var funcsSelected in funcRange)
					{


						//generate a truth table

						var results = new List<bool>();

						foreach (var allot4biopInput in Enumerable.Range(0, 4))
						{
							var r = ofVec.op(
								
								funcsSelected.Select(
									funcIndex =>truthTables[funcIndex].votes.Col(2).ElementAt(allot4biopInput)
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
				//else // might be nilary op
				//{
				//	throw new UnexpectedTypeException($"{op} must be nilary, unary, binary, or {nameof(bit.op_.of_.VecI)}");
				//}

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
