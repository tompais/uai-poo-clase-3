namespace Ejercicios_Clase_3.Ej0020.Formularios
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Contenedor.Contenido VarC = new Contenedor.Contenido();
        }
    }
    public class Contenedor
    {
        void Uso()
        {
            Contenido C = new Contenido();
        }

        public class Contenido { }
    }
}
