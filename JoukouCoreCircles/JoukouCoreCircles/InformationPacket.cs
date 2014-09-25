using System;

namespace Joukou.Core.Circles
{
	internal struct InformationPacket : IInformationPacket
	{
		public long Sequence { get; set; }
		public string UUID { get; set; }
		public string Data { get; set; }
	}
}

