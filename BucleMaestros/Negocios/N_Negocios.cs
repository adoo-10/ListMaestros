using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocios
{
    public class N_Negocios
    {
        //Mandamos a llamar la lista que creamos
        D_Maestros datos = new D_Maestros();

        public List<E_Maestros> N_listaMaestros()
        {
            //vamos a invocar el metodo que contiene la lista usando el objeto creado
            List<E_Maestros> lista = datos.listaDeMaestros();

            return lista;
        }

        //Este metodo nos sirve para poder agregar un nuevo maestro utilizando la capa de datos
        public void N_AgregarMaestro(E_Maestros nuevoMaestro)
        {
            //Utilizamos el objeto "datos" para poder llamar el metodo
            //que se encarga de agregar un maestro a la lista
            datos.agregarMaestro(nuevoMaestro);
        }

        //Este metodo nos sirve para poder editar un maestro utilizando la capa de datos
        public void N_EditarMaestro(E_Maestros editMaestro)
        {
            //Utilizamos el objeto "datos" para poder llamar el metodo
            //que se encarga de editar un maestro a la lista
            datos.editarMaestro(editMaestro);
        }

        //Este metodo nos sirve para poder eliminar un maestro utilizando la capa de datos
        public void N_eliminarMaestro(E_Maestros eliminarMaestro)
        {
            //Utilizamos el objeto "datos" para poder llamar el metodo
            //que se encarga de eliminar un maestro a la lista
            datos.EliminarMaestro(eliminarMaestro);
        }


    }
}
