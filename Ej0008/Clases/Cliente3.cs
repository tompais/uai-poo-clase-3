namespace Ejercicios_Clase_3.Ej0008.Clases
{
    public class Cliente3
    {
        string Vnombre = "";
        string Vapellido = "";

        public string Nombre
        {
            get => Vnombre;

            set => Vnombre = value;
        }

        public string Apellido
        {
            get => Vapellido;

            set => Vapellido = value;
        }
    }
}
