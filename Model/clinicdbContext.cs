using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClinicWeb.Model
{
    public partial class ClinicDbContext : DbContext
    {
        public ClinicDbContext()
        {
        }

        public ClinicDbContext(DbContextOptions<ClinicDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<BloodType> BloodType { get; set; }
        public virtual DbSet<Condition> Condition { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<MedicalTest> MedicalTest { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Prescription> Prescription { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Specializations> Specializations { get; set; }
        public virtual DbSet<WorksAt> WorksAt { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=team5med-db.mysql.database.azure.com; Port=3306; Database=clinicdb; Uid=Team5DBAdmin@team5med-db; Pwd=Clinic123; SslMode=Preferred;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.HasIndex(e => e.PersonId)
                    .HasName("person_fk_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("username_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PersonId)
                    .HasColumnName("person_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("account_person_fk");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.HasIndex(e => new { e.StreetAddress, e.State, e.City, e.PostalCode })
                    .HasName("unique_record")
                    .IsUnique();

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasColumnType("int(11)");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.StreetAddress)
                    .IsRequired()
                    .HasColumnName("street_address")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("appointment");

                entity.HasIndex(e => e.DoctorId)
                    .HasName("appointment_doctor_fk_idx");

                entity.HasIndex(e => e.OfficeId)
                    .HasName("office_fk_idx");

                entity.HasIndex(e => e.PatientId)
                    .HasName("patient_fk_idx");

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("appointment_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.CancelReason)
                    .HasColumnName("cancel_reason")
                    .HasColumnType("text");

                entity.Property(e => e.Canceled)
                    .HasColumnName("canceled")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("doctor_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("time");

                entity.Property(e => e.OfficeId)
                    .HasColumnName("office_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patient_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reasons)
                    .IsRequired()
                    .HasColumnName("reasons")
                    .HasColumnType("text");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("time");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("appointment_doctor_fk");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("appointment_office_fk");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("appointment_patient_fk");
            });

            modelBuilder.Entity<BloodType>(entity =>
            {
                entity.ToTable("blood_type");

                entity.HasIndex(e => e.Name)
                    .HasName("name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.BloodTypeId)
                    .HasColumnName("blood_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.ToTable("condition");

                entity.Property(e => e.ConditionId)
                    .HasColumnName("condition_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConditionDescription)
                    .HasColumnName("condition_description")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.ConditionName)
                    .HasColumnName("condition_name")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.ToTable("diagnosis");

                entity.HasIndex(e => e.ConditionId)
                    .HasName("diagnose_condition_fk_idx");

                entity.HasIndex(e => e.DoctorId)
                    .HasName("diagnose_doctor_fk_idx");

                entity.HasIndex(e => new { e.PatientId, e.ConditionId })
                    .HasName("diagnose_unique_idx")
                    .IsUnique();

                entity.Property(e => e.DiagnosisId)
                    .HasColumnName("diagnosis_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConditionId)
                    .HasColumnName("condition_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasColumnName("details")
                    .HasColumnType("text");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("doctor_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patient_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.Diagnosis)
                    .HasForeignKey(d => d.ConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("diagnose_condition_fk");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Diagnosis)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("diagnose_doctor_fk");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Diagnosis)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("diagnose_patient_fk");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("doctor");

                entity.HasIndex(e => e.PersonId)
                    .HasName("person_id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SpecializationId)
                    .HasName("doctor_specialization_fk_idx");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("doctor_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PersonId)
                    .HasColumnName("person_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpecializationId)
                    .HasColumnName("specialization_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.Doctor)
                    .HasForeignKey<Doctor>(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctor_person_fk");

                entity.HasOne(d => d.Specialization)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.SpecializationId)
                    .HasConstraintName("doctor_specialization_fk");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.ToTable("insurance");

                entity.HasIndex(e => e.PolicyHolderId)
                    .HasName("insurance_policy_holder_fk");

                entity.HasIndex(e => e.PolicyNo)
                    .HasName("policy_no_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.InsuranceId)
                    .HasColumnName("insurance_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CompanyPhone)
                    .HasColumnName("company_phone")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("effective_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GroupNo)
                    .HasColumnName("group_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PolicyHolderId)
                    .HasColumnName("policy_holder_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PolicyNo)
                    .HasColumnName("policy_no")
                    .HasColumnType("varchar(15)");

                entity.HasOne(d => d.PolicyHolder)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.PolicyHolderId)
                    .HasConstraintName("insurance_policy_holder_fk");
            });

            modelBuilder.Entity<MedicalTest>(entity =>
            {
                entity.ToTable("medical_test");

                entity.HasIndex(e => e.PatientId)
                    .HasName("medical_test_patient_fk_idx");

                entity.Property(e => e.MedicalTestId)
                    .HasColumnName("medical_test_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasColumnName("details")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patient_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnName("result")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.MedicalTest)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("medical_test_patient_fk");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.ToTable("office");

                entity.HasIndex(e => e.AddressId)
                    .HasName("office_address_fk");

                entity.Property(e => e.OfficeId)
                    .HasColumnName("office_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Office)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("office_address_fk");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.OfficeId)
                    .HasName("order_office_fk");

                entity.HasIndex(e => e.PrescriptionId)
                    .HasName("order_prescription_fk");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateArrived)
                    .HasColumnName("date_arrived")
                    .HasColumnType("datetime");

                entity.Property(e => e.OfficeId)
                    .HasColumnName("office_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrescriptionId)
                    .HasColumnName("prescription_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_office_fk");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.PrescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_prescription_fk");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("patient");

                entity.HasIndex(e => e.BloodTypeId)
                    .HasName("patient_blood_type_fk_idx");

                entity.HasIndex(e => e.InsuranceId)
                    .HasName("patient_insurance_fk_idx");

                entity.HasIndex(e => e.PersonId)
                    .HasName("person_id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PrimaryOfficeId)
                    .HasName("patient_office_fk_idx");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patient_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BloodTypeId)
                    .HasColumnName("blood_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsuranceId)
                    .HasColumnName("insurance_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("person_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrimaryOfficeId)
                    .HasColumnName("primary_office_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.BloodType)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.BloodTypeId)
                    .HasConstraintName("patient_blood_type_fk");

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.InsuranceId)
                    .HasConstraintName("patient_insurance_fk");

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.Patient)
                    .HasForeignKey<Patient>(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patient_person_fk");

                entity.HasOne(d => d.PrimaryOffice)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.PrimaryOfficeId)
                    .HasConstraintName("patient_office_fk");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.HasIndex(e => e.AddressId)
                    .HasName("person_address_fk");

                entity.Property(e => e.PersonId)
                    .HasColumnName("person_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("person_address_fk");
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.ToTable("prescription");

                entity.HasIndex(e => e.DoctorId)
                    .HasName("doctor_fk_idx");

                entity.HasIndex(e => e.PatientId)
                    .HasName("patient_fk_idx");

                entity.Property(e => e.PrescriptionId)
                    .HasColumnName("prescription_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("doctor_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dosage)
                    .HasColumnName("dosage")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Instructions)
                    .IsRequired()
                    .HasColumnName("instructions")
                    .HasColumnType("text");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patient_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasColumnName("product")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Refill)
                    .HasColumnName("refill")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Prescription)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prescription_doctor_fk");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Prescription)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prescription_patient_fk");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("schedule");

                entity.HasIndex(e => e.DoctorId)
                    .HasName("schedule_doctor_fk_idx");

                entity.HasIndex(e => e.OfficeId)
                    .HasName("schedule_office_fk_idx");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("schedule_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("doctor_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OfficeId)
                    .HasColumnName("office_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("schedule_doctor_fk");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("schedule_office_fk");
            });

            modelBuilder.Entity<Specializations>(entity =>
            {
                entity.HasKey(e => e.SpecializationId)
                    .HasName("PRIMARY");

                entity.ToTable("specializations");

                entity.HasIndex(e => e.Name)
                    .HasName("name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.SpecializationId)
                    .HasColumnName("specialization_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WorksAt>(entity =>
            {
                entity.HasKey(e => e.DoctorOfficesId)
                    .HasName("PRIMARY");

                entity.ToTable("works_at");

                entity.HasIndex(e => e.DoctorId)
                    .HasName("doctor_offices_doctor_fk_idx");

                entity.HasIndex(e => e.OfficeId)
                    .HasName("doctor_offices_office_fk_idx");

                entity.HasIndex(e => new { e.DoctorId, e.OfficeId })
                    .HasName("doctor_offices_unique")
                    .IsUnique();

                entity.Property(e => e.DoctorOfficesId)
                    .HasColumnName("doctor_offices_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("doctor_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OfficeId)
                    .HasColumnName("office_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.WorksAt)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctor_offices_doctor_fk");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.WorksAt)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctor_offices_office_fk");
            });
        }
    }
}
