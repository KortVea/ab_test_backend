using System;
using Newtonsoft.Json;

namespace isaahvea
{
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Owner
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Transaction
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fromAccount")]
        public string FromAccount { get; set; }

        [JsonProperty("toAccount")]
        public string ToAccount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }
    }

}