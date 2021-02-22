
namespace Csharp_2021_Autowerkstatt
{
	partial class FormFahrzeuge
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
			this.BtnAbbrechen = new System.Windows.Forms.Button();
			this.BtnSpeichern = new System.Windows.Forms.Button();
			this.txtMarke = new System.Windows.Forms.TextBox();
			this.txtModell = new System.Windows.Forms.TextBox();
			this.txtHalter = new System.Windows.Forms.TextBox();
			this.txtOrt = new System.Windows.Forms.TextBox();
			this.txtKennzeichen = new System.Windows.Forms.TextBox();
			this.lblNr = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnAbbrechen
			// 
			this.BtnAbbrechen.AutoSize = true;
			this.BtnAbbrechen.Location = new System.Drawing.Point(186, 178);
			this.BtnAbbrechen.Margin = new System.Windows.Forms.Padding(2);
			this.BtnAbbrechen.Name = "BtnAbbrechen";
			this.BtnAbbrechen.Size = new System.Drawing.Size(69, 23);
			this.BtnAbbrechen.TabIndex = 27;
			this.BtnAbbrechen.Text = "Abbrechen";
			this.BtnAbbrechen.UseVisualStyleBackColor = true;
			// 
			// BtnSpeichern
			// 
			this.BtnSpeichern.AutoSize = true;
			this.BtnSpeichern.Location = new System.Drawing.Point(15, 178);
			this.BtnSpeichern.Margin = new System.Windows.Forms.Padding(2);
			this.BtnSpeichern.Name = "BtnSpeichern";
			this.BtnSpeichern.Size = new System.Drawing.Size(65, 23);
			this.BtnSpeichern.TabIndex = 26;
			this.BtnSpeichern.Text = "Speichern";
			this.BtnSpeichern.UseVisualStyleBackColor = true;
			this.BtnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
			// 
			// txtMarke
			// 
			this.txtMarke.Location = new System.Drawing.Point(101, 59);
			this.txtMarke.Margin = new System.Windows.Forms.Padding(2);
			this.txtMarke.Name = "txtMarke";
			this.txtMarke.Size = new System.Drawing.Size(151, 20);
			this.txtMarke.TabIndex = 25;
			// 
			// txtModell
			// 
			this.txtModell.Location = new System.Drawing.Point(101, 83);
			this.txtModell.Margin = new System.Windows.Forms.Padding(2);
			this.txtModell.Name = "txtModell";
			this.txtModell.Size = new System.Drawing.Size(151, 20);
			this.txtModell.TabIndex = 24;
			// 
			// txtHalter
			// 
			this.txtHalter.Location = new System.Drawing.Point(101, 107);
			this.txtHalter.Margin = new System.Windows.Forms.Padding(2);
			this.txtHalter.Name = "txtHalter";
			this.txtHalter.Size = new System.Drawing.Size(151, 20);
			this.txtHalter.TabIndex = 23;
			// 
			// txtOrt
			// 
			this.txtOrt.Location = new System.Drawing.Point(101, 132);
			this.txtOrt.Margin = new System.Windows.Forms.Padding(2);
			this.txtOrt.Name = "txtOrt";
			this.txtOrt.Size = new System.Drawing.Size(151, 20);
			this.txtOrt.TabIndex = 22;
			// 
			// txtKennzeichen
			// 
			this.txtKennzeichen.Location = new System.Drawing.Point(101, 32);
			this.txtKennzeichen.Margin = new System.Windows.Forms.Padding(2);
			this.txtKennzeichen.Name = "txtKennzeichen";
			this.txtKennzeichen.Size = new System.Drawing.Size(151, 20);
			this.txtKennzeichen.TabIndex = 21;
			// 
			// lblNr
			// 
			this.lblNr.AutoSize = true;
			this.lblNr.Location = new System.Drawing.Point(99, 12);
			this.lblNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNr.Name = "lblNr";
			this.lblNr.Size = new System.Drawing.Size(21, 13);
			this.lblNr.TabIndex = 20;
			this.lblNr.Text = "Nr:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 37);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Kennzeichen:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 61);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Marke:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 86);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Modell:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 110);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Halter:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 134);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Ort:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Nr:";
			// 
			// FormFahrzeuge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 214);
			this.Controls.Add(this.BtnAbbrechen);
			this.Controls.Add(this.BtnSpeichern);
			this.Controls.Add(this.txtMarke);
			this.Controls.Add(this.txtModell);
			this.Controls.Add(this.txtHalter);
			this.Controls.Add(this.txtOrt);
			this.Controls.Add(this.txtKennzeichen);
			this.Controls.Add(this.lblNr);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormFahrzeuge";
			this.Text = "FormFahrzeuge";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnAbbrechen;
		private System.Windows.Forms.Button BtnSpeichern;
		private System.Windows.Forms.TextBox txtMarke;
		private System.Windows.Forms.TextBox txtModell;
		private System.Windows.Forms.TextBox txtHalter;
		private System.Windows.Forms.TextBox txtOrt;
		private System.Windows.Forms.TextBox txtKennzeichen;
		private System.Windows.Forms.Label lblNr;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}