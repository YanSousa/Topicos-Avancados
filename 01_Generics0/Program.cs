using _01_Generics.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Generics0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro() { Marca = "FIAT", Modelo = "UNO" };
            Casa casa = new Casa() { Cidade = "Brasília", Endereco = "QSQ 400" };
            Usuario usuario = new Usuario() { Name = "Maria", Email = "maria@gmail.com" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro2:" + carro2.Marca + " - " + carro2.Modelo);

            Console.WriteLine("Casa2:" + casa2.Cidade + " - " + casa2.Endereco);

            Console.WriteLine("Usuario2:" + usuario2.Name + " - " + usuario2.Email);

            Console.ReadKey();


        }
    }
}
