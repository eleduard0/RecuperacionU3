using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionU3
{
    public class ListaEnlazada
    {
        public Nodo primero;
        public bool ListaVacia()
        {
            return primero == null;
        }
        public void Insertar(Carro carro)
        {
            Nodo nuevo = new Nodo(carro);
            nuevo.Siguiente = primero;
            primero = nuevo;
        }
        public void Imprimir()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista está vacia");
                return;
            }
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine($"Marca: {actual.DatosCarro.Marca}, " +
                    $"Modelo: {actual.DatosCarro.Modelo}, Año de lanzamiento: {actual.DatosCarro.Año}");
                actual = actual.Siguiente;
            }
        }
        public void Ordenar()
        {

            Nodo actual = primero;
            Nodo anterior = null;
            Nodo siguiente = primero.Siguiente;
            
            while (siguiente != null)
            {
                actual.Siguiente = siguiente.Siguiente;
                siguiente.Siguiente = actual;
                if (anterior != null)
                {
                    primero = siguiente;
                }
                else
                {
                    anterior.Siguiente= siguiente;
                }
                anterior = actual;
                actual = actual.Siguiente;
                if (actual != null)
                {
                    siguiente = actual.Siguiente;
                }

            }
        }
        public void Buscar(string marca)
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista está vacía");
                return;
            }
            Nodo actual = primero;
            int posicion = 0;
            while (actual != null)
            {
                posicion++;
                if (actual.DatosCarro.Marca == marca)
                {
                    
                    Console.WriteLine($"Modelo: {actual.DatosCarro.Modelo} Año: {actual.DatosCarro.Año} Posicion: {posicion}");
                                        
                }
                actual = actual.Siguiente;
                
            }
            
        }
    }
}
