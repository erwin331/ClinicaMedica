using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaMedica
{
    public class Cinicio
    {
        string nombre;
        string password;
        int nivel;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }
        public int Nivel { get => nivel; set => nivel = value; }
    }
}