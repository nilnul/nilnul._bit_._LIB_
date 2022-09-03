using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.objs.be_.distinct.vow;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.var.sortie_
{
	[Obsolete()]
	public class List:nilnul.bit.var.SortieI,IEnumerable<nilnul.bit.VarI1>
	{
		private List<nilnul.bit.VarI1> _vars;

		public List<nilnul.bit.VarI1> vars
		{
			get { return _vars; }
			//set { _var = value; }
		}

		public En1<V> asDistinct => throw new NotImplementedException();

		public List():this(new V[] { })
		{

		}



		public List(List<nilnul.bit.VarI1> vars)
		{
			_vars = new List<VarI1>(vars);
		}

		public List(IEnumerable<V> vars)
		{
			_vars = new List<VarI1>(vars);
		}

		public void append(nilnul.bit.VarI1 var) {

			nilnul.obj.vow_.False.Vow(_vars.Contains(var));

			_vars.Add(var);

		}
		public void removeLast() {


			_vars.RemoveAt(_vars.Count()-1);

		}

		public List cloneAndAppend(nilnul.bit.VarI1 var) {

			nilnul.obj.vow_.False.Vow(_vars.Contains(var));

			var newList = new List( _vars);
			newList.append(var);

			return newList;

		}



		public List cloneAndRemoveLast() {


			var newList = new List( _vars);

			newList.removeLast();
			return newList;

		}

		public void remove(V var) {
			_vars.Remove(var);
		}


		public List cloneAndRemove(V var) {


			var newList = new List( _vars);

			newList.remove(var);
			return newList;

		}

		public bool contain(nilnul.bit.VarI1 var) {
			return _vars.Contains(var);
		}

		public IEnumerator<VarI1> GetEnumerator()
		{
			return _vars.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}

		static public List CreateOfCount(int i) {
			var l = new List<VarI1>(i);
			for (int k = 0; k < i; i++)
			{
				l[i] = new nilnul.bit.Var2();
			}

			return new List(l);
		}
	}
}
