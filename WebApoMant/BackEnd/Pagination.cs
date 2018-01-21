using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApoMant.BackEnd
{
    
    public class Pagination
    {
//        [JsonProperty("CurrentPage")]
        public int CurrentPage { get; set; }
  //      [JsonProperty("ItemsPerPage")]
        public int ItemsPerPage { get; set; }
    //    [JsonProperty("TotalItems")]
        public int TotalItems { get; set; }
      //  [JsonProperty("TotalPages")]
        public int TotalPages { get; set; }
       
    }
}