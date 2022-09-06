using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace CapaDatos
{
    public class CD_Articulos
    {
        //public List<ArtXDeposito> Listar()
        //{

        //    List<ArtXDeposito> lista = new List<ArtXDeposito>();

        //    try
        //    {
        //        using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
        //        {

                    

        //            string sb = "select * from ArtXDeposito";


        //            SqlCommand cmd = new SqlCommand(sb.ToString(), oconexion);
        //            cmd.CommandType = CommandType.Text;

        //            oconexion.Open();

        //            using (SqlDataReader dr = cmd.ExecuteReader())
        //            {
        //                while (dr.Read())
        //                {
        //                    lista.Add(new ArtXDeposito()
        //                    {
        //                        IdProducto = Convert.ToInt32(dr["IdProducto"]),
        //                        IdDeposito= Convert.ToInt32(dr["IdDeposito"]) ,
        //                        Stock = Convert.ToInt32(dr["Stock"]),
        //                        StockMaximo = Convert.ToInt32(dr["StockMaximo"]),
        //                        StockMinimo = Convert.ToInt32(dr["StockMinimo"]),
        //                        PuntoDePedido = Convert.ToInt32(dr["PuntoDePedido"]),
        //                        Proveedor = dr["Proveedor"].ToString() ,
        //                        Activo = Convert.ToBoolean(dr["Activo"])
        //                    });
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        lista = new List<ArtXDeposito>();

        //    }
        //    return lista;
        //}

        public List<ArtXDeposito> Listar()
        {

            List<ArtXDeposito> lista = new List<ArtXDeposito>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {

                    string query = "select * from ArtXDeposito";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(
                                new ArtXDeposito()
                                {

                                    IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                    IdDeposito = Convert.ToInt32(dr["IdDeposito"]),
                                    Stock = Convert.ToInt32(dr["Stock"]),
                                    StockMaximo = Convert.ToInt32(dr["StockMaximo"]),
                                    StockMinimo = Convert.ToInt32(dr["StockMinimo"]),
                                    PuntoDePedido = Convert.ToInt32(dr["PuntoDePedido"]),
                                    Proveedor = dr["Proveedor"].ToString(),
                                    Activo = Convert.ToBoolean(dr["Activo"])

                                });
                        }
                    }
                }

            }
            catch
            {
                lista = new List<ArtXDeposito>();

            }


            return lista;


        }

    }
}
