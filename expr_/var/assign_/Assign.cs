using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using V = nilnul.bit.var.stati.Stati;
using V = nilnul.bit.VarI1;


namespace nilnul.bit.var
{

	public class Assign
	{
		private V _var;

		public V var
		{
			get { return _var; }
			set { _var = value; }
		}

		private bool _val;

		public bool val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Assign(V var, bool val)
		{
			_var = var;
			_val = val;
		}

		public Assign(KeyValuePair<V,bool> keyVal)
			:this(keyVal.Key,keyVal.Value)
		{

		}

		public override string ToString()
		{
			return $"{_var}={_val.ToTxt()}";
		}


	}
}
