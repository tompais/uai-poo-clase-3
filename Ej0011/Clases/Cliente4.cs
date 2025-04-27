namespace Ejercicios_Clase_3.Ej0011.Clases
{
    public class Cliente4
    {
        string Vnombre = "";
        public string Nombre
        {
            get { return Vnombre; }
            protected set
            {
                Vnombre = value;
            }
        }
        public string Apellido { get; set; }
    }
}
