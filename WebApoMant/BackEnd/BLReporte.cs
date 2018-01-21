using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApoMant.BackEnd
{
    public class BLReporte
    {
        public ClientResponse BL_listarReporte(FilterReporte objeto)
        {
            return new DAReporte().listarReporte(objeto);
        }
    }
}