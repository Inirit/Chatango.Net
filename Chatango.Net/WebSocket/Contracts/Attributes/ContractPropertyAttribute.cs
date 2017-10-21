using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chatango.Net.WebSocket.Contracts.Attributes
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ContractPropertyAttribute : Attribute
	{
		public ContractPropertyAttribute(uint position, bool constant = false)
		{
			Position = position;
			Constant = constant;
		}

		public bool Constant { get; }

		public uint Position { get; }
	}
}