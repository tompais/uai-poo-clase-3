namespace Ejercicios_Clase_3.Ej0010.Clases
{
    public class AlmacenaString
    {
        private readonly string[] ArrString = new string[10];
        public string this[int i]
        {
            get => ArrString[i]; set => ArrString[i] = value;
        }
    }
}
