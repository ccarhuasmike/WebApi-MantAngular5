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
    [RoutePrefix("api/reportes")]
    public class ReportesController : ApiController
    {
        [Route("listarReporte"), HttpPost]
        public ClientResponse listarReporte(JObject objData)
        {
            ClientResponse response;
            try
            {
                BE_Reporte reporte = objData["reportes"].ToObject<BE_Reporte>();
                Pagination pagination = objData["paginacion"].ToObject<Pagination>();
                FilterReporte objeto = new FilterReporte
                {
                    reporte = reporte,
                    paginacion = pagination
                };
                response = new BLReporte().BL_listarReporte(objeto);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return response;
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

