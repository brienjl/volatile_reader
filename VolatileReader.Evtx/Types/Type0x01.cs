using System;
using System.IO;

namespace VolatileReader.Evtx
{
	public class Type0x01 : IType
	{
		public Type0x01  (BinaryReader log, int size)
		{
			this.Length = size;
			
			this.String = System.Text.Encoding.Unicode.GetString(log.ReadBytes(size));
			Console.WriteLine(this.String);
		}
		
		public string String { get; set; }
		
		#region IType implementation
		public byte Type {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public int Length { get; set; }
		#endregion
	}
}

