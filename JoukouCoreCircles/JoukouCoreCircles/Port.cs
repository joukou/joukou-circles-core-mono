using System;

namespace Joukou.Core.Circles
{
	public class Port : IPort
	{
		public Port(){

		}

		public string Name { get; set; }
		public string Description { get; set; }
		public DataType DataType { get; set; }
		public bool Required { get; set; }
		public bool Addressable {
			get {
				return false;
			}
		}

		internal void SendInformationPacket(IInformationPacket packet){

		}

		internal void ReceivedInformationPacket(IInformationPacket packet){

		}

		internal string RepresentAsJsonString(object value){
			return String.Empty;
		}
	}
}

