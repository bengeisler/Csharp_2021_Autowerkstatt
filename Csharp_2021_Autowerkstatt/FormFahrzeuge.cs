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
				if ()
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
