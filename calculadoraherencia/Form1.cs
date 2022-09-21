using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraherencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suma suma = new Suma();
            //metodo que resive parametro
            textBox3.Text = suma.operar(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();

            //metodo sobrecarga 
            suma.Valor11 = double.Parse(textBox1.Text);
            suma.Valor22= double.Parse(textBox2.Text);

            textBox3.Text = suma.operar().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //creasopn del objeto
            Restar restar = new Restar();
            //llamada del metodo en la clase
            textBox3.Text = restar.operar(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();

            //sobrecarga
            restar.Valor11=double.Parse(textBox1.Text);
            restar.Valor22= double.Parse(textBox2.Text);

            textBox3.Text=restar.operar().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multiplicar multi = new Multiplicar();
            //llamada del metodo en la clase
           textBox3.Text=multi.operar(double.Parse(textBox1.Text),double.Parse(textBox2.Text)).ToString();

            //sobrecarga
           multi.Valor11=double.Parse(textBox1.Text);
            multi.Valor22= double.Parse(textBox2.Text);

            textBox3.Text=multi.operar().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dividir dividir = new Dividir();
            //llamada del metodo de clase
            textBox3.Text = dividir.Operacion(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();

            //sobrecarga
            dividir.Valor11 = double.Parse(textBox1.Text);
            dividir.Valor22= double.Parse (textBox2.Text);

            textBox3.Text = dividir.Operacion().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
    }
}
