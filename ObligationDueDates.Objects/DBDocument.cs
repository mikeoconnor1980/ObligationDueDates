using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObligationDueDates.Objects
{
    public abstract class DBDocument
    {
        public DBDocument(string type)
        {
            this.Type = type;
        }

        [Key]
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
    }
}
