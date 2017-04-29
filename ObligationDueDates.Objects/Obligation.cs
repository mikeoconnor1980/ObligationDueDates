using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ObligationDueDates.Objects
{
    public class Obligation : DBDocument
    {
        public Obligation() : base("obligation")
        {

        }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("priorid")]
        public string PriorId { get; set; }
        [JsonProperty("clients")]
        public Client[] Clients { get; set; }
        [JsonProperty("processes")]
        public List<string> Processes { get; set; }
        [JsonProperty("jurisdiction")]
        public Jurisdiction Jursidiction { get; set; }
        [JsonProperty("year")]
        public int Year { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
