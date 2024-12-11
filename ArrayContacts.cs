using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Maria_contactos
{
    internal class ArrayContacts
    {
        public static List<Contact> agenda = new List<Contact>();

        /*-------------------------------------------------------------------------------------------------------------------------------*/
        /*****metodo para agregar los contactos******/
        public static void AgregarContacto(Contact nuevo)
        {
            /****añadimos al arraylist un objeto nuevo de contacto y una ventanita de exito****/
            agenda.Add(nuevo);
            MessageBox.Show("Contacto agregado con exito");
        }
        /*-------------------------------------------------------------------------------------------------------------------------------*/
        /*****metodo para buscar un contacto especifico******/
        public static string BuscarContacto(string tel, string name)
        {
            /****un string vacio donde almacenamos los datos encontrados*****/
            string datos = null;

            /***recorremos el array y solo si el nombre y el telefono coincide lo mandamos devuelta si no encuentra lo que devuelve es un mensaje de error****/
            foreach (var item in agenda)
            {
                if (item.Phone.Equals(tel) && item.Name.Equals(name))
                {
                    datos = "Nombre: " + item.Name + " ---- "+ "Telefono: " + item.Phone;
                }

            }

                if (datos == null)
                {
                datos = "Contacto no encontrado";
                }

                return datos;
            }
        /*-------------------------------------------------------------------------------------------------------------------------------*/
        /***metodo para ver todos los contactos****/
        public static string [] verContactos()
        {
            /****vamos a recorrer toda la agenda y almacenar sus datos en un array de string que devolvemos cuando llame****/
            string [] datos = new string[agenda.Count];
            for(int i=0; i<agenda.Count; i++) {
            
                datos [i] = "Nombre: " + agenda[i].Name +" ---- " +"Telefono: "+ agenda[i].Phone;
                
            }
            return datos;
        }
        /*-------------------------------------------------------------------------------------------------------------------------------*/
        /****metodo para eliminar un contacto*****/
        public static void EliminarContacto(Contact viejo)
        {

            /****una booleana para saber si lo ha conseguido encontrar o no al contacto*****/
            bool encontrada = false;

            /*****recorremos y si ambos datos coinciden nos los quita de arraylist y hace una ventana de mensaje de exito, cuando lo elimine rompe con el recorrido de el foreach ya que si no da error*****/
            foreach (var item in agenda)
            {
                if (item.Phone.Equals(viejo.Phone) && item.Name.Equals(viejo.Name))
                {
                    encontrada = true;
                    agenda.Remove(item);
                    MessageBox.Show("Contacto eliminado con exito");
                    return;

                }

            }

            /***si no lo encuentra nos saca otra ventana de mensaje de error informandonos de que no lo a encntrado***/
            if (encontrada == false)
            {
                MessageBox.Show("Error el contacto no se ha podido eliminar");
            }
        }
        /*-------------------------------------------------------------------------------------------------------------------------------*/
        /****metodo para actualizar un contacto****/
        public static void ActualizarContacto(Contact viejo, Contact nuevo)
        {

            /***booleana para saber si lo ha encontrado o no el contacto a modificar****/
            bool encontrada = false;

            /***recorre el array y si todos los datos cuadran con lo que habia, nos cambia el contacto a los datos nuevos y nos salta una ventanita de exito***/
            foreach (var item in agenda)
            {
                if (item.Phone.Equals(viejo.Phone) && item.Name.Equals(viejo.Name))
                {
                    encontrada = true;
                    item.Phone = nuevo.Phone;
                    item.Name = nuevo.Name;
                    MessageBox.Show("Contacto actualizado con exito");
                }

            }

            /***si no lo encuentra nos salta una ventana de mensaje de error informandonos de ello****/
            if(encontrada == false)
            {
                MessageBox.Show("No se ha podido actualizar el contacto");
            }
        }
        /*-------------------------------------------------------------------------------------------------------------------------------*/

    }
}
