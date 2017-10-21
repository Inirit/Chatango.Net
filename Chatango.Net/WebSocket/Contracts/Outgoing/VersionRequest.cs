using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chatango.Net.WebSocket.Contracts.Attributes;

namespace Chatango.Net.WebSocket.Contracts.Outgoing
{
	[ContractIdentifier("v")]
	public class VersionRequest : Contract
	{
	}
}