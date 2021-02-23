

using System;


    public class Estudiante
    {
        public String nombre { get; set; }
        public int matricula { get; set; }
        public String materia { get; set; }
        public float calificacion { get; set; }
        public String estado { get; set; }



        public Estudiante()
        {
            this.nombre = "";
            this.matricula = 0;
            this.materia = "";
            this.calificacion = 0;
            this.estado = "";
        }

        public Estudiante(String nombre, int matricula, String materia, float calificacion, String estado)
        {
            this.nombre = nombre;
            this.matricula = matricula;
            this.materia = materia;
            this.calificacion = calificacion;
            this.estado = estado;
        }

        public void mostrar()
        {

            Console.WriteLine("-----------------------------------");
            Console.Write("\n >>Nombre: ");
            nombre = Convert.ToString(Console.ReadLine());
            Console.Write("\n >>Matricula: ");
            matricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n >>Materia: ");
            materia = Convert.ToString(Console.ReadLine());
            Console.Write("\n >>Calificacion: ");
            calificacion = Convert.ToSingle(Console.ReadLine());

            if (calificacion >= 60)
                estado = "Aprobado";
            else
                estado = "Reprobado";


        }


    }



