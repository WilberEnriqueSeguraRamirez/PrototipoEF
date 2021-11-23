using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Collections;
using System.Data;
namespace Modelo
{
   public class Sentencias
    {
        //int dato;
        // obtener datos de una tabla CAPA MODELO
        Conexion con = new Conexion();
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            string sql = "SELECT * FROM " + tabla + " where estado = 'A';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }


        public bool ingresotipoCuenta(string idTipoCuenta, string nombre)  //Metodo para Ingresar el tipo de Cuenta
        {
            int i = 0;
            try
            {
                string cadena = "insert into tipoCuenta values (" + idTipoCuenta + ",'" + nombre + "','A');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ingresoCuenta(String idCuenta, String nombre, String idTipoCuenta, String cargo, String abono, String saldoAcumulado) //Metodo para el ingreso de cuenta
        {
            int i = 0;
            try
            {
                string cadena = "insert into cuenta values (" + idCuenta + ",'" + nombre + "','" + idTipoCuenta + "','" + cargo + "','" + abono + "','" + saldoAcumulado + "','A'); ";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public ArrayList cnInd(string id)//Consulta Individual
        {
            var arlist = new ArrayList();
            string cadena = "select * from cuenta where idCuenta = " + id + ";";
            OdbcCommand busI = new OdbcCommand(cadena, con.conexion());
            OdbcDataReader lector = busI.ExecuteReader();
            while (lector.Read())
            {
                for (int i = 0; i < 7; i++)
                {
                    arlist.Add(lector[i].ToString());
                    
                }
            }
            return arlist;
        }

        //Metodo para modificar cuenta
        public bool modificarCuenta(String idCuenta, String nombre, String idTipoCuenta, String cargo, String abono, String saldoAcumulado, string estado)
        {
            int i = 0;
            try
            {
                string cadena = "update cuenta set nombre = '"+nombre+"', idTipoCuenta = "+idTipoCuenta+", cargo = "+cargo+", abono = "+abono+", saldoAcumulado = "+saldoAcumulado+", estado = '"+estado+"' where idCuenta = "+idCuenta+"; ";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public OdbcDataAdapter llenarTbl2(string tabla, string id)// metodo  que obtinene el contenio de una tabla
        {
            string sql = "SELECT * FROM " + tabla + " where idCuenta = "+id+";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }



        public bool bajaCuenta(String idCuenta)
        {
            int i = 0;
            try
            {
                string cadena = "update cuenta set estado = I where idCuenta = "+idCuenta+"; ";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
