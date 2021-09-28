using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo
{
    public class Sentencias
    {
        private Conexion cn = new Conexion();
        private OdbcCommand Comm;



        //Compras---------------------------------------------------------------------------------------
        public OdbcDataAdapter llenarTblappaperf(string tabla2)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT documento_compraenca FROM compras_encabezado ORDER BY documento_compraenca DESC LIMIT 1";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter todoslosproductos(string tabla2, string condicion)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT codigo_producto, nombre_producto, precio_producto FROM productos;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter carritodecompras(string tabla2, string condicion)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT compras_detalle.codigo_producto, productos.nombre_producto,  productos.precio_producto FROM compras_detalle  LEFT JOIN productos ON compras_detalle.codigo_producto = productos.codigo_producto  WHERE compras_detalle.documento_compraenca = " + condicion + " ORDER BY compras_detalle.documento_compraenca;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter saldototal(string tabla2, string condicion)// metodo  que obtinene el contenido de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT SUM(productos.precio_producto) FROM compras_detalle  LEFT JOIN productos ON compras_detalle.codigo_producto = productos.codigo_producto  WHERE compras_detalle.documento_compraenca = " + condicion + " ORDER BY compras_detalle.documento_compraenca;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }


        public OdbcDataAdapter llenarNombreappaperf(string tabla, string condicion)// metodo  que obtinene el contenido
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT nombre FROM " + tabla + " WHERE pkid = " + condicion + "  ;";
            OdbcDataAdapter dataName = new OdbcDataAdapter(sql, cn.conexion());
            return dataName;
        }

        public void agregarencabezado(string tabla3, string valor1, string valor2)
        {

            string sql = "INSERT INTO compras_encabezado Values('" + valor1 + "','1','21-9-28',500,'1');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void agregarproducto(string tabla3, string valor1, string valor2)
        {
            
            string sql = "INSERT INTO compras_detalle Values( '" + valor1 + "', '" + valor2 + "',1,1,'1');";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void eliminarappaperf(string tabla3, string valor1, string valor2)
        {
            string sql = "DELETE FROM compras_detalle WHERE documento_compraenca = '" + valor1 + "' AND  codigo_producto='" + valor2 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void perfileliminartodoappaperf(string tabla3, string valor1)
        {
            string sql = "DELETE FROM " + tabla3 + " WHERE fkidPerfil = '" + valor1 + "';";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void perfilagregartodoappaperf(string tabla3, string valor1, string valor2, string tabla2)
        {
            string sql = "INSERT INTO usuarioperfil (fkidAplicacion, fkidPerfil) SELECT NULL, pkid FROM perfil;";
            OdbcCommand consulta = new OdbcCommand(sql, cn.conexion());
            consulta.ExecuteNonQuery();

            string sql2 = "UPDATE aplicacionperfil SET " + tabla3 + " = '" + valor1 + "' WHERE fkidUsuario = '';";
            OdbcCommand consulta2 = new OdbcCommand(sql2, cn.conexion());
            consulta2.ExecuteNonQuery();
        }


    }
}