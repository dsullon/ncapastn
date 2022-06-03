using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Tienda.Data
{
    public class AppConexion
    {
        public static string CadenaConexion()
        {
            string baseDatos = ConfigurationManager.AppSettings["BaseDatos"];
            string server = ConfigurationManager.AppSettings["Servidor"];
            string usuario = ConfigurationManager.AppSettings["Usuario"];
            string password = ConfigurationManager.AppSettings["Password"];

            string cadenaAuxiliar = $"Server={server}; Database={baseDatos}; UID={usuario}; PWD={password}";
            string cadenaConexion = $"metadata=res://*/TiendaModel.csdl|res://*/TiendaModel.ssdl|res://*/TiendaModel.msl;" +
                $"provider=System.Data.SqlClient;provider connection string='{cadenaAuxiliar}'";
            return cadenaConexion;
        }
    }
}
