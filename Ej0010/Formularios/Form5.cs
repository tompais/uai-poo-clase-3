using Ejercicios_Clase_3.Ej0010.Clases;
using System.Text;

namespace Ejercicios_Clase_3.Ej0010.Formularios
{
    public partial class Form5 : Form
    {
        public AlmacenaString AlmacenaString;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            AlmacenaString = new AlmacenaString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AlmacenaString[decimal.ToInt32(numericUpDown1.Value)-1] = textBox1.Text;
            MessageBox.Show("Texto agregado!");
            textBox1.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.AppendLine($"Posición {i+1}: {AlmacenaString[i]}");
            }
            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
