using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppExamen.Models
{
    public class Contactos
    {
       
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(100)]
        public String nombre{ get; set; }

        [MaxLength(70)]
        public String apellidos { get; set; }

        public string telefono { get; set; }

        public int edad { get; set; }

        [MaxLength(70)]
        public String pais { get; set; }

        [MaxLength(70)]
        public String nota { get; set; }
        public Double longitud { get; set; }
        public Double latitud { get; set; }

    }
}
