﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._proof
{
	/// <summary>
	/// modus pones (a ^ a->b) => b can be expressed as () = >b.
	/// </summary>
	public interface RuleI_blank
	{
	}

	public interface RuleI : RuleI_blank, _rule.ResultI {

	}
}
