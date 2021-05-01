using System;
using System.Collections.Generic;
using System.Text;

namespace UtilidadesDashboard
{
    public class Empleado 
    {
        int numero_comercial;
        String nombre;
        String apellido;
        String localidad;
        int edad;

        public Empleado()
        {}

        public Empleado(int numero_comercial, string nombre, string apellido, string localidad, int edad)
        {
            this.numero_comercial = numero_comercial;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Localidad = localidad;
            this.Edad = edad;
        }
            
        public int Numero_comercial { get => numero_comercial; set => numero_comercial = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
