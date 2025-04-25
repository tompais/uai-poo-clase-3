namespace Ejercicios_Clase_3.Ej0006.Clases
{
    public class Cliente2
    {
        string Vnombre = "";
        string Vapellido = "";

        public string Nombre
        {
            get
            {
                return Vnombre;
            }

            set
            {
                Vnombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return Vapellido;
            }

            set
            {
                Vapellido = value;
            }
        }
    }
}
