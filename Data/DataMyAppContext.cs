using MemberApp_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MemberApp_MVC.Data
{
    public class DataMyAppContext  : DbContext
    {
        public DataMyAppContext(DbContextOptions<DataMyAppContext> options) : base(options)
        {

        }

        public DbSet<Member> MembersDb { get; set; }
       


    }
}
