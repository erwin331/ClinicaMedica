using System;

namespace ClinicaMedica
{
    public class Medicamento
    {
        string codigo;
        string quimico;
        string laboratorio;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Quimico { get => quimico; set => quimico = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
    }
}