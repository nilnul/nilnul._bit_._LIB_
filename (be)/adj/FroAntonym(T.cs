using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.adj
{
	/// <summary>
	/// an adjective applicable to T. subtyping Func(T,bool) till singleton.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>Adjective is a bool function which partitions the objects in the domain in two.
	/// 
	/// </remarks>
	public partial class FroAntonym<T>
		:AdjI<T>
	{
		private AdjI<T> _adj;

		public AdjI<T> adj
		{
			get { return _adj; }
			set { _adj = value; }
		}
		
		public FroAntonym(AdjI<T> adj)
			
		{
			this._adj = adj;

		}
		public bool be(T val)
		{
			return  !adj.be(val);
		}
	}
}
