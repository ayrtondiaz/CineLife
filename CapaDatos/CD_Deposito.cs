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
    public class CD_Deposito
    {

        public List<ReporteDeposito> Listar()
        {

            List<ReporteDeposito> lista = new List<ReporteDeposito>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {

                    string query = "select s.IdSede ,d.IdDeposito,d.NombreArea, s.Nombre, s.Direccion,s.Telefono,l.Descripcion, p.DescripcionProv  from Sede s join Deposito d on s.IdSede = d.IdSede join Localidad l on s.IdLocalidad = l.IdLocalidad join Provincia p on l.IdProvincia = p.IdProvincia";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(
                                new ReporteDeposito()
                                {

                                    IdDeposito = Convert.ToInt32(dr["IdDeposito"]),
                                    IdSede = Convert.ToInt32(dr["IdSede"]),
                                    Area = dr["NombreArea"].ToString(),
                                    Nombre = dr["Nombre"].ToString(),
                                    Direccion = dr["Direccion"].ToString(),
                                    Telefono = dr["Telefono"].ToString(),
                                    Descripcion = dr["Descripcion"].ToString(),
                                    DescripcionProvincia = dr["DescripcionProv"].ToString(),


                                }) ;
                        }
                    }
                }

            }
            catch
            {
                lista = new List<ReporteDeposito>();

            }


            return lista;


        }

        //public class CD_Usuarios
        //{

        //    public List<Usuario> Listar()
        //    {

        //        List<Usuario> lista = new List<Usuario>();

        //        try
        //        {
        //            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
        //            {

        //                string query = "select s.IdSede ,d.IdDeposito, s.Nombre, s.Direccion,s.Telefono,l.Descripcion  from Sede s join Deposito d on s.IdSede = d.IdSede join Localidad l on s.IdLocalidad = l.IdLocalidad";

        //                SqlCommand cmd = new SqlCommand(query, oconexion);
        //                cmd.CommandType = CommandType.Text;

        //                oconexion.Open();

        //                using (SqlDataReader dr = cmd.ExecuteReader())
        //                {
        //                    while (dr.Read())
        //                    {

        //                        lista.Add(
        //                            new Usuario()
        //                            {
        //                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
        //                                Nombres = dr["Nombres"].ToString(),
        //                                Apellidos = dr["Apellidos"].ToString(),
        //                                DNI = Convert.ToInt32(dr["DNI"]),
        //                                Telefono = dr["Telefono"].ToString(),
        //                                Correo = dr["Correo"].ToString(),
        //                                Clave = dr["Clave"].ToString(),
        //                                Reestablecer = Convert.ToBoolean(dr["Reestablecer"]),
        //                                Activo = Convert.ToBoolean(dr["Activo"])
        //                            }

        //                            );
        //                    }
        //                }
        //            }

        //        }
        //        catch
        //        {
        //            lista = new List<Usuario>();

        //        }


        //        return lista;


        //    }

        //}
    }
}