using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public delegate void BancoCuenta(int NroCuenta);

    public class Banco
    {
        public int nroCuenta;
        public event BancoCuenta Cuenta;

        public void ObtenerCuenta(int cuenta)
        {
            if (cuenta < 100000)
            {
                this.Cuenta(cuenta);
            }
        }

    }
}
