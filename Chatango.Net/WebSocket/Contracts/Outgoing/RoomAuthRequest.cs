using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chatango.Net.WebSocket.Contracts.Attributes;

namespace Chatango.Net.WebSocket.Contracts.Outgoing
{
	[ContractIdentifier("bauth")]
	public class RoomAuthRequest : Contract
	{
		[ContractProperty(1)]
		public string RoomName { get; set; }

		// TODO Figure out what this value is
		[ContractProperty(2)]
		public string UnknownValue0 { get; set; }

		[ContractProperty(3)]
		public string UserName { get; set; }

		[ContractProperty(4)]
		public string Password { get; set; }
	}
}