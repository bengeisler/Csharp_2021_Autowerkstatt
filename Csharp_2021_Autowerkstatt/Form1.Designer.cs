
namespace Csharp_2021_Autowerkstatt
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.LblKennzeichen = new System.Windows.Forms.Label();
			this.BtnSpeichern = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.LblOrt = new System.Windows.Forms.Label();
			this.LblMarke = new System.Windows.Forms.Label();
			this.LblModell = new System.Windows.Forms.Label();
			this.LblHalter = new System.Windows.Forms.Label();
			this.LblNr = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtKosten = new System.Windows.Forms.TextBox();
			this.TxtBeschreibung = new System.Windows.Forms.TextBox();
			this.datDatum = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnReparaturen = new System.Windows.Forms.Button();
			this.BtnÜbernehmen = new System.Windows.Forms.Button();
			this.fahrzeugDataGridView = new System.Windows.Forms.DataGridView();
			this.fahrzeugBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.fahrzeugBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.fahrzeugBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fahrzeugDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingNavigator)).BeginInit();
			this.fahrzeugBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// LblKennzeichen
			// 
			this.LblKennzeichen.AutoSize = true;
			this.LblKennzeichen.Location = new System.Drawing.Point(144, 310);
			this.LblKennzeichen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblKennzeichen.Name = "LblKennzeichen";
			this.LblKennzeichen.Size = new System.Drawing.Size(21, 13);
			this.LblKennzeichen.TabIndex = 46;
			this.LblKennzeichen.Text = "Nr.";
			// 
			// BtnSpeichern
			// 
			this.BtnSpeichern.Location = new System.Drawing.Point(147, 459);
			this.BtnSpeichern.Margin = new System.Windows.Forms.Padding(2);
			this.BtnSpeichern.Name = "BtnSpeichern";
			this.BtnSpeichern.Size = new System.Drawing.Size(75, 24);
			this.BtnSpeichern.TabIndex = 45;
			this.BtnSpeichern.Text = "Speichern";
			this.BtnSpeichern.UseVisualStyleBackColor = true;
			this.BtnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(366, 221);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(29, 13);
			this.label17.TabIndex = 44;
			this.label17.Text = "Euro";
			// 
			// LblOrt
			// 
			this.LblOrt.AutoSize = true;
			this.LblOrt.Location = new System.Drawing.Point(144, 432);
			this.LblOrt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblOrt.Name = "LblOrt";
			this.LblOrt.Size = new System.Drawing.Size(21, 13);
			this.LblOrt.TabIndex = 43;
			this.LblOrt.Text = "Nr.";
			// 
			// LblMarke
			// 
			this.LblMarke.AutoSize = true;
			this.LblMarke.Location = new System.Drawing.Point(144, 334);
			this.LblMarke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblMarke.Name = "LblMarke";
			this.LblMarke.Size = new System.Drawing.Size(21, 13);
			this.LblMarke.TabIndex = 42;
			this.LblMarke.Text = "Nr.";
			// 
			// LblModell
			// 
			this.LblModell.AutoSize = true;
			this.LblModell.Location = new System.Drawing.Point(144, 359);
			this.LblModell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblModell.Name = "LblModell";
			this.LblModell.Size = new System.Drawing.Size(21, 13);
			this.LblModell.TabIndex = 41;
			this.LblModell.Text = "Nr.";
			// 
			// LblHalter
			// 
			this.LblHalter.AutoSize = true;
			this.LblHalter.Location = new System.Drawing.Point(144, 407);
			this.LblHalter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblHalter.Name = "LblHalter";
			this.LblHalter.Size = new System.Drawing.Size(21, 13);
			this.LblHalter.TabIndex = 40;
			this.LblHalter.Text = "Nr.";
			// 
			// LblNr
			// 
			this.LblNr.AutoSize = true;
			this.LblNr.Location = new System.Drawing.Point(169, 277);
			this.LblNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblNr.Name = "LblNr";
			this.LblNr.Size = new System.Drawing.Size(21, 13);
			this.LblNr.TabIndex = 39;
			this.LblNr.Text = "Nr.";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(144, 277);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(21, 13);
			this.label11.TabIndex = 38;
			this.label11.Text = "Nr.";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(43, 432);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(21, 13);
			this.label10.TabIndex = 37;
			this.label10.Text = "Ort";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(43, 407);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 13);
			this.label9.TabIndex = 36;
			this.label9.Text = "Halter";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(43, 359);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 35;
			this.label8.Text = "Modell";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(43, 334);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 34;
			this.label7.Text = "Marke";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(43, 310);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 13);
			this.label6.TabIndex = 33;
			this.label6.Text = "Kennzeichen";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 272);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 20);
			this.label5.TabIndex = 32;
			this.label5.Text = "Fahrzeug:";
			// 
			// TxtKosten
			// 
			this.TxtKosten.Location = new System.Drawing.Point(147, 217);
			this.TxtKosten.Margin = new System.Windows.Forms.Padding(2);
			this.TxtKosten.Name = "TxtKosten";
			this.TxtKosten.Size = new System.Drawing.Size(216, 20);
			this.TxtKosten.TabIndex = 31;
			// 
			// TxtBeschreibung
			// 
			this.TxtBeschreibung.Location = new System.Drawing.Point(147, 62);
			this.TxtBeschreibung.Margin = new System.Windows.Forms.Padding(2);
			this.TxtBeschreibung.Multiline = true;
			this.TxtBeschreibung.Name = "TxtBeschreibung";
			this.TxtBeschreibung.Size = new System.Drawing.Size(272, 150);
			this.TxtBeschreibung.TabIndex = 30;
			// 
			// datDatum
			// 
			this.datDatum.Location = new System.Drawing.Point(147, 39);
			this.datDatum.Margin = new System.Windows.Forms.Padding(2);
			this.datDatum.Name = "datDatum";
			this.datDatum.Size = new System.Drawing.Size(272, 20);
			this.datDatum.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(43, 221);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 28;
			this.label4.Text = "Kosten";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 65);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 27;
			this.label3.Text = "Beschreibung";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 43);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 26;
			this.label2.Text = "Datum";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(177, 20);
			this.label1.TabIndex = 25;
			this.label1.Text = "Erfassung Reparatur";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.fahrzeugBindingNavigator);
			this.groupBox1.Controls.Add(this.fahrzeugDataGridView);
			this.groupBox1.Controls.Add(this.BtnReparaturen);
			this.groupBox1.Controls.Add(this.BtnÜbernehmen);
			this.groupBox1.Location = new System.Drawing.Point(450, 9);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(794, 508);
			this.groupBox1.TabIndex = 47;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fahrzeuge";
			// 
			// BtnReparaturen
			// 
			this.BtnReparaturen.Location = new System.Drawing.Point(159, 464);
			this.BtnReparaturen.Margin = new System.Windows.Forms.Padding(2);
			this.BtnReparaturen.Name = "BtnReparaturen";
			this.BtnReparaturen.Size = new System.Drawing.Size(124, 24);
			this.BtnReparaturen.TabIndex = 25;
			this.BtnReparaturen.Text = "Reparaturen anzeigen";
			this.BtnReparaturen.UseVisualStyleBackColor = true;
			// 
			// BtnÜbernehmen
			// 
			this.BtnÜbernehmen.Location = new System.Drawing.Point(4, 464);
			this.BtnÜbernehmen.Margin = new System.Windows.Forms.Padding(2);
			this.BtnÜbernehmen.Name = "BtnÜbernehmen";
			this.BtnÜbernehmen.Size = new System.Drawing.Size(142, 24);
			this.BtnÜbernehmen.TabIndex = 24;
			this.BtnÜbernehmen.Text = "<< Fahrzeug übernehmen";
			this.BtnÜbernehmen.UseVisualStyleBackColor = true;
			this.BtnÜbernehmen.Click += new System.EventHandler(this.BtnÜbernehmen_Click);
			// 
			// fahrzeugDataGridView
			// 
			this.fahrzeugDataGridView.AllowUserToAddRows = false;
			this.fahrzeugDataGridView.AllowUserToDeleteRows = false;
			this.fahrzeugDataGridView.AutoGenerateColumns = false;
			this.fahrzeugDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.fahrzeugDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.fahrzeugDataGridView.DataSource = this.fahrzeugBindingSource;
			this.fahrzeugDataGridView.Location = new System.Drawing.Point(5, 53);
			this.fahrzeugDataGridView.Name = "fahrzeugDataGridView";
			this.fahrzeugDataGridView.ReadOnly = true;
			this.fahrzeugDataGridView.Size = new System.Drawing.Size(784, 406);
			this.fahrzeugDataGridView.TabIndex = 25;
			this.fahrzeugDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fahrzeugDataGridView_CellDoubleClick);
			// 
			// fahrzeugBindingNavigator
			// 
			this.fahrzeugBindingNavigator.AddNewItem = null;
			this.fahrzeugBindingNavigator.BindingSource = this.fahrzeugBindingSource;
			this.fahrzeugBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.fahrzeugBindingNavigator.DeleteItem = null;
			this.fahrzeugBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.fahrzeugBindingNavigatorSaveItem});
			this.fahrzeugBindingNavigator.Location = new System.Drawing.Point(2, 15);
			this.fahrzeugBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.fahrzeugBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.fahrzeugBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.fahrzeugBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.fahrzeugBindingNavigator.Name = "fahrzeugBindingNavigator";
			this.fahrzeugBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.fahrzeugBindingNavigator.Size = new System.Drawing.Size(790, 25);
			this.fahrzeugBindingNavigator.TabIndex = 49;
			this.fahrzeugBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
			this.bindingNavigatorCountItem.Text = "von {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Löschen";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// fahrzeugBindingNavigatorSaveItem
			// 
			this.fahrzeugBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.fahrzeugBindingNavigatorSaveItem.Enabled = false;
			this.fahrzeugBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fahrzeugBindingNavigatorSaveItem.Image")));
			this.fahrzeugBindingNavigatorSaveItem.Name = "fahrzeugBindingNavigatorSaveItem";
			this.fahrzeugBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.fahrzeugBindingNavigatorSaveItem.Text = "Daten speichern";
			// 
			// fahrzeugBindingSource
			// 
			this.fahrzeugBindingSource.DataSource = typeof(Csharp_2021_Autowerkstatt.Fahrzeug);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Nr";
			this.dataGridViewTextBoxColumn1.HeaderText = "Nr";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Kennzeichen";
			this.dataGridViewTextBoxColumn2.HeaderText = "Kennzeichen";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Marke";
			this.dataGridViewTextBoxColumn3.HeaderText = "Marke";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Modell";
			this.dataGridViewTextBoxColumn4.HeaderText = "Modell";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Halter";
			this.dataGridViewTextBoxColumn5.HeaderText = "Halter";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 200;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Ort";
			this.dataGridViewTextBoxColumn6.HeaderText = "Ort";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1256, 521);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LblKennzeichen);
			this.Controls.Add(this.BtnSpeichern);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.LblOrt);
			this.Controls.Add(this.LblMarke);
			this.Controls.Add(this.LblModell);
			this.Controls.Add(this.LblHalter);
			this.Controls.Add(this.LblNr);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TxtKosten);
			this.Controls.Add(this.TxtBeschreibung);
			this.Controls.Add(this.datDatum);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fahrzeugDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingNavigator)).EndInit();
			this.fahrzeugBindingNavigator.ResumeLayout(false);
			this.fahrzeugBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblKennzeichen;
		private System.Windows.Forms.Button BtnSpeichern;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label LblOrt;
		private System.Windows.Forms.Label LblMarke;
		private System.Windows.Forms.Label LblModell;
		private System.Windows.Forms.Label LblHalter;
		private System.Windows.Forms.Label LblNr;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtKosten;
		private System.Windows.Forms.TextBox TxtBeschreibung;
		private System.Windows.Forms.DateTimePicker datDatum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BtnReparaturen;
		private System.Windows.Forms.Button BtnÜbernehmen;
		private System.Windows.Forms.BindingNavigator fahrzeugBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.BindingSource fahrzeugBindingSource;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton fahrzeugBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView fahrzeugDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	}
}

