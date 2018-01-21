using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApoMant.BackEnd
{
    [Serializable]
    public class BE_Reporte
    {
        private int _id = 0;
        public string _serie ="";
        public string _numerodoc = "";
        public string _nombre = "";
        public string _descripcion = "";
        public string _tipodocumento = "";
        public double _precio_compra =0.0;
        public string _fechaproceso = "";

        public string _fecharegistro = "";
        public string _fecha_ini= "";
        public string _fecha_fin = "";

        public string Fecha_Ini { get { return _fecha_ini; } set { _fecha_ini = value; } }
        public string Fecha_Fin { get { return _fecha_fin; } set { _fecha_fin = value; } }

        public int Id { get { return _id; } set { _id = value; } }
        public string Serie { get { return _serie; } set { _serie = value; } }
        public string Numerodoc { get { return _numerodoc; } set { _numerodoc = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public string Tipodocumento { get { return _tipodocumento; } set { _tipodocumento = value; } }
        public double Precio_compra { get { return _precio_compra; } set { _precio_compra = value; } }
        public string Fechaproceso { get { return _fechaproceso; } set { _fechaproceso = value; } }
        public string Fecharegistro { get { return _fecharegistro; } set { _fecharegistro = value; } }
       

    }
}