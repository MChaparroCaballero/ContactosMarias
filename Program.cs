namespace Maria_contactos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new bienvenida());


        }

        public static bool checkPhone(string phone)
        {
            if (phone == null || phone.Equals(""))
            {
                Console.WriteLine("ERROR: el n�mero de tel�fono no puede estar vacio.");
                return false;
            }
            if (phone.Length != 11)
            {
                Console.WriteLine("ERROR: el n�mero de tel�fono debe tener 11 d�gitos.");
                return false;
            }
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] < '0' || phone[i] > '9')
                {
                    Console.WriteLine("ERROR: el n�mero de tel�fono debe tener solo n�meros.");
                    return false;
                }
            }
            return true;
        }
        public static void searchContact(List<Contact> agenda)
        {
            string phone = "";
            do
            {
                Console.WriteLine("Por favor, introduce un numero de telefono valido");
                try
                {
                    phone = Console.ReadLine();
                }
                catch (IOException)
                {
                    Console.WriteLine("ERROR: se esperaba un numero");
                }
            } while (!checkPhone(phone));

            Contact contact = agenda.Find(c => c.Phone == phone);
            if (contact == null)
            {
                Console.WriteLine("No se encontr� ning�n contacto con el n�mero de tel�fono " + phone);
            }
            else
            {
                Console.WriteLine("Se encontr� el siguiente contacto:");
                printContact(contact);
            }
        }

        public static void printContact(Contact contact)
        {
            Console.WriteLine("*************");
            Console.WriteLine("Nombre: " + contact.Name);
            Console.WriteLine("Telefono: " + contact.Phone);
            Console.WriteLine("*************");
        }
    }
}