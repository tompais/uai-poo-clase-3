namespace Ejercicios_Clase_3.Ej0009.Clases
{
    public class Persona
    {
        DateTime VfechaDeNacimiento;
        public DateTime FechaDeNacimiento
        {
            set => VfechaDeNacimiento = value;
        }
        public byte Edad
        {
            get
            {
                byte axo = (byte)VfechaDeNacimiento.Year;
                if (VfechaDeNacimiento.DayOfYear <= DateTime.Now.DayOfYear)
                {
                    axo--;
                }
                return (byte)(DateTime.Now.Year - axo);
            }
        }
    }
}
