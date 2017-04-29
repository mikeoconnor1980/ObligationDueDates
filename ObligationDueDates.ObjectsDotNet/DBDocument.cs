using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObligationDueDates.ObjectsDotNet
{
    public abstract class DBDocument
    {
        public DBDocument(string type)
        {
            this.Type = type;
        }

        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Object type
        /// </summary>
        public string Type { get; private set; }
    }
}
