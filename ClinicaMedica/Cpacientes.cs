using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaMedica
{
    public class Cpacientes
    {
        string nit;
        string nombre;
        string apellido;
        string direccion;
        string telefono;
        DateTime fecha;

        public string Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre= value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int edad { get { return edad_calcular(); } }
        public int edad_calcular()
        {
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - Fecha.Year;

            if (Fecha.Month > fechaActual.Month)

            {
                --edad;
            }

            return edad;
        }
    }
}