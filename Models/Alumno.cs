using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Becas.Models
{
    public class Alumno
    {
    [PrimaryKey,AutoIncrement]
      public int Id {get; set;}
      [MaxLength(40)]
      public string Nombres {get; set;}

      public string A_Paterno {get; set;} 

      public string A_Materno {get; set;}

      public string Matricula {get; set;}

      public string Carrera {get; set;} 

      public string Correo {get; set;}

      public string Telefono {get; set;} 

      public string Lugar_Origen {get; set;}
      
      public string Estancia {get; set;}

        private class PrimaryKeyAttribute : Attribute
        {
        }

        private class AutoIncrementAttribute : Attribute
        {
        }

        private class MaxLengthAttribute : Attribute
        {
            public MaxLengthAttribute(int v)
            {
            }
        }
    }
}