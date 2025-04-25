using Ejercicios_Clase_3.Ej0005.Clases;

namespace Ejercicios_Clase_3
{
    public partial class Form1 : Form
    {
        public Cliente1 Cliente;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente = new Cliente1();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cliente.Nombre = this.textBox1.Text;
            Cliente.Apellido = this.textBox2.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El Nombre es: {Cliente.Nombre}\n\rEl Apellido es: {Cliente.Apellido}");
        }
    }
}
