using Ejercicios_Clase_3.Ej0012.Clases;

namespace Ejercicios_Clase_3.Ej0012.Formularios
{
    public partial class Form6 : Form
    {
        public Auto Auto;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Auto = new Auto();
            Auto.Arranque();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Auto.CargaDeCombustible((int)numericUpDown1.Value);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            decimal consumo = Auto.Consumo(numericUpDown2.Value, numericUpDown3.Value);
            MessageBox.Show($"El consumo es de {consumo} litros");
        }
    }
}
