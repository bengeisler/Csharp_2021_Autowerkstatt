using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_Autowerkstatt
{
	public partial class FormFahrzeuge : Form
	{
		// Globale Eigenschaft zum Datenaustausch mit dem anderen Formular
		public Fahrzeug FahrzeugInBearbeitung;
		public FormFahrzeuge()
		{
			InitializeComponent();
		}

		private void BtnSpeichern_Click(object sender, EventArgs e)
		{
			try
			{
				// Ungültige Benutzereingaben abfangen
				if (txtHalter.Text == "")
					throw new ArgumentException("Bitte Halter eingeben.");
				if (txtKennzeichen.Text == "")
					throw new ArgumentException("Bitte Kennzeichen eingeben.");
				if (txtMarke.Text == "")
					throw new ArgumentException("Bitte Marke eingeben.");
				if (txtModell.Text == "")
					throw new ArgumentException("Bitte Modell eingeben.");
				if (txtOrt.Text == "")
					throw new ArgumentException("Bitte Ort eingeben.");

				// Eigenschaften des Fahrzeugs in Bearbeitung zuweisen
				FahrzeugInBearbeitung.Halter = txtHalter.Text;
				FahrzeugInBearbeitung.Kennzeichen = txtKennzeichen.Text;
				FahrzeugInBearbeitung.Marke = txtMarke.Text;
				FahrzeugInBearbeitung.Modell = txtModell.Text;
				FahrzeugInBearbeitung.Ort = txtOrt.Text;
				// Fahrzeug-Nr wird nicht zugewiesen! Die Fahrzeugnummer ist der 
				// Primärschlüssel in der Datenbank und wird beim Hinzufügen
				// automatisch von der Datenbank vergeben

				// Rückgabe des Formulars setzen
				DialogResult = DialogResult.OK;

				// Formular schließen
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void BtnAbbrechen_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormFahrzeuge_Load(object sender, EventArgs e)
		{
			// Eigenschaften des übergebenen Fahrzeugs anzeigen
			lblNr.Text = FahrzeugInBearbeitung.Nr.ToString();
			txtHalter.Text = FahrzeugInBearbeitung.Halter;
			txtKennzeichen.Text = FahrzeugInBearbeitung.Kennzeichen;
			txtMarke.Text = FahrzeugInBearbeitung.Marke;
			txtModell.Text = FahrzeugInBearbeitung.Modell;
			txtOrt.Text = FahrzeugInBearbeitung.Ort;
		}
	}
}
