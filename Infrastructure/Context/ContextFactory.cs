using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Context{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>{
        public MyContext CreateDbContext(string[] args){
            var connectionString = "Server=localhost;Port=3306;Database=MasterTasty;Uid=root;Pwd=123456";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseMySql(connectionString);
            return new MyContext(optionBuilder.Options);
        }
    }
}