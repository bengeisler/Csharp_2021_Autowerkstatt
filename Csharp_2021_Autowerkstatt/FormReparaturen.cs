﻿using System;
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
	public partial class FormReparaturen : Form
	{
		// Context-Objekt zum Zugriff auf die Datenbank erstellen
		AutowerkstattContext ctx = new AutowerkstattContext();
		public FormReparaturen()
		{
			InitializeComponent();
		}

		private void FormReparaturen_Load(object sender, EventArgs e)
		{
			// Tabelle "Reparaturen" aus der Datenbank einlesen und
			// an die Datenquelle des DataGridViews übergeben
			reparaturBindingSource.DataSource = ctx.Reparaturs.ToList();

			// Tabelle "Fahrzeuge" aus der Datenbank einlesen und an 
			// die Datenquelle der ComboBox übergeben
			fahrzeugBindingSource.DataSource = ctx.Fahrzeugs.ToList();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Ausgewählte Fahrzeugnummer auslesen
			string kennzeichen = Convert.ToString(comboBox1.SelectedValue);

			// Fahrzeuge filtern
			reparaturBindingSource.DataSource = ctx.Reparaturs
				.Where(r => r.Fahrzeug.Kennzeichen == kennzeichen)
				.ToList();

			// Filteranzeige aktualisieren
			lblFilteranzeige.Text =
				"Reparaturen von Fahrzeug - " +
				comboBox1.Text + " -";
		}

		private void BtnAlleAnzeigen_Click(object sender, EventArgs e)
		{
			// Alle Reparaturen aus der Datenbank auslesen und anzeigen
			reparaturBindingSource.DataSource = ctx.Reparaturs.ToList();

			// Filteranzeige aktualisieren
			lblFilteranzeige.Text = "Alle Reparaturen";
		}
	}
}
