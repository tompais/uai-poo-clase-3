namespace Ejercicios_Clase_3.Ej0014.Clases
{
    public class PasajePorReferencia
    {
        public void RecibeNumero(ref int i)
        {
            MessageBox.Show($"Valor del parámetro i dentro de la función: {i}");
            i = 20;
            MessageBox.Show($"Valor del parámetro i luego de asignarle 20 dentro de la función: {i}");
        }
    }
}
