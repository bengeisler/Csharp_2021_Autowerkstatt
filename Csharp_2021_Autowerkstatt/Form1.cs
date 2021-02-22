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
	public partial class Form1 : Form
	{
		// Context-Objekt erzeugen & in globaler Variablen speichern
		// Context regelt den Zugriff auf die Datenbank - es
		// ist unsere "Datenbank-Schnittstelle"
		AutowerkstattContext ctx = new AutowerkstattContext();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Datenquelle zuweisen:
			// Fahrzeug-Tabelle ist an die fahrzeugBindingSource gebunden
			// => Hier wird jetzt die Datengrundlage für die fahrzeugBindingSource angegeben:
			//		- ctx: Zugriff auf die Datenbank
			//		- Fahrzeugs: Zugriff auf Tabelle "Fahrzeuge" der Datenbankd
			//		- ToList(): Tabelle als Liste ausgeben
			fahrzeugBindingSource.DataSource = ctx.Fahrzeugs.ToList();
		}

		private void BtnÜbernehmen_Click(object sender, EventArgs e)
		{
			// Aktuelles Fahrzeug auslesen und in Datentyp "Fahrzeug" gewandelt
			var ausgewähltesFahrzeug = fahrzeugBindingSource.Current as Fahrzeug;

			// Prüfen, ob etwas ausgewählt ist (Objekt ungleich "null")
			if (ausgewähltesFahrzeug != null)
			{
				// Ausgewähltes Fahrzeug wird in die Labels auf der linken Seite übernommen
				LblNr.Text = ausgewähltesFahrzeug.Nr.ToString();
				LblHalter.Text = ausgewähltesFahrzeug.Halter;
				LblKennzeichen.Text = ausgewähltesFahrzeug.Kennzeichen;
				LblMarke.Text = ausgewähltesFahrzeug.Marke;
				LblModell.Text = ausgewähltesFahrzeug.Modell;
				LblOrt.Text = ausgewähltesFahrzeug.Ort;
			} 
		}

		private void BtnSpeichern_Click(object sender, EventArgs e)
		{
			// try-catch immer bei Zugriff auf die Datenbank verwenden!
			try
			{
				// Neue Reparatur anlegen
				var reparatur = new Reparatur();

				// Prüfen, ob Eingabefelder gültig befüllt sind : "Schutzwall"
				if (TxtBeschreibung.Text == "")
					throw new ArgumentException("Bitte Beschreibung eingeben.");
				if (!decimal.TryParse(TxtKosten.Text, out decimal k))
					throw new ArgumentException("Bitte gültige Kosten eingeben.");
				if (k <= 0) throw new ArgumentException("Kosten > 0€ eingeben!");
				if (!int.TryParse(LblNr.Text, out int nr))
					throw new ArgumentException("Bitte gültiges Fahrzeug auswählen.");

				// Eigenschaften der Reparatur beschreiben
				reparatur.Beschreibung = TxtBeschreibung.Text;
				reparatur.Datum = datDatum.Value;
				reparatur.Kosten = k;
				reparatur.FahrzeugNr = nr;

				// Reparatur in Datenbank hinzufügen
				ctx.Reparaturs.Add(reparatur);

				// Änderungen in der Datenbank speichern
				ctx.SaveChanges();

				// Erfolgsmeldung ausgeben
				MessageBox.Show(
					"Ein neuer Reparaturdatensatz " +
					reparatur.Nr +
					" wurde für Fahrzeug " + 
					LblKennzeichen.Text +
					" angelegt.");

				// Alternative für die Ausgabe:
				//MessageBox.Show(
				//	string.Format("Ein neuer Reparaturdatensatz {0} wurde für das Fahrzeug {1} angelegt.",
				//	reparatur.Nr, LblKennzeichen.Text));

				// Eingabefelder & Fahrzeugdaten leeren
				TxtBeschreibung.Text = "";
				TxtKosten.Text = "";
				LblNr.Text = "";
				LblHalter.Text = "";
				LblKennzeichen.Text = "";
				LblMarke.Text = "";
				LblModell.Text = "";
				LblOrt.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			// Neues Fahrzeug hinzufügen (Über "+"-Button)

			// Objekt für das neue Formular erstellen
			var frmNeuesFahrzeug = new FormFahrzeuge();

			// Neues Objekt vom Typ "Fahrzeug erstellen"
			var ausgewähltesFahrzeug = new Fahrzeug();

			// Objekt "ausgewähles Fahrzeug" wird von Formular 1 => Formular 2 übergeben
			frmNeuesFahrzeug.FahrzeugInBearbeitung = ausgewähltesFahrzeug;

			// Formular zur Fahrzeugeingabe aufrufen und anzeigen
			frmNeuesFahrzeug.ShowDialog();

			// Bei Datenbankzugriff immer try-catch!
			try
			{
				if (frmNeuesFahrzeug.DialogResult == DialogResult.OK)
				{
					if (frmNeuesFahrzeug.)
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void fahrzeugDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// Bestehendes Fahrzeug bearbeiten (Über Doppelklick)
		}
	}
}
