using Microsoft.EntityFrameworkCore;
namespace EYPractice.Model{
    public class LoginInfoContext:DbContext{
        public LoginInfoContext(DbContextOptions<LoginInfoContext> options) :base(options){

        }
        public DbSet<LoginInfo> LoginInfos {get;set;}
    }

}