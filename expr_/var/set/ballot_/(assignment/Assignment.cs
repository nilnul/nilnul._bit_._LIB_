using nilnul.bit.var.stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var.sortedSet.be;

namespace nilnul.bit.var.set
{
	/// <summary>
	/// before passing parameter to a function, the vars are assigned value and before arguments. 
	/// </summary>
	/// <remarks>
	/// The computed results by the funtion after taking in the assignment is not touched on here. The computed result, together with the assignment will be defined in "Interpretation"</remarks>
	/// 
	[Obsolete()]
	public class Assignment:Dictionary<bit.VarI1,bool>
	{

		public Assignment()
			:base(nilnul.bit.var.Eq.Singleton)
		{

		}
		public nilnul.bit.var.assignment.set_.ByVar toSet() {
			var r = new nilnul.bit.var.assignment.set_.ByVar();

			foreach (var item in this)
			{
				r.hashSet.Add(  new var.Assignment(item.Key,item.Value));
			}
			return r;
		}
		

		public IEnumerable<var.Assignment> enumerate() {
			return this.Select(a=>new var.Assignment(a));
		}

	public IEnumerable<var.Assignment> enumerateByOrder() {
			return this.Select(a=>new var.Assignment(a)).OrderBy(x=>x.var, nilnul.obj.var.comparer_.FroNaming.Lazy);
		}

		public override string ToString()
		{
			return $@"{ nilnul.str.ToTxtX.ToTxt1(
                enumerate().Select(x => x.ToString())
			)
			}";
		}

		public   string ToTxtOrdered()
		{
			return $@"{ nilnul.str.ToTxtX.ToTxt1(
                enumerateByOrder().Select(x => x.ToString())
			)
			}";
		}

		public var.Set vars {
			get {
				return new var.Set(Keys);
			}
		}

		static public Assignment _Create__sameCount(Distinct.Asserted vars1, IEnumerable<bool> vals
			
			) {

			var r = new Assignment();
			for (int i = 0; i < vars1.val.Count(); i++)
			{
				r.Add(vars1.val.ElementAt(i), vals.ElementAt(i));
			}
			return r;

		}

		static public Assignment _Create__sameCount(var.Set vars1, IEnumerable<bool> vals
			
			) {

			var r = new Assignment();
			for (int i = 0; i < vars1.Count(); i++)
			{
				r.Add(vars1.ElementAt(i), vals.ElementAt(i));
			}
			return r;

		}

	static public Assignment _Create__sameCount(IEnumerable<VarI1> vars1, IEnumerable<bool> vals
			
			) {

			var r = new Assignment();
			for (int i = 0; i < vars1.Count(); i++)
			{
				r.Add(vars1.ElementAt(i), vals.ElementAt(i));
			}
			return r;

		}

		static public IEnumerable<Assignment> _EnumerateToAssignments(IEnumerable<bit.VarI1> _distinct)
		{

			var x = _Enumerate(_distinct);

			foreach (var item in x)
			{
				yield return _Create__sameCount( _distinct, item);
			}

		}


		static public IEnumerable<IEnumerable<bool>> _Enumerate(IEnumerable<bit.VarI1> _distinct)
		{

			if (_distinct.Count() == 0)
			{
				yield return new bool[0];
				yield break;	//this is important.

			}

			//var firstVar = _distinct.First();

			foreach (
				var item in
				_Enumerate(
					_distinct.Skip(1).ToList())

			)
			{
				yield return nilnul.seq.Head.Eval(false, item);
				yield return nilnul.seq.Head.Eval(true, item);

			}

		}



	}
}
