
namespace Csharp_2021_Autowerkstatt
{
	partial class FormReparaturen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.fahrzeugBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.BtnAlleAnzeigen = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.reparaturDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reparaturBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblFilteranzeige = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reparaturDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reparaturBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.fahrzeugBindingSource;
			this.comboBox1.DisplayMember = "Kennzeichen";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(253, 13);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(138, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.ValueMember = "Nr";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// fahrzeugBindingSource
			// 
			this.fahrzeugBindingSource.DataSource = typeof(Csharp_2021_Autowerkstatt.Fahrzeug);
			// 
			// BtnAlleAnzeigen
			// 
			this.BtnAlleAnzeigen.AutoSize = true;
			this.BtnAlleAnzeigen.Location = new System.Drawing.Point(11, 11);
			this.BtnAlleAnzeigen.Margin = new System.Windows.Forms.Padding(2);
			this.BtnAlleAnzeigen.Name = "BtnAlleAnzeigen";
			this.BtnAlleAnzeigen.Size = new System.Drawing.Size(81, 23);
			this.BtnAlleAnzeigen.TabIndex = 2;
			this.BtnAlleAnzeigen.Text = "Alle Anzeigen";
			this.BtnAlleAnzeigen.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(142, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Filter nach Fahrzeug:";
			// 
			// reparaturDataGridView
			// 
			this.reparaturDataGridView.AllowUserToAddRows = false;
			this.reparaturDataGridView.AllowUserToDeleteRows = false;
			this.reparaturDataGridView.AutoGenerateColumns = false;
			this.reparaturDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.reparaturDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.reparaturDataGridView.DataSource = this.reparaturBindingSource;
			this.reparaturDataGridView.Location = new System.Drawing.Point(11, 84);
			this.reparaturDataGridView.Name = "reparaturDataGridView";
			this.reparaturDataGridView.ReadOnly = true;
			this.reparaturDataGridView.Size = new System.Drawing.Size(647, 265);
			this.reparaturDataGridView.TabIndex = 5;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Datum";
			this.dataGridViewTextBoxColumn2.HeaderText = "Datum";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Beschreibung";
			this.dataGridViewTextBoxColumn3.HeaderText = "Beschreibung";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Kosten";
			this.dataGridViewTextBoxColumn4.HeaderText = "Kosten";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "FahrzeugNr";
			this.dataGridViewTextBoxColumn5.HeaderText = "FahrzeugNr";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// reparaturBindingSource
			// 
			this.reparaturBindingSource.DataSource = typeof(Csharp_2021_Autowerkstatt.Reparatur);
			// 
			// lblFilteranzeige
			// 
			this.lblFilteranzeige.AutoSize = true;
			this.lblFilteranzeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFilteranzeige.Location = new System.Drawing.Point(13, 53);
			this.lblFilteranzeige.Name = "lblFilteranzeige";
			this.lblFilteranzeige.Size = new System.Drawing.Size(66, 24);
			this.lblFilteranzeige.TabIndex = 6;
			this.lblFilteranzeige.Text = "label2";
			// 
			// FormReparaturen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 357);
			this.Controls.Add(this.lblFilteranzeige);
			this.Controls.Add(this.reparaturDataGridView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.BtnAlleAnzeigen);
			this.Name = "FormReparaturen";
			this.Text = "Reparaturen";
			this.Load += new System.EventHandler(this.FormReparaturen_Load);
			((System.ComponentModel.ISupportInitialize)(this.fahrzeugBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reparaturDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reparaturBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button BtnAlleAnzeigen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource reparaturBindingSource;
		private System.Windows.Forms.DataGridView reparaturDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Label lblFilteranzeige;
		private System.Windows.Forms.BindingSource fahrzeugBindingSource;
	}
}