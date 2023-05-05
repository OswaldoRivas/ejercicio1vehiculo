using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1vehiculo
{
    internal class Vehiculo
    {
        int id;
        string marca;
        string modelo;
        int km;
        int precio;
        int annio;

        public Vehiculo(int id, string marca, string modelo, int km, int precio, int annio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Annio = annio;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Annio { get => annio; set => annio = value; }

        public override string ToString()
        {
            return "Modelo: " + modelo + "\nMarca: " + marca + "\nAño: " + annio + "\nPrecio: " + precio + "\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo(1, "Ford", "Fiesta", 10000, 10000, 2010);
            Console.WriteLine(v1.ToString());//se usa el metodo ToString para invocar el mensaje sin escribir otra vez
            Console.ReadKey();
        }
    }
}
