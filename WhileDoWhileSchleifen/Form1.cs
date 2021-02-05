using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDoWhileSchleifen
{
	public partial class Form1 : Form
	{
		private readonly Random r = new Random();
		public Form1()
		{
			InitializeComponent();
		}

		private void btnWhile_Click(object sender, EventArgs e)
		{
			int summe = 25, z;	// Verkürzte Deklaration von Variablen des gleichen Datentyps
			
			// Ausgabe löschen
			lblAusgabe.Text = "";

			while (summe < 20)
			{
				// Neue Zufallszahl erzeugen
				z = r.Next(1, 7);

				// Zufallszahl zur Summe addieren
				summe += z;

				// Ausgabe
				lblAusgabe.Text += summe + "\n"; // \n = Zeilenumbruch ("new line")
			}

		}

		private void btnDoWhile_Click(object sender, EventArgs e)
		{
			int summe = 25, z; // Verkürzte Deklaration von Variablen des gleichen Datentyps

			// Ausgabe löschen
			lblAusgabe.Text = "";

			do
			{
				// Neue Zufallszahl erzeugen
				z = r.Next(1, 7);

				// Zufallszahl zur Summe addieren
				summe += z;

				// Ausgabe
				lblAusgabe.Text += summe + "\n"; // \n = Zeilenumbruch ("new line")
			} 
			while (summe < 20);

		}
	}
}
