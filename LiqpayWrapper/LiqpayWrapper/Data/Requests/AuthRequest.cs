﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using static LiqpayWrapper.Data.Currencies;

namespace LiqpayWrapper.Data.Requests
{
    public class AuthRequest : BaseRequest
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

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("card_exp_month")]
        public string CardExpMonth { get; set; }

        [JsonProperty("card_exp_year")]
        public string CardExpYear { get; set; }

        [JsonProperty("card_cvv")]
        public string CardCvv { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }


        // -------------- 3DS parameters
        [JsonProperty("mpi_pares", NullValueHandling = NullValueHandling.Ignore)]
        public string MpiPares { get; set; }

        [JsonProperty("mpi_md", NullValueHandling = NullValueHandling.Ignore)]
        public string MpiMd { get; set; }

        // ------------- Other parameters
        [JsonProperty("verifycode", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyCode { get; set; }

        [JsonProperty("suburl", NullValueHandling = NullValueHandling.Ignore)]
        public string SubUrl { get; set; }
    }
}
