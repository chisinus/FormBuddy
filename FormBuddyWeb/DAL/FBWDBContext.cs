using FormBuddyWeb.BusinessObjects;
using System.Data.Entity;

namespace FormBuddyWeb.DAL
{
    public class FBWDBContext : DbContext
    {
        public FBWDBContext() : base("name=FormBuddyWebConnection") { Database.SetInitializer<FBWDBContext>(null); }

        public DbSet<tblDict_SecurityQuestion> tblDict_SecurityQuestion { get; set; }
        public DbSet<tblUser> tblUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}