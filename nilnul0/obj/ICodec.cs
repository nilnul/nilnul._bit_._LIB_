using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// encode obj to bits: obj->bits
	/// decode bits to obj: bits -> obj
	/// </summary>
	public interface ICodec
	{
	}

	public interface ICodec<TObj>:ICodec { }

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TObj"></typeparam>
	/// <typeparam name="TBits"><see cref="nilnul.bit.IStr"/>, it might also <see cref="bit.IVec"/></typeparam>
	public interface ICodec<TObj,TBits>:ICodec<TObj> { }


}
