using Ejercicios_Clase_3.Ej0029.Clases;

namespace Ejercicios_Clase_3.Ej0029.Formularios
{
    public partial class Form11 : Form
    {
        public Persona2 P;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            P = new Persona2();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            P[""] = textBox1.Text;
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show(P[textBox2.Text]);
            }
            else
            {
                MessageBox.Show(P[textBox2.Text, textBox3.Text]);
            }
        }
    }
}
