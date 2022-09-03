using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{

	public partial class StaticAssert<StaticIs>
	{
		static MethodInfo _method;

		static Type _inputType;

		static  StaticAssert()
		{
			var m=(typeof(StaticIs)).GetMethod("Is");

			var t=m.GetParameters();
			if (t.Count()!=1)
			{
				throw new Exception();

				
			}
			var p = t[0];
			_inputType= p.ParameterType;
			_method = m;
			

		}

		static public bool Is(object obj) {
			if (obj==null)
			{
				if (_inputType.IsValueType)
				{
					return false;

				}
				else
				{
					return (bool)(_method.Invoke(null, new object[]{obj}));

				}
				
			}

			if (!_inputType.IsAssignableFrom(obj.GetType()))
			{
				return false;

				
			}
				
			return (bool)(_method.Invoke(null, new object[]{obj}));


 

		
		}
					
	
	}
}
