﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using static LiqpayWrapper.Data.Currencies;

namespace LiqpayWrapper.Data.Requests
{
    public class P2PCreditRequest : BaseRequest
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Currency Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("receiver_card")]
        public string ReceiverCard { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// "1" or null
        /// </summary>
        [JsonProperty("sandbox", NullValueHandling = NullValueHandling.Ignore)]
        public string Sandbox { get; set; }

        [JsonProperty("server_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerUrl { get; set; }

        [JsonProperty(PropertyName = "receiver_card_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverCardToken { get; set; }
    }
}
