using System;

namespace Joukou.Core.Circles
{
	public class Port : IPort
	{
		public Port(){

		}

		public string Description { get; set; }
		public DataType DataType { get; set; }
		public bool Required { get; set; }
	}
}

