using System;
using System.Collections.Generic;

namespace Joukou.Core.Circles
{
	public interface ICircle
	{
		IconType Icon { get; }
		string Description { get; }
		IEnumerable<IInPort> InPorts { get; }
		IEnumerable<IOutPort> OutPorts { get; } 
	}
}

