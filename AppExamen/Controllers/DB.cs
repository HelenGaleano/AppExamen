using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AppExamen.Models;


namespace AppExamen.Controllers
{
    public static class DB
    {

        public static SQLiteAsyncConnection dbconexion;

        // Procedimiento Estatico
        public static void conexion(String dbpat)
        {
            dbconexion = new SQLiteAsyncConnection(dbpat);

            // Procedemos a crear las tablas de la base de datos
            dbconexion.CreateTableAsync<Contactos>();
            

        }

        
    }
}
