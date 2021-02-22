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

			// Es wird ein neues Objekt vom Typ "Fahrzeug" erzeugt und der
			// Eigenschaft "FahrzeugInBearbeitung" von frmNeuesFahrzeug zugewiesen
			// (Datenübergabe von Form1 => frmNeuesFahrzeug)
			frmNeuesFahrzeug.FahrzeugInBearbeitung = new Fahrzeug();

			// Formular zur Fahrzeugeingabe aufrufen und anzeigen
			frmNeuesFahrzeug.ShowDialog();

			// Bei Datenbankzugriff immer try-catch!
			try
			{
				if (frmNeuesFahrzeug.DialogResult == DialogResult.OK)
				{
					// Das in dem Formular "Fahrzeuge" bearbeitete Fahrzeug wird der Datenbank hinzugefügt
					// - ctx: Schnittstelle zur Datenbank
					// - Fahrzeugs: Tabelle "Fahrzeuge" in der Datenbank
					// - Add: Methode zum Hinzufügen eines neuen Objekts
					// - frmNeuesFahrzeug.FahrzeugInBearbeitung:  Das Fahrzeug, das in dem zweiten Formular
					//																						angelegt wurde.
					ctx.Fahrzeugs.Add(frmNeuesFahrzeug.FahrzeugInBearbeitung);

					// Änderungen in der Datenbank speichern
					ctx.SaveChanges();

					// Anzeige aktualisieren: Datenquelle neu beschreiben
					fahrzeugBindingSource.DataSource = ctx.Fahrzeugs.ToList();
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

			// Objekt für das neue Formular erstellen
			var frmNeuesFahrzeug = new FormFahrzeuge();

			// Aktuell ausgewähltes Fahrzeug auslesen
			var ausgewähltesFahrzeug = fahrzeugBindingSource.Current as Fahrzeug;

			// Falls kein Fahrzeug ausgewählt => Abbruch
			if (ausgewähltesFahrzeug == null) return;

			// Das aktuell im DataGridView ausgewählte Fahrzeug wird der 
			// Eigenschaft "FahrzeugInBearbeitung" von frmNeuesFahrzeug zugewiesen
			// (Datenübergabe von Form1 => frmNeuesFahrzeug)
			frmNeuesFahrzeug.FahrzeugInBearbeitung = ausgewähltesFahrzeug;

			// Formular zur Fahrzeugeingabe aufrufen und anzeigen
			frmNeuesFahrzeug.ShowDialog();

			// Zugriff auf die Datenbank immer in try-catch!
			try
			{
				if (frmNeuesFahrzeug.DialogResult == DialogResult.OK)
				{
					// Änderungen in der Datenbank speichern
					ctx.SaveChanges();

					// Anzeige aktualisieren: Datenquelle neu beschreiben
					fahrzeugBindingSource.DataSource = ctx.Fahrzeugs.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void BtnReparaturen_Click(object sender, EventArgs e)
		{
			// Objekt zur Anzeige des Formulars erstellen
			var frmReparaturen = new FormReparaturen();

			// Formular anzeigen
			frmReparaturen.ShowDialog();
		}
	}
}
