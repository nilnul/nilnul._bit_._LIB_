using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E= nilnul.bit.ExprI_membered;

namespace nilnul.bit.sys
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.bit._theorem._proposal.Proof))]
	public class Proof
	{

		private IEnumerable<bit._proof.RuleI> _rules;

		public IEnumerable<bit._proof.RuleI> rules
		{
			get { return _rules; }
			set { _rules = value; }
		}


		public bool isValid(Sys sys, E conclusion) {

			var theorems =  sys.assumptions;

			bit._proof.rule.eg.Substitue s;
			bit._proof.rule.eg.Replace r;
			foreach (var item in _rules)
			{
				if (item is bit._proof.rule.eg.Substitue )
				{
					s = item as bit._proof.rule.eg.Substitue;

					if (!sys.assumptions.Contains(s.inferRule)) {
						return false;
					}
					else
					{
						theorems.add(s.result);
					}

				}
				else	//replace
				{
					r = item as bit._proof.rule.eg.Replace;
					if (sys.assumptions.Contains( r.original) )
					{
						theorems.add(r.result);
					}
					else
					{
						return false;
					}
				}

			}

			if (this.rules.Count() ==0)
			{
				return false;

			}
			if (expr.Eq.Singleton.Equals (this.rules.Last().result, conclusion ))
			{
				return true;
			}
			return false;
		}

	}
}
