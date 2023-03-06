using Newtonsoft.Json;

namespace CatWorx.BadgeMaker
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Id
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class Info
    {
        [JsonProperty("seed")]
        public string? Seed { get; set; }

        [JsonProperty("results")]
        public int Results { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }
    }

    public class Name
    {
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("first")]
        public string? First { get; set; }

        [JsonProperty("last")]
        public string? Last { get; set; }
    }

    public class Picture
    {
        [JsonProperty("large")]
        public string? Large { get; set; }

        [JsonProperty("medium")]
        public string? Medium { get; set; }

        [JsonProperty("thumbnail")]
        public string? Thumbnail { get; set; }
    }

    public class Result
    {
        [JsonProperty("name")]
        public Name? Name { get; set; }

        [JsonProperty("id")]
        public Id? Id { get; set; }

        [JsonProperty("picture")]
        public Picture? Picture { get; set; }
    }

    public class Person
    {
        [JsonProperty("results")]
        public List<Result>? Results { get; set; }

        [JsonProperty("info")]
        public Info? Info { get; set; }
    }
}
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
