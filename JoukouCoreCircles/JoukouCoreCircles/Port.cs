using System;
using RabbitMQ.Client;
using System.Text;

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

		internal protected string routingKey = null;
		internal protected string exchange = null;
		internal protected ConnectionFactory connectionFactory = null;

		internal protected void SetupConnectionFactory(){
			//TODO read environment variables to get the host name, routingKey & exchange 
			connectionFactory = new ConnectionFactory () { HostName = "localhost" };
		}

		internal protected byte[] EncodeMessage(string message){
			return Encoding.UTF8.GetBytes (message);
		}

		internal string RepresentAsJsonString(object value){
			return String.Empty;
		}
	}
}

