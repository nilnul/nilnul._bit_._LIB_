﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using Naming = nilnul.obj.var.set.NamingContext;

namespace nilnul.bit.var.set
{
	/// <see cref="nilnul.obj.var._phrase.Glossary"/>
	/// <summary>
	/// 
	/// </summary>
	public class NamingContext
	{

		
		static public V Create1(string name) {

			return Create1(name, Naming.Instance);

		}

		static public Var2 CreateAs_Var2_(string name) {

			return CreateAs_Var2_(name, Naming.Instance);

		}



		static public V Create1(string name, Naming context) {
			var x = new nilnul.bit.Var2();

			context.setName(x, name);

			return x;

		}


		static public Var2 CreateAs_Var2_(string name, Naming context) {
			var x = new nilnul.bit.Var2();

			context.setName(x, name);

			return x;

		}



		static public V _GetOrCreate(string name) {
			return _GetOrCreate(name, Naming.Instance);

		}

		static public V _GetOrCreate(string name,Naming context) {
			if (context.containName(name) )
			{
				return context.getVarByName<V>(name) ;
			}
			
			var x = new nilnul.bit.Var2();

			context.setName(x, name);

			return x;

		}



	}
}
