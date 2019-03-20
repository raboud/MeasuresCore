using Microsoft.EntityFrameworkCore;
using RandREng.MeasuresCore.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;

namespace RandREng.MeasuresCore.Data
{
    public class MeasureContext : DbContext
	{
        public DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

        public DbSet<Branch> Branches { get; set; }
		public DbSet<BusinessUnit> BusinessUnits { get; set; }
		public DbSet<Program> Programs { get; set; }
		public DbSet<Market> Markets { get; set; }

		public DbSet<Order> Orders { get; set; }
		public DbSet<Document> Documents { get; set; }
		public DbSet<Client> Customers { get; set; }
		public DbSet<Employee> Employees { get; set; }

		public DbSet<Item> Items { get; set; }
		public DbSet<ItemCosting> ItemCostings { get; set; }
		public DbSet<ItemMatCosting> ItemMatCostings { get; set; }
		public DbSet<ItemPricing> ItemPricings { get; set; }

		public DbSet<AspNetUser> AspNetUsers { get; set; }
		public DbSet<EmailTemplate> EmailTemplates { get; set; }
		public DbSet<EmailType> EmailTypes { get; set; }
		public DbSet<Program> MaterialTypes { get; set; }
		public DbSet<Measure> Measures { get; set; }
		public DbSet<MeasureEmail> MeasureEmails { get; set; }
		public DbSet<MeasureMaterial> MeasureMaterials { get; set; }
		public DbSet<MeasureRoom> MeasureRooms { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<SlotType> SlotTypes { get; set; }
		public DbSet<Tech> Teches { get; set; }
		public DbSet<Width> Widths { get; set; }
		public DbSet<Slot> Slots { get; set; }
		public DbSet<TechCapacity> TechCapacities { get; set; }
		public DbSet<CheckDetail> CheckDetails { get; set; }
		public DbSet<ClientTypeReport> ClientTypeReports { get; set; }
		public DbSet<CompanyInfo> CompanyInfoes { get; set; }
		public DbSet<DaysOfYear> DaysOfYears { get; set; }
		public DbSet<EntryMethod> EntryMethods { get; set; }
		public DbSet<JobStatus> JobStatus { get; set; }
		public DbSet<JobType> JobTypes { get; set; }
		public DbSet<NoteType> NoteTypes { get; set; }
		public DbSet<OrderCustom> OrderCustoms { get; set; }
		public DbSet<OrderNote> OrderNotes { get; set; }
		public DbSet<POPhoto> POPhotos { get; set; }
		public DbSet<ReportType> ReportTypes { get; set; }
		public DbSet<State> States { get; set; }
		public DbSet<SubContractor> SubContractors { get; set; }
		public DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
		public DbSet<Week> Weeks { get; set; }
		public DbSet<ChargeBack> ChargeBacks { get; set; }
		public DbSet<Check> Checks { get; set; }
		public DbSet<CheckCBDetail> CheckCBDetails { get; set; }
		public DbSet<MeasureCustomerStore> MeasureCustomerStores { get; set; }

		public MeasureContext(DbContextOptions<MeasureContext> options)
			: base(options)
		{ }
        public MeasureContext()
            : base()
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.ConfigureSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=CatalogDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    }
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//                optionsBuilder.UseInMemoryDatabase("tet");
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<PhoneNumberContact>().HasKey(s => new { s.PhoneNumberId, s.ContactId });
            modelBuilder.Entity<PhoneNumberClient>().HasKey(s => new { s.PhoneNumberId, s.ClientId });

			modelBuilder.Entity<DocumentOrder>().HasKey(s => new { s.OrderId, s.DocumentId });
			modelBuilder.Entity<InstallationCrewType>().HasKey(s => new { s.InstallationCrewId, s.JobTypeId });

            modelBuilder.Entity<Client>()
                .Property(p => p.Name)
                .HasComputedColumnSql("ISnull(CompanyName, LastName + ', ' + FirstName)");


			foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
			{
				relationship.DeleteBehavior = DeleteBehavior.Restrict;
			}

			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				if (!entityType.IsOwned())
				{
					modelBuilder.Entity(entityType.Name).Property<DateTime>("Created");
					modelBuilder.Entity(entityType.Name).Property<DateTime>("LastModified");
				}
			}
            base.OnModelCreating(modelBuilder);
		}

		public override int SaveChanges()
		{
			var validationErrors = ChangeTracker
				.Entries<IValidatableObject>()
				.SelectMany(e => e.Entity.Validate(null))
				.Where(r => r != ValidationResult.Success);

			if (validationErrors.Any())
			{
				// Possibly throw an exception here
			}

			return base.SaveChanges();
		}

		/*







				protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
				{
					optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = TestDB; Trusted_Connection = True;");
				}




		*/
	}

}
