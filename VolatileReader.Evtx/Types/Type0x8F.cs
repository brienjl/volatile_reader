using System;
using System.IO;

namespace VolatileReader.Evtx
{
	public class Type0x8F : IType
	{
		public Type0x8F  (BinaryReader log, int size)
		{
			throw new NotSupportedException();
		}

		#region IType implementation
		public byte Type {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public int Length {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
		#endregion
	}
}
