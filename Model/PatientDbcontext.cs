using DentalPractice.Model;
using System.Data.Entity;
using System.Collections.Generic;

namespace DentalPractice.Model
{
    public class PatientDbcontext : DbContext
    {
        public DbSet<Patients> Patients { get; set; }
        public DbSet<PracticeStaff> PracticeStaff { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<DentalServices> DentalServices { get; set; }
        public DbSet<StaffStatus> StaffStatus { get; set; }

    }

    //public class StaffDbContext : DbContext
    //{
    //}

    //public class UserDbContext : DbContext
    //{
    //}
    //public class DentalServiceDbContext : DbContext
    //{
    //}

    //public class StaffStatusDbContext : DbContext
    //{
    //}


}
