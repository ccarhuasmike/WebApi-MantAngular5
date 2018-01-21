using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;
using WebApoMant.BackEnd;

namespace WebApoMant.Controllers
{

    //[EnableCors(origins: "http://localhost:32883", headers: "*", methods: "*", exposedHeaders: "X-My-Header")]
    [RoutePrefix("api/reportes")]
    [EnableCors("*", "*", "*")]
    public class ReportesController : ApiController
    {
        [Route("listarReporte")]
        [HttpPost]
        public ClientResponse listarReporte(JObject objData)
        {           
            try
            {                
                //List<ItemDetails> lstItemDetails = new List<ItemDetails>();                
                //dynamic jsonData = objData;                
                //JObject reportesJson = jsonData.reportes;
                ////JArray itemDetailsJson = jsonData.itemDetails;
                //BE_Reporte reporte = reportesJson.ToObject<BE_Reporte>();
                BE_Reporte reportes = objData["reportes"].ToObject<BE_Reporte>();
                Pagination paginacion = objData["paginacion"].ToObject<Pagination>();
                FilterReporte objeto = new FilterReporte() { reporte = reportes, paginacion = paginacion };
                return new BLReporte().BL_listarReporte(objeto);
                //foreach (var item in itemDetailsJson)
                //{
                //    lstItemDetails.Add(item.ToObject<ItemDetails>());
                //}               
            }
            catch (Exception e)
            {

                throw e;
            }


            
        
         
        }
    }
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public ICollection<ItemDetails> Details { get; set; }
    }

    public class ItemDetails
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}

