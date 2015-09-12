using System.Data.Entity;

namespace FormBuddyWeb.BusinessObjects
{
    public class FBWDBContext : DbContext
    {
        public FBWDBContext() : base("name=FormBuddyWebConnection") { Database.SetInitializer<FBWDBContext>(null); }
    }
}