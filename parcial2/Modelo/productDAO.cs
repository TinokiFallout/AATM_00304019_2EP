using System.Collections.Generic;
using System.Data;
using SegundoParcial;

namespace Parcial2
{
    public static class productDAO
    {
        public static List<string> getProduct()
        {
            string sql = "SELECT NAME FROM PRODUCT";
            string u = "";
            DataTable dt = Conexion.realizarConsulta(sql);
            List<string> lista = new List<string>();
            foreach (DataRow fila in dt.Rows)
            {
                u = fila[0].ToString();
                lista.Add(u);
            }
            return lista;
        }
    }
}