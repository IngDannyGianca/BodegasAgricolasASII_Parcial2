using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();






        public DataTable carritodecompras(string tabla2, string condicion)
        {
            OdbcDataAdapter dt = sn.carritodecompras(tabla2, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable llenarTblappaperf(string tabla2)
        {
            OdbcDataAdapter dt = sn.llenarTblappaperf(tabla2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable saldototal(string tabla2, string condicion)
        {
            OdbcDataAdapter dt = sn.saldototal(tabla2, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable todoslosproductos(string tabla2, string condicion)
        {
            OdbcDataAdapter dt = sn.todoslosproductos(tabla2, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarNombreappaperf(string tabla, string condicion)
        {
            OdbcDataAdapter dt = sn.llenarNombreappaperf(tabla, condicion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void agregarproducto(string tabla3, string valor1, string valor2)
        {
            sn.agregarproducto(tabla3, valor1, valor2);
        }

        public void agregarencabezado(string tabla3, string valor1, string valor2)
        {
            sn.agregarencabezado(tabla3, valor1, valor2);
        }

        public void eliminarappaperf(string tabla3, string valor1, string valor2)
        {
            sn.eliminarappaperf(tabla3, valor1, valor2);
        }

        public void perfileliminartodoappaperf(string tabla3, string valor1)
        {
            sn.perfileliminartodoappaperf(tabla3, valor1);
        }

        public void perfilagregartodoappaperf(string tabla3, string valor1, string valor2, string tabla2)
        {
            sn.perfilagregartodoappaperf(tabla3, valor1, valor2, tabla2);
        }



    }
}