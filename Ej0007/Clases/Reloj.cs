namespace Ejercicios_Clase_3.Ej0007.Clases
{
    class Reloj
    {
        int Vhoras = 0;
        public int Horas
        {
            get { return Vhoras; }
            set
            {
                if (value < 0 || value > 24)
                {
                    MessageBox.Show("La hora debe ser mayor a 0 y menor a 24!!!");
                }
                else
                {
                    Vhoras = value;
                }
            }
        }
    }
}
