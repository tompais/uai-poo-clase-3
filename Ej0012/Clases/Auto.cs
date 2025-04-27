namespace Ejercicios_Clase_3.Ej0012.Clases
{
    public class Auto
    {
        public void Arranque() => MessageBox.Show("El auto arranca");

        public void CargaDeCombustible(int litros) => MessageBox.Show($"Se cargó {litros} litro(s) de combustible");

        public decimal Consumo(decimal km, decimal velocidad)
        {
            decimal consumo = (km / velocidad) * 10;
            Console.WriteLine($"El consumo es de {consumo} litros");
            return consumo;
        }
    }
}
