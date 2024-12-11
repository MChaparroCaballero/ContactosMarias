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


        public void AgregarContacto(Contact nuevo)
        {
            agenda.Add(nuevo);
            MessageBox.Show("Contacto agregado con exito");
        }

        public string BuscarContacto(string tel)
        {

            string datos = null;
            foreach (var item in agenda)
            {
                if (item.Phone.Equals(tel))
                {
                    datos = "Nombre " + item.Name + " Telefono " + item.Phone;
                }

            }

                if (datos == null)
                {
                datos = "Contacto no encontrado";
                }

                return datos;
            }
        

        public string [] verContactos()
        {

            string [] datos = new string[agenda.Count];
            for(int i=0; i<agenda.Count; i++) {
            
                datos [i] = "Nombre " + agenda[i].Name + " telefono "+ agenda[i].Phone;
                
            }
            return datos;
        }
        public void EliminarContacto(Contact viejo)
        {
            bool encontrada = false;
            foreach (var item in agenda)
            {
                if (item.Phone.Equals(viejo.Phone) && item.Name.Equals(viejo.Name))
                {
                    encontrada = true;
                    agenda.Remove(item);
                    MessageBox.Show("Contacto eliminado con exito");
                }

            }

            if (encontrada == false)
            {
                MessageBox.Show("Error el contacto no se ha podido eliminar");
            }
        }

        public void ActualizarContacto(Contact viejo, Contact nuevo)
        {
            bool encontrada = false;
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

            if(encontrada == false)
            {
                MessageBox.Show("No se ha podido actualizar el contacto");
            }
        }

    }
}
