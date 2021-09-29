using Entidades;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class D_Maestros
    {
        List<E_Maestros> maestros = new List<E_Maestros>();

        //Este metodo nos va a retornar una lista
        public List<E_Maestros> listaDeMaestros()
        {

            //Si la lista ya contiene datos, entonces los va a retornar
            if (maestros.Count != 0)
            {
                return maestros;
            }

            //Si la lista no contiene datos entonces asignamos nuevos
            //Estos mismos seran retornados
            else
            {
                maestros.Add(new E_Maestros(1, "Jose", "Lopez", "Matematica", 29));
                maestros.Add(new E_Maestros(2, "Antonia", "Bonilla", "Ciencia", 39));
                maestros.Add(new E_Maestros(3, "Maricela", "Argueta", "Sociales", 35));
                maestros.Add(new E_Maestros(4, "Valentina", "Guzman", "Fisica", 30));

                return maestros;
            } 

        }

        //Agregamos un metodo para agregar maestro
        public void agregarMaestro(E_Maestros nuevoMaestro)
        {
            //Mediante el metodo Add se agrega el nuevo maestro a la lista
            maestros.Add(nuevoMaestro);
        }


        //Agregamos un metodo para poder editar la informacion de un maestro de la lista
        public void editarMaestro(E_Maestros editarMaestro)
        { //Utilizamos este "for" para poder recorrer toda la lista
            for (int i = 0; i < maestros.Count; i++)
            {
               //Se comparan todos los id con el que ingresamos
                if (maestros[i].Id == editarMaestro.Id)
                {

                    //Al encontrarlo remplaza la antigua informacion con la nueva que se ha ingresado
                    maestros[i] = editarMaestro;
                }
            }
        }

        //Agregamos un metodo para poder eliminar un maestro de la lista
        public void EliminarMaestro(E_Maestros eliminarMaestro)
        {
            maestros.RemoveAll(r => r.Id == eliminarMaestro.Id);
            //Se utiliza el metodo RemoveAll para buscar en la lista algun dato
            //que cumpla la condicion ingresada y lo elimina
        }
    }
}
     