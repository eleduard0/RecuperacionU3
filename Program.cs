using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace RecuperacionU3
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            Console.WriteLine("¿Cuantos autos deseas agregar?");
            int total = int.Parse(Console.ReadLine());

            for (int i = 0; i < total; i++)
            {
                Console.Write("Ingresa la marca: ");
                string marca = Console.ReadLine();
                Console.Write("Ingresa el modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Ingresa el año de lanzamiento: ");
                int año = int.Parse(Console.ReadLine());
                Carro carro = new Carro();
                carro.Marca = marca;
                carro.Modelo = modelo;
                carro.Año = año;

                lista.Insertar(carro);
            }
            /*lista.Ordenar();*/
            Console.WriteLine("\n======= Lista de Autos disponibles =======");
            lista.Imprimir();
            Console.WriteLine("==========================================");

            Console.Write("¿Que marca quieres buscar? ");
            string buscar = Console.ReadLine();
            Console.WriteLine($"\n======Los autos de la marca {buscar} son:===========");
            lista.Buscar(buscar);
        }
    }
}