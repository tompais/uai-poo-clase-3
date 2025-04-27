using Ejercicios_Clase_3.Ej0013.Clases;

namespace Ejercicios_Clase_3.Ej0013.Formularios
{
    public partial class Form7 : Form
    {
        public PasajePorValor PasajePorValor;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            PasajePorValor = new PasajePorValor();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = (int)numericUpDown1.Value;
            MessageBox.Show($"Valor de la variable i que será usada como argumentos antes de llamar a la función: {i}");
            PasajePorValor.RecibeNumero(i);
            MessageBox.Show($"Valor de la variable i después de llamar a la función: {i}");
        }
    }
}
