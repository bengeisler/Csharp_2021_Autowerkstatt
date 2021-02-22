using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Csharp_2021_Autowerkstatt
{
	public partial class AutowerkstattContext : DbContext
	{
		public AutowerkstattContext()
				: base("name=AutowerkstattContext")
		{
		}

		public virtual DbSet<Fahrzeug> Fahrzeugs { get; set; }
		public virtual DbSet<Reparatur> Reparaturs { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Fahrzeug>()
					.Property(e => e.Kennzeichen)
					.IsUnicode(false);

			modelBuilder.Entity<Fahrzeug>()
					.Property(e => e.Marke)
					.IsUnicode(false);

			modelBuilder.Entity<Fahrzeug>()
					.Property(e => e.Modell)
					.IsUnicode(false);

			modelBuilder.Entity<Fahrzeug>()
					.Property(e => e.Halter)
					.IsUnicode(false);

			modelBuilder.Entity<Fahrzeug>()
					.Property(e => e.Ort)
					.IsUnicode(false);

			modelBuilder.Entity<Fahrzeug>()
					.HasMany(e => e.Reparaturs)
					.WithRequired(e => e.Fahrzeug)
					.WillCascadeOnDelete(false);

			modelBuilder.Entity<Reparatur>()
					.Property(e => e.Beschreibung)
					.IsUnicode(false);

			modelBuilder.Entity<Reparatur>()
					.Property(e => e.Kosten)
					.HasPrecision(10, 2);
		}
	}
}
