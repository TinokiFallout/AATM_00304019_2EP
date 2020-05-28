using System.Collections.Generic;
using System.Data;
using Parcial2;

namespace SegundoParcial
{
    public static class adress
    {
        public static List<string> getadress()
        {
            string sql = "SELECT ADRESS FROM ADDRESS";
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