using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chatango.Net.WebSocket.Contracts.Attributes;

namespace Chatango.Net.WebSocket.Contracts.Incoming
{
	[ContractIdentifier("v")]
	public class VersionResponse : Contract
	{
		// TODO Figure out what this value is
		[ContractProperty(1)]
		public string UnknownValue0 { get; set; }

		// TODO Figure out what this value is
		[ContractProperty(2)]
		public string UnknownValue1 { get; set; }
	}
}