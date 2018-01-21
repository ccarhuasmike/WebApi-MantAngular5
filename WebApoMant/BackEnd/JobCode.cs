using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApoMant.BackEnd
{
    public class JobCode
    {
        [JsonProperty("_status_code")]
        public string StatusCode { get; set; }
        [JsonProperty("_status_message")]
        public string StatusMessage { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}