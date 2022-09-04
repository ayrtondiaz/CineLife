using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Deposito
    {
        private CD_Deposito objCapaDato = new CD_Deposito();
        //public Deposito VerDeposito()
        //{
        //    return objCapaDato.VerDeposito();
        //}
        public List<ReporteDeposito> Listar()
        {
            return objCapaDato.Listar();
        }


    }
}
