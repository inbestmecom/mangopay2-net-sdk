﻿using Newtonsoft.Json;
using RestSharp.Serializers;

namespace MangoPay.SDK.Core
{
    public sealed class MangoPayJsonSerializer : ISerializer
    {
        public RestSharp.ContentType ContentType { get; set; }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
