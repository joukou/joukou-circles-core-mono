using System;
using RabbitMQ.Client;
using Newtonsoft.Json;

namespace Joukou.Core.Circles
{
	public class OutPort : Port, IOutPort
	{
		//TODO Output messaging 
		internal void SendInformationPacket(IInformationPacket packet){
			using (IConnection connection = connectionFactory.CreateConnection())
			{
				using (IModel channel = connection.CreateModel())
				{
					QueueDeclareOk queue = channel.QueueDeclare(routingKey, false, false, false, null);
					string message = JsonConvert.SerializeObject(packet);
					channel.BasicPublish(exchange, routingKey, null, EncodeMessage(message));
				}
			}
		}
	}
}

