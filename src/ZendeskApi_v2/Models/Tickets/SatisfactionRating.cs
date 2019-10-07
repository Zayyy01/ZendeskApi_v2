using Newtonsoft.Json;

namespace ZendeskApi_v2.Models.Tickets
{

    public class SatisfactionRating
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}
