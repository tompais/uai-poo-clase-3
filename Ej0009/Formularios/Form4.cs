using Ejercicios_Clase_3.Ej0009.Clases;

namespace Ejercicios_Clase_3.Ej0009.Formularios
{
    public partial class Form4 : Form
    {
        public Persona Persona;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Persona = new Persona();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Persona.FechaDeNacimiento = dateTimePicker1.Value;
            MessageBox.Show($"Tu edad es: {Persona.Edad}");
        }
    }
}
