using Entidades;
using Negocios;
using System;
using System.Collections.Generic;

namespace Vistas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creamos los objetos que nos ayudaran a llamar las diferentes capas
            //que vamos a utilizar
            N_Negocios negocios = new N_Negocios();
            List<E_Maestros> listado = negocios.N_listaMaestros();
            E_Maestros maestros = new E_Maestros();

            int opc = 1;

            //Se crea un bucle while que funcionara con la variable "opc"
            while(opc != 0)
            {
                //Se crea un menu con las opciones disponibles

                Console.WriteLine("**** MENÚ ****" +
                    "\n1 - Ver lista de maestros." +
                    "\n2 - Agregar un nuevo maestro." +
                    "\n3 - Editar un maestro de la lista." +
                    "\n4 - Eliminar un maestro de la lista." +
                    "\n0 - Salir del sistema.");
                opc = int.Parse(Console.ReadLine());

                maestros = new E_Maestros();

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("**** LISTA DE MAESTROS ****");

                        
                        //se utiliza el foreach para recorrer la lista y asi mostramos los maestros
                        
                        foreach (E_Maestros item in listado)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n\n");
                        break;

                    case 2: //en este caso agregaremos un nuevo maestro a la lista
                        Console.WriteLine("**** REGISTRANDO NUEVO MAESTRO ****");
                        //Se asigna un nuevo id
                        E_Maestros nuevoId = listado[listado.Count - 1];
                        maestros.Id = (nuevoId.Id + 1);
                        //Se piden los datos del nuevo maestro
                        Console.WriteLine("Nombre: ");
                        maestros.Nombre = Console.ReadLine();
                        Console.WriteLine("Apellido: ");
                        maestros.Apellidos = Console.ReadLine();
                        Console.WriteLine("Materia: ");
                        maestros.Materia = Console.ReadLine();
                        Console.WriteLine("Edad: ");
                        maestros.Edad = int.Parse(Console.ReadLine());

                        //Mediante la capa de datos se registra el nuevo maestro
                        negocios.N_AgregarMaestro(maestros);

                        Console.WriteLine( "Maestro registrado con éxito!");
                        Console.WriteLine("\n\n");

                        break;

                    case 3: //editaremos un maestro de la lista

                        Console.WriteLine("**** EDITANDO MAESTRO ****");
                        //Es necesario solicitar el id para saber que maestros se editara
                        Console.WriteLine("ID:");
                        //Se piden los datos del maestro
                        maestros.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombre: ");
                        maestros.Nombre = Console.ReadLine();
                        Console.WriteLine("Apellido: ");
                        maestros.Apellidos = Console.ReadLine();
                        Console.WriteLine("Materia: ");
                        maestros.Materia = Console.ReadLine();
                        Console.WriteLine("Edad: ");
                        maestros.Edad = int.Parse(Console.ReadLine());

                        //Aca se le pide a la capa de negocios que modifique el los datos del maestro
                        //segun los datos ingresados

                        negocios.N_EditarMaestro(maestros);

                        Console.WriteLine("Maestro editado con exito! ");

                        break;

                    case 4: //Eliminaremos un maestro de la lista
                        Console.WriteLine("**** ELIMINANDO MAESTRO ****");
                        //Para poder eliminar un maestro solo se necesita su id 
                        Console.WriteLine("ID: ");
                        maestros.Id = int.Parse(Console.ReadLine());

                        //Se le pide a la capa de negocios que realice el proceso de eliminacion
                        negocios.N_eliminarMaestro(maestros);
                        Console.WriteLine("Maestro eliminado con éxito!");
                        break;


                        
                    case 0: //por ultimo agregamos un caso 0 que servira para salir del bucle

                        Console.WriteLine("Hasta la proxima!");
                        break;
                    default:

                        break;

                }
            }
        }
    }
}
