using Ejercicios_Clase_3.Ej0014.Clases;

namespace Ejercicios_Clase_3.Ej0014.Formularios
{
    public partial class Form8 : Form
    {
        public PasajePorReferencia PasajePorReferencia;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            PasajePorReferencia = new PasajePorReferencia();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = (int)numericUpDown1.Value;
            MessageBox.Show($"Valor de la variable i que será usada como argumentos antes de llamar a la función: {i}");
            PasajePorReferencia.RecibeNumero(ref i);
            MessageBox.Show($"Valor de la variable i después de llamar a la función: {i}");
        }
    }
}
