using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AppExamen.Models;
using AppExamen.Controllers;

using System.Threading.Tasks;

namespace AppExamen.Controllers
{
    public  static class DataBase
    {
        // Procedimientos

        // Retorna todas las filas de la tabla conctatos
        public static Task<List<Contactos>>ListaContactos()
        {
            return DB.dbconexion.Table<Contactos>().ToListAsync();
        }

        public static Task<int> AddContacto( Contactos contacto)
        {
            if (contacto.ID != 0)
            {
                // Ejecutamos el procedimiento de Actualizacion UPDATE
                return DB.dbconexion.UpdateAsync(contacto);
            }
            else
            {
                // Ejectuamos el procedimiento de INSERCCION de UNA PERSONA 
                return DB.dbconexion.InsertAsync(contacto);
            }
        }

        // Obtenemos por el ID un registro de un contacto de persona
        public static Task<Contactos> listaContacto(int pid)
        {
            return DB.dbconexion.Table<Contactos>()
                .Where(i => i.ID == pid)
                .FirstOrDefaultAsync();
        }

        // Eliminamos el registro de un contacto de persona
        public static Task<int> DelContacto(Contactos contacto)
        {
            return DB.dbconexion.DeleteAsync(contacto);
        }
    }
}
