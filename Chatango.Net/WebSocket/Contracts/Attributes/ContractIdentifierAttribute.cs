using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.Annotations;

namespace Chatango.Net.WebSocket.Contracts.Attributes
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ContractIdentifierAttribute : Attribute
	{
		public ContractIdentifierAttribute([NotNull] string identifier)
		{
			Identifier = identifier;
		}

		public string Identifier { get; }
	}
}