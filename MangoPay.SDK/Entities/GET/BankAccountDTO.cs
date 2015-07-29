﻿using MangoPay.SDK.Core.Enumerations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace MangoPay.SDK.Entities.GET
{
    /// <summary>Bank Account base entity.</summary>
    public class BankAccountDTO : EntityBase
    {
        /// <summary>User identifier.</summary>
        public String UserId { get; set; }

        /// <summary>Type of bank account.</summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public BankAccountType Type { get; set; }

        /// <summary>Owner name.</summary>
        public String OwnerName { get; set; }

        /// <summary>Owner address.</summary>
		public Address OwnerAddress { get; set; }
    }
}
