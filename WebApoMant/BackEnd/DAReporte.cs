using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApoMant.BackEnd
{
    public class DAReporte
    {
        #region Variables
        private static List<BE_Reporte> lstReporte;
        private static BE_Reporte entidad;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader reader;
        private static ClientResponse clientResponse;
        #endregion

        #region Constructor
        public DAReporte()
        {
            lstReporte = new List<BE_Reporte>();
            entidad = null;
            conexion = null;
            comando = null;
            reader = null;
            clientResponse = new ClientResponse();
            clientResponse.Status = "OK";
        }
        #endregion

        public ClientResponse listarReporte(FilterReporte objeto)
        {
            int recordCount = 0;
            try
            {
                using (conexion = new SqlConnection(Conexion.ConexionBD().ToString()))
                {
                    using (comando = new SqlCommand("sp_listar_reporte", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.Add("@serie", SqlDbType.VarChar, 20).Value = objeto.reporte.Serie;
                        comando.Parameters.Add("@numerodoc", SqlDbType.VarChar, 20).Value = objeto.reporte.Numerodoc;
                        comando.Parameters.Add("@fechaproceso_ini", SqlDbType.VarChar, 8).Value = objeto.reporte.Fecha_Ini;
                        comando.Parameters.Add("@fechaproceso_fin", SqlDbType.VarChar, 8).Value = objeto.reporte.Fecha_Fin;
                        comando.Parameters.Add("@vi_pagina", SqlDbType.Int).Value = objeto.paginacion.CurrentPage;
                        comando.Parameters.Add("@vi_registrosporpagina", SqlDbType.Int).Value = objeto.paginacion.ItemsPerPage;
                        comando.Parameters.Add("@vi_RecordCount", SqlDbType.Int).Direction = ParameterDirection.Output;
                        conexion.Open();
                        using (reader = comando.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                entidad = new BE_Reporte();

                                entidad.Id = (reader["id"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["id"].ToString());
                                entidad.Serie = (reader["serie"] == DBNull.Value) ? String.Empty : (reader["serie"]).ToString();
                                entidad.Numerodoc = (reader["numerodoc"] == DBNull.Value) ? String.Empty : (reader["numerodoc"]).ToString();
                                entidad.Nombre = (reader["nombre"] == DBNull.Value) ? String.Empty : (reader["nombre"]).ToString();
                                entidad.Descripcion = (reader["descripcion"] == DBNull.Value) ? String.Empty : (reader["descripcion"]).ToString();
                                entidad.Tipodocumento = (reader["tipodocumento"] == DBNull.Value) ? String.Empty : (reader["tipodocumento"]).ToString();
                                entidad.Precio_compra = (reader["precio_compra"] == DBNull.Value) ? 0 : Convert.ToDouble(reader["precio_compra"].ToString());
                                entidad.Fechaproceso = (reader["fechaproceso"] == DBNull.Value) ? String.Empty : (reader["fechaproceso"]).ToString();
                                entidad.Fecharegistro = (reader["fecharegistro"] == DBNull.Value) ? String.Empty : (reader["fecharegistro"]).ToString();
                                lstReporte.Add(entidad);
                            }
                        }
                        recordCount = Convert.ToInt32(comando.Parameters["@vi_RecordCount"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                clientResponse.Mensaje = ex.Message;
                clientResponse.Status = "ERROR";
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
                reader.Dispose();
            }
            Pagination responsepaginacion = new Pagination()
            {
                TotalItems = recordCount,
                TotalPages = (int)Math.Ceiling((double)recordCount / objeto.paginacion.ItemsPerPage)
                //TotalPages = (int)Math.Ceiling((double)recordCount / objeto.ItemsPerPage)
            };

            clientResponse.DataJson = JsonConvert.SerializeObject(lstReporte).ToString();
            clientResponse.paginacion = JsonConvert.SerializeObject(responsepaginacion).ToString();
            return clientResponse;
        }

    }
}