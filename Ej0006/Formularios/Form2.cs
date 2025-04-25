using Ejercicios_Clase_3.Ej0006.Clases;

namespace Ejercicios_Clase_3.Ej0006.Formularios
{
    public partial class Form2 : Form
    {
        public Cliente2 Cliente;

        public Form2()
        {
            InitializeComponent();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            Cliente = new Cliente2();
        }
    }
}
