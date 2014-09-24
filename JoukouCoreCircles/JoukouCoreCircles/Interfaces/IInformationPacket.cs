using System;

namespace Joukou.Core.Circles
{
	internal interface IInformationPacket
	{
		long Sequence { get; }
		string UUID { get; }
		string Data { get; }
	}
}

