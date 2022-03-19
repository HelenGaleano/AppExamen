using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppExamen.Models
{
    internal class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(70)]
        public String nombres { get; set; }

        [MaxLength(70)]
        public String apellidos { get; set; }
        [MaxLength(50)]
        public int edad { get; set; }

        [MaxLength(70)]
        public String pais { get; set; }

        [MaxLength(70)]
        public String nota { get; set; }
        public Double longitud { get; set; }
        public Double latitud { get; set; }

    }
}
