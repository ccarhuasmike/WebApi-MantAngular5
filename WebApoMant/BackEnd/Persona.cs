using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApoMant.BackEnd
{
    public class Persona
    {
        [JsonProperty("nombre")]
        public string nombre { get; set; }
    }
}