using System;

namespace Joukou.Core.Circles
{
	public interface IPort
	{
		string Name { get; }
		string Description { get; }
		DataType DataType { get; }
		bool Required { get; }
		bool Addressable { get; }
	}
}

