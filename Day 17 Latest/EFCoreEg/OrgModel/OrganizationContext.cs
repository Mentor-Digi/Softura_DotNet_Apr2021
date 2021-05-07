using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCoreEg.OrgModel
{
    public partial class OrganizationContext : DbContext
    {
        public OrganizationContext()
        {
        }

        public OrganizationContext(DbContextOptions<OrganizationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ajaxproduct> Ajaxproducts { get; set; }
        public virtual DbSet<AspNetSqlCacheTablesForChangeNotification> AspNetSqlCacheTablesForChangeNotifications { get; set; }
        public virtual DbSet<Cust> Custs { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer1> Customers1 { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EmpApi> EmpApis { get; set; }
        public virtual DbSet<Empgrid> Empgrids { get; set; }
        public virtual DbSet<Empl> Empls { get; set; }
        public virtual DbSet<Employeenew> Employeenews { get; set; }
        public virtual DbSet<Empstatus> Empstatuses { get; set; }
        public virtual DbSet<Empvalid> Empvalids { get; set; }
        public virtual DbSet<Exemp> Exemps { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Prbackup> Prbackups { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product1> Products1 { get; set; }
        public virtual DbSet<ProductNiit> ProductNiits { get; set; }
        public virtual DbSet<RankDemo> RankDemos { get; set; }
        public virtual DbSet<Sample> Samples { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student1> Students1 { get; set; }
        public virtual DbSet<StudentAddress> StudentAddresses { get; set; }
        public virtual DbSet<TblDepartment1> TblDepartment1s { get; set; }
        public virtual DbSet<TblDept> TblDepts { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblEmployee1> TblEmployee1s { get; set; }
        public virtual DbSet<TblRecord> TblRecords { get; set; }
        public virtual DbSet<Tbldepartment> Tbldepartments { get; set; }
        public virtual DbSet<Tblemp> Tblemps { get; set; }
        public virtual DbSet<Tblempl> Tblempls { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Organization;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Ajaxproduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__ajaxprod__C57059382B4BDF98");

                entity.ToTable("ajaxproduct");

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.Cid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<AspNetSqlCacheTablesForChangeNotification>(entity =>
            {
                entity.HasKey(e => e.TableName)
                    .HasName("PK__AspNet_S__93F7AC6927057C20");

                entity.ToTable("AspNet_SqlCacheTablesForChangeNotification");

                entity.Property(e => e.TableName).HasColumnName("tableName");

                entity.Property(e => e.ChangeId).HasColumnName("changeId");

                entity.Property(e => e.NotificationCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("notificationCreated")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Cust>(entity =>
            {
                entity.ToTable("Cust");

                entity.Property(e => e.CustId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsMember)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer");

                entity.Property(e => e.Branch)
                    .HasMaxLength(30)
                    .HasColumnName("branch");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CustomerId).ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("msg");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer1>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_dbo.Customers");

                entity.ToTable("Customers");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Msg).HasColumnName("msg");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Deptid)
                    .HasName("PK_dbo.Departments");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Deptname).HasColumnName("deptname");
            });

            modelBuilder.Entity<EmpApi>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK_dbo.EmpAPI");

                entity.ToTable("EmpAPI");

                entity.Property(e => e.Eid).HasColumnName("eid");
            });

            modelBuilder.Entity<Empgrid>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("empgrid");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .HasColumnName("designation");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Empl>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK__empl__AF4CE865C4931D2C");

                entity.ToTable("empl");

                entity.Property(e => e.Empid)
                    .ValueGeneratedNever()
                    .HasColumnName("empid");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Newcity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("newcity");
            });

            modelBuilder.Entity<Employeenew>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("Employeenew");

                entity.Property(e => e.Branch)
                    .HasMaxLength(30)
                    .HasColumnName("branch");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Empstatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("empstatus");

                entity.Property(e => e.Estatus)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("estatus");
            });

            modelBuilder.Entity<Empvalid>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empvalid__D9509F6DF5B3E511");

                entity.ToTable("empvalid");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .HasColumnName("email");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .HasColumnName("ename");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(10)
                    .HasColumnName("pwd");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Exemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exemp");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Empname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("empname");
            });

            modelBuilder.Entity<Friend>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("PK__friends__D9908D64492F619C");

                entity.ToTable("friends");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fname");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mobile");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.RollNo)
                    .HasName("PK__Images__28B564052974BF64");

                entity.Property(e => e.RollNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Roll_no");

                entity.Property(e => e.Img).HasColumnName("img");

                entity.Property(e => e.ImgDate)
                    .HasColumnType("datetime")
                    .HasColumnName("img_date");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Prbackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prbackup");

                entity.Property(e => e.Pid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Product1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("products");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<ProductNiit>(entity =>
            {
                entity.HasKey(e => e.Prid);

                entity.ToTable("ProductNiit");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .HasColumnName("category");

                entity.Property(e => e.Dop)
                    .HasColumnType("date")
                    .HasColumnName("dop");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Prname).HasMaxLength(25);

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<RankDemo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rank_demo");

                entity.Property(e => e.V)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("v");
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sample");

                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sid).HasColumnName("SID");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId).ValueGeneratedNever();

                entity.Property(e => e.StudentName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.StudentAddress)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StudentAddressId)
                    .HasConstraintName("FK__Student__Student__5441852A");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Student__Teacher__534D60F1");
            });

            modelBuilder.Entity<Student1>(entity =>
            {
                entity.HasKey(e => e.Stid)
                    .HasName("PK__students__312D1FC774174E83");

                entity.ToTable("students");

                entity.Property(e => e.Stid)
                    .ValueGeneratedNever()
                    .HasColumnName("stid");

                entity.Property(e => e.Avg).HasColumnName("avg");

                entity.Property(e => e.Engmark).HasColumnName("engmark");

                entity.Property(e => e.Mathsmark).HasColumnName("mathsmark");

                entity.Property(e => e.Scimark).HasColumnName("scimark");

                entity.Property(e => e.Stname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stname");
            });

            modelBuilder.Entity<StudentAddress>(entity =>
            {
                entity.ToTable("StudentAddress");

                entity.Property(e => e.StudentAddressId).ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDepartment1>(entity =>
            {
                entity.HasKey(e => e.Deptid);

                entity.ToTable("tblDepartment1");

                entity.Property(e => e.Deptid).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDept>(entity =>
            {
                entity.HasKey(e => e.Did);

                entity.ToTable("tblDept");

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Dname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dname");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__tblEmplo__D9509F6D438B9770");

                entity.ToTable("tblEmployee");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Sal).HasColumnName("sal");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK__tblEmploy__depti__173876EA");
            });

            modelBuilder.Entity<TblEmployee1>(entity =>
            {
                entity.HasKey(e => e.Empid);

                entity.ToTable("tblEmployee1");

                entity.Property(e => e.Empid).ValueGeneratedNever();

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("date")
                    .HasColumnName("Joining_Date");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRecord>(entity =>
            {
                entity.ToTable("tbl_Record");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbldepartment>(entity =>
            {
                entity.HasKey(e => e.Deptid)
                    .HasName("PK__tbldepar__BE2C1AEE38622143");

                entity.ToTable("tbldepartment");

                entity.Property(e => e.Deptid)
                    .ValueGeneratedNever()
                    .HasColumnName("deptid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Dname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dname");
            });

            modelBuilder.Entity<Tblemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblemp");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("doj");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Tblempl>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("tblempl");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.Property(e => e.TeacherId).ValueGeneratedNever();

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
