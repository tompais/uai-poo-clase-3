namespace Ejercicios_Clase_3.Ej0029.Clases
{
    public class Persona2
    {
        string Vnombre = "";
        public string this[string pCargo]
        {
            get => $"{pCargo} {Vnombre}";
            set => Vnombre = value;
        }

        public string this[string pCargo, string pDepartamento]
        {
            get => $"Departamento: {pDepartamento} - {pCargo} {Vnombre}";
            set => Vnombre = value;
        }
    }
}
