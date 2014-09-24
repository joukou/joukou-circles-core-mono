using System;

namespace Joukou.Core.Circles
{
	public interface IPort
	{
		string Description { get; }
		DataType DataType { get; }
		bool Required { get; }
	}
}

