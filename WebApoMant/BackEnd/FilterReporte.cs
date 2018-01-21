using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApoMant.BackEnd
{
   
    public class FilterReporte
    {
        //public int CurrentPage { get; set; }
        //public int ItemsPerPage { get; set; }
        //public int TotalItems { get; set; }
        //public int TotalPages { get; set; }
        
        
        public Pagination paginacion { get; set; }
        
        public BE_Reporte reporte { get; set; }
        public FilterReporte()
        {
            paginacion = new Pagination();
            reporte = new BE_Reporte();
          
        }
    }
}