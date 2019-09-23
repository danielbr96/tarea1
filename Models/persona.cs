using System;

namespace tarea1.Models
{
    public class Persona
    {
        public string Saludo { get; set; }
        public string Nombre { get; set; }

        public Persona()
        {
            Saludo = "Hola Bienvenido";
            Nombre = string.Empty;

        }
    }
}