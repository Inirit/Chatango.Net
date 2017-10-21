using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Chatango.Net.WebSocket.Contracts.Attributes;
using Chatango.Net.WebSocket.Contracts.Interfaces;

namespace Chatango.Net.WebSocket.Contracts
{
	public abstract class Contract : IContract
	{
		[ContractProperty(0)]
		public string Identifier
		{
			get
			{
				var identifierAttribute = GetType().GetCustomAttribute<ContractIdentifierAttribute>(false);

				if (identifierAttribute == null)
				{
					var errorMessage =
						$"Unable to get identifier for contract {GetType().Name}, identifier attribute could not be found.";

					// TODO Don't throw generic exceptions
					throw new Exception(errorMessage);
				}

				return identifierAttribute.Identifier;
			}
			// ReSharper disable once ValueParameterNotUsed
			set
			{
				// Do nothing. Exposed for deserialization
			}
		}
	}
}