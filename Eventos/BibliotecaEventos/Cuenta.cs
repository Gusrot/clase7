using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEventos
{
    public delegate void cuentaDelegado(float dinero);

    public class Cuenta
    {
        public float saldo;
        public event cuentaDelegado saldoNegativo;

        public void sacarDinero(float dinero)
        {
            if (dinero > this.saldo)//si estuvieramos en aplicacion de consola, console.write
                                    //si estuvieramos en windows form messageBox.show
                                    //si estuvieramos en una pagina web seria un alert
            {
                //Delegate.CreateDelegate(
                this.saldoNegativo(dinero);
            }

        }
    }
}
