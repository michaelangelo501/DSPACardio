using DSPACardio.Web.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DSPACardio.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        //Aqui se hace el mapeo 
        public  DbSet <Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {

        }
    }
}
