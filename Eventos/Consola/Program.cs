using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            banco.Cuenta += MostrarErrorCuenta;

            banco.ObtenerCuenta(1000);

            Console.ReadKey();

            string miNombre = "Gustavo";

            miNombre.MiMetodo();

            Console.ReadKey();
        }

        public static void MostrarErrorCuenta(int cuenta)
        {
            Console.WriteLine(cuenta.ToString());
        }
        /*1.Crear delegado
         *2.Crear el evento
         *3.Invoco al metodo en la clase
         *4.creo el manejador donde corresponda*/
    }
}

