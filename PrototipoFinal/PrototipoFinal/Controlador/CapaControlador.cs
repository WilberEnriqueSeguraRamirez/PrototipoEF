using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Modelo;
using System.Collections;


namespace Controlador
{
   public class CapaControlador
    {
        // LLenar una tabla CAPA CONTROLADOR
        Sentencias sn = new Sentencias();

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public bool ingresotipoCuenta(string idTipoCuenta, string nombre)
        {
            return sn.ingresotipoCuenta(idTipoCuenta, nombre);

        }

        public bool ingresoCuenta(String idCuenta, String nombre, String idTipoCuenta, String cargo, String abono, String saldoAcumulado)
        {
            return sn.ingresoCuenta(idCuenta, nombre, idTipoCuenta, cargo, abono, saldoAcumulado);

        }


        public ArrayList cnInd(string id)
        {
            var arlist = sn.cnInd(id);

            return arlist;
        }


        public bool modificarCuenta(String idCuenta, String nombre, String idTipoCuenta, String cargo, String abono, String saldoAcumulado, string estado)
        {
            return sn.modificarCuenta(idCuenta, nombre, idTipoCuenta, cargo, abono, saldoAcumulado, estado);

        }

        public DataTable llenarTbl2(string tabla, string id)
        {
            OdbcDataAdapter dt = sn.llenarTbl2(tabla, id);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public bool bajaCuenta(String idCuenta)
        {
            return sn.bajaCuenta(idCuenta);

        }
    }
}
