using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaMedica
{
    public class Ccitas
    {
        string nit;
        DateTime fecha;
        string horainicio;
        string horafinal;

        public string Nit { get => nit; set => nit = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Horainicio { get => horainicio; set => horainicio = value; }
        public string Horafinal { get => horafinal; set => horafinal = value; }
    }
}