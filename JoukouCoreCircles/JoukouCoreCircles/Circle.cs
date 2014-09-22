using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Joukou.Core.Circles
{
	public abstract class Circle : ICircle
	{
		public virtual IconType Icon {
			get { 
				return IconType.Default;
			}
		}

		public abstract string Description { get; }

		private ICollection<IInPort> _inPorts = new Collection<IInPort>();
		private ICollection<IOutPort> _outPorts = new Collection<IOutPort>();
		
		public IEnumerable<IInPort> InPorts {
			get {
				return _inPorts;
			}
		}
		public IEnumerable<IOutPort> OutPorts {
			get {
				return _outPorts;
			}
		}

		public Circle ()
		{

		}
		
		protected void RegisterPort(IInPort port){
			_inPorts.Add (port);
		}

		protected void RegisterPort(string name, IOutPort port){
			_outPorts.Add (port);
		}
	}
}

