namespace Ejercicios_Clase_3.Ej0021.Formularios
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Contenedor.Contenido VarC = new Contenedor.Contenido();
        }
    }
    public class Contenedor
    {
        void Uso()
        {
            Contenido C = new Contenido(this);
        }
        public class Contenido
        {
            Contenedor C;
            public Contenido() { }
            public Contenido(Contenedor pContenedor)
            {
                C = pContenedor;
                C.Uso();
            }
        }
    }
}
