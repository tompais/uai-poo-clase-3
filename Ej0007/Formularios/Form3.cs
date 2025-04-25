using Ejercicios_Clase_3.Ej0007.Clases;

namespace Ejercicios_Clase_3.Ej0007.Formularios
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reloj R = new()
            {
                Horas = int.Parse(textBox1.Text)
            };
            textBox2.Text = (R.Horas * 3600).ToString();
        }
    }
}
