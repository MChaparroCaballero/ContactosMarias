using System.Collections;

namespace Maria_contactos
{
    public partial class bienvenida : Form
    {
        static Contact[] agenda = new Contact[100];
        public bienvenida()
        {


            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarPantalla buscarPantalla = new BuscarPantalla();
            this.Hide();
            buscarPantalla.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarContactoPantalla kk = new EliminarContactoPantalla();
            kk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActualizarContactoPantalla hh = new ActualizarContactoPantalla();
            hh.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            CrearContacto cn = new CrearContacto();
            this.Hide();
            cn.Show();
        }

        private void VeerContactos_button(object sender, EventArgs e)
        {
            this.Hide();
            VerContactosPantalla jj = new VerContactosPantalla();
            jj.Show();

        }
    }
}
