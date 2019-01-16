﻿using Newtonsoft.Json;

namespace LiqpayWrapper.Data.Responses.Acquiring
{
    public class UnsubscribeResponse : AcquirerResponse
    {
        [JsonProperty("token")]
        public string Token { get; private set; }

        [JsonProperty("card_token")]
        public string CardToken { get; private set; }
    }
}
