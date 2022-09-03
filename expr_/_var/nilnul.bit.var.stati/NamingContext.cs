using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.stati
{
	public class NamingContext
	{

		static public Stati Create(string name) {

			return Create(name, nilnul.obj.var.NamingContext3.StaticContext);


		}
		static public Stati Create1(string name) {

			return Create1(name, nilnul.var.set.NamingContext_ofVarI.Instance);


		}


		static public Stati Create1(string name,nilnul.var.set.NamingContext_ofVarI context) {
			var x = new nilnul.bit.var.stati.Stati();

			context.setName(x, name);

			return x;

		}



		static public Stati Create(string name,nilnul.obj.var.NamingContext3 context) {
			var x = new nilnul.bit.var.stati.Stati();

			context.name(x, name);

			return x;

		}

		static public Stati _GetOrCreate(string name) {
			return _GetOrCreate(name, nilnul.obj.var.NamingContext3.StaticContext);

		}

		static public Stati _GetOrCreate(string name,nilnul.obj.var.NamingContext3 context) {
			if (context.containName(name) )
			{
				return context.names.Where(x1 => x1.Value == name).First().Key as Stati;
			}
			
			var x = new nilnul.bit.var.stati.Stati();

			context.name(x, name);

			return x;

		}



	}
}
