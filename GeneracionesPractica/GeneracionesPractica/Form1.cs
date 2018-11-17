using System;
using System.Windows.Forms;

namespace GeneracionesPractica
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//double Numeros;
			int numero, cont;
			numero = int.Parse(textBox1.Text);
			textBox2.Text = Math.Pow(2, numero).ToString("N0");
			cont = numero;
			String espacio=null, asterisco=null;
			String[] esp = new string[numero];

			for (int i = 0; i<numero; i++)
			{
				espacio += " ";
				esp[i] = espacio;
			}
			for (int i = 0; i < numero; i++)
			{
				asterisco += "*";
				esp[i] = asterisco;
				for (int j = 0; j < i; j++)
				{
					listBox1.Text += "*";
				}

				listBox1.Text += Environment.NewLine;
			}

		}
	}
}
