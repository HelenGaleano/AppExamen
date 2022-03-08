using AppExamen.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppExamen.Controllers
{
    public static class DataBaseBase
    {
        // Procedimientos

        // Retorna todas las filas de la tabla conctatos
        public static Task<List<Contactos>> Listacontactos()
        {
            return DB.dbconexion.Table<Contactos>().ToListAsync();
        }
    }
}