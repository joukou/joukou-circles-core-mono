using System;

namespace Joukou.Core.Circles
{
	internal struct InformationPacket : IInformationPacket
	{
		long Sequence { get; set; }
		string UUID { get; set; }
		string Data { get; set; }
	}
}

