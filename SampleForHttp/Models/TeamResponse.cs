using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SampleForHttp.Models
{
    public class TeamResponse
    {
        [JsonProperty("data")]
        public IEnumerable<Team> Teams { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}