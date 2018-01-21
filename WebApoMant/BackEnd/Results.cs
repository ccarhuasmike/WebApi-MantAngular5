using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApoMant.BackEnd
{
    public class Results
    {
        [JsonProperty("jobcodes")]
        public Dictionary<string, JobCode> JobCodes { get; set; }
    }
}