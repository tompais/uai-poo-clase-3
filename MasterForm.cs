using Ejercicios_Clase_3.Ej0006.Formularios;
using Ejercicios_Clase_3.Ej0007.Formularios;
using Ejercicios_Clase_3.Ej0009.Formularios;
using Ejercicios_Clase_3.Ej0010.Formularios;
using Ejercicios_Clase_3.Ej0012.Formularios;
using Ejercicios_Clase_3.Ej0013.Formularios;
using Ejercicios_Clase_3.Ej0014.Formularios;
using Ejercicios_Clase_3.Ej0029.Formularios;

namespace Ejercicios_Clase_3
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            new Form8().Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            new Form11().Show();
        }
    }
}
