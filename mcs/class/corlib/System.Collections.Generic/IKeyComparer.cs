//
// System.Collections.Generic.IKeyComparer
//
// Authors:
//	Ben Maurer (bmaurer@users.sourceforge.net)
//
// (C) 2003 Ben Maurer
//

using System;
using System.Runtime.InteropServices;

namespace System.Collections.Generic {
	[CLSCompliant(false)]
	[ComVisible(false)]
	public interface IKeyComparer<T> : IComparer<T> {
		bool Equals (T x, T y);
		int GetHashCode (T obj);
	}
}

