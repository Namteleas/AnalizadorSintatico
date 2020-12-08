using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace AnalizadorSintatico
{
    public partial class Form1 : Form
    {
        private string cadena;
        private List<Token> entrada;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            cadena = File.ReadAllText(openFileDialog1.FileName);
            richTextBox1.Text = cadena;
        }

        private void buttonAnalisis_Click(object sender, EventArgs e)
        {
            cadena = richTextBox1.Text;
            if (cadena == "")
                return;

            entrada = new List<Token>(Lexico.Analizar(cadena));

            dataGridViewLexico.DataSource = entrada;

            if (Sintactico.Analisis(entrada))
                labelResultado.Text = "Codigo valido";
            else
                labelResultado.Text = "Codigo invalido";
        }
    }
}
