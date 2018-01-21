using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApoMant.BackEnd
{
    public class RootObject
    {
        [JsonProperty("results")]
        public Results Results { get; set; }
    }
}