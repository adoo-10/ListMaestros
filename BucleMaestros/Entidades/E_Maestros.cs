using System;

namespace Entidades
{
    public class E_Maestros
    {
        private int id;
        private string nombre;
        private string apellidos;
        private string materia;
        private int edad;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Materia { get => materia; set => materia = value; }
        public int Edad { get => edad; set => edad = value; }

        public E_Maestros(int id, string nombre, string apellidos, string materia, int edad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Materia = materia;
            this.Edad = edad;
        }

        public E_Maestros() { }

        public override string ToString()
        {
            return string.Format("Id: {0}, Nombre: {1} {2}, Materia: {3}, Edad: {4}", id, nombre, apellidos, materia, edad);
        }
    }
}
