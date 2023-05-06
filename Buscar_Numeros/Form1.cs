using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscar_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random Generar_Numero; // Es un objeto
        int Numero_Generado;
        int Guardar;
        int Vidas;

        private void button1_Click(object sender, EventArgs e)
        {
            Generar_Numero = new Random();
            Numero_Generado = Generar_Numero.Next(int.Parse(TB_Min.Text),int.Parse(TB_Max.Text)); //Se genera el numero. Este es un metodo
            numericUpDown1.Minimum = int.Parse(TB_Min.Text); // Se le asigna el numero menor
            numericUpDown1.Maximum = int.Parse(TB_Max.Text); // Se generan los intervalos
            //MessageBox.Show(Numero_Generado.ToString());
        }

        private void B_Comparar_Click(object sender, EventArgs e)
        {
            Vidas = int.Parse(LBL_Intento.Text);
            Comparar enviar = new Comparar();
            Guardar = enviar.comparar_num(int.Parse(numericUpDown1.Value.ToString()), Numero_Generado);

            switch (Guardar)
            {
                case 0:
                    MessageBox.Show("¡El numero que seleccionaste es el que estaba pensando!");
                    Sumar_Vidas();
                    break;

                case 1:
                    MessageBox.Show("¡El numero que digitaste es menor al que estoy pensando!");
                    Checar_Vidas();
                    break; 

                case 2:
                    MessageBox.Show("¡El numero que digitaste es mayor al que estoy pensando!");
                    Checar_Vidas();
                    break; 
            }
        }

        private void Checar_Vidas()
        {
            Vidas--;
            LBL_Intento.Text = Vidas.ToString();
            if (Vidas == 0)
            {
                MessageBox.Show("Se te han agotado los intentos");
                Application.Exit();
            }
        }

        private void Sumar_Vidas()
        {
            Vidas++;
            LBL_Intento.Text = Vidas.ToString();
            Numero_Generado = Generar_Numero.Next(int.Parse(TB_Min.Text), int.Parse(TB_Max.Text));
        }


    }
}
