

using System;



    public class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Luis", 1282990, "POO", 100, "Aprobado");
            Estudiante e2 = new Estudiante("Ana", 1125890, "Calculo", 77, "Aprobado");
            Estudiante e3 = new Estudiante("Jose", 1081311, "Mercadotecnia", 49, "Reprobado");
            Estudiante e4 = new Estudiante("Perla", 1255478, "Estatica", 55, "Reprobado");
            Estudiante e5 = new Estudiante("Miguel", 1222100, "Electronica", 85, "Aprobado");

            Estudiante e6 = new Estudiante();
            Estudiante e7 = new Estudiante();
            Estudiante e8 = new Estudiante();
            Estudiante e9 = new Estudiante();
            Estudiante e10 = new Estudiante();



            

            e6.mostrar();
            e7.mostrar();
            e8.mostrar();
            e9.mostrar();
            e10.mostrar();




            Console.WriteLine("-----------------------------------");



           
            Console.WriteLine("\n Nombre: {0} \n Matricula: {1} \n Materia: {2} \n Calificacion: {3} \n Estado: {4}",
            e1.nombre, e1.matricula, e1.materia, e1.calificacion, e1.estado);
            Console.WriteLine("-----------------------------------");

           
            Console.WriteLine("\n Nombre: {0} \n Matricula: {1} \n Materia: {2} \n Calificacion: {3} \n Estado: {4}",
            e2.nombre, e2.matricula, e2.materia, e2.calificacion, e2.estado);
            Console.WriteLine("-----------------------------------");

          
            Console.WriteLine("\n Nombre: {0} \n Matricula: {1} \n Materia: {2} \n Calificacion: {3} \n Estado: {4}",
            e3.nombre, e3.matricula, e3.materia, e3.calificacion, e3.estado);
            Console.WriteLine("-----------------------------------");

          
            Console.WriteLine("\n Nombre: {0} \n Matricula: {1} \n Materia: {2} \n Calificacion: {3} \n Estado: {4}",
            e4.nombre, e4.matricula, e4.materia, e4.calificacion, e4.estado);
            Console.WriteLine("-----------------------------------");

         
            Console.WriteLine("\n Nombre: {0} \n Matricula: {1} \n Materia: {2} \n Calificacion: {3} \n Estado: {4}",
            e5.nombre, e5.matricula, e5.materia, e5.calificacion, e5.estado);
            Console.WriteLine("-----------------------------------");


            Console.WriteLine("\n Nombre: {0} \n Matricula: {1} \n Materia: {2} \n Calificacion: {3} \n Estado: {4}",
            e6.nombre, e6.matricula, e6.materia, e6.calificacion, e6.estado);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\n Nombre: {0} \n Matricula: {1} \n Materia: {2} \n Calificacion: {3} \n Estado: {4}",
            e7.nombre, e7.matricula, e7.materia, e7.calificacion, e7.estado);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\n Nombre: {0} \n Matricula: {1} \n Materia: {2} \n Calificacion: {3} \n Estado: {4}",
            e8.nombre, e8.matricula, e8.materia, e8.calificacion, e8.estado);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\n Nombre: {0} \n Matricula: {1} \n Materia: {2} \n Calificacion: {3} \n Estado: {4}",
            e9.nombre, e9.matricula, e9.materia, e9.calificacion, e9.estado);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\n Nombre: {0} \n Matricula: {1} \n Materia: {2} \n Calificacion: {3} \n Estado: {4}",
            e10.nombre, e10.matricula, e10.materia, e10.calificacion, e10.estado);
            Console.WriteLine("-----------------------------------");

            



        }
    }

