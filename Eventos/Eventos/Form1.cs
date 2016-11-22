using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public BibliotecaEventos.Cuenta cuenta;

        public Form1()
        {
            InitializeComponent();
            cuenta = new BibliotecaEventos.Cuenta();
            cuenta.saldoNegativo+=this.mostarSaldoNegativoEnLaCuenta;
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            cuenta.sacarDinero(1000);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("textBox1");
        }
        private void textBox1_KeyPress1(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox1");
        }
        private void textBox1_KeyPress2(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox1");
        }
        private void textBox1_mio(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("mio");
        }
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox3");
        }
        private void textBox2_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox4");
        }
        private void textBox2_mio1(object sender, KeyPressEventArgs e)
        {
           
        }

        public void mostarSaldoNegativoEnLaCuenta(float dinero)
        {
            MessageBox.Show(dinero.ToString());
        }

    }
}
