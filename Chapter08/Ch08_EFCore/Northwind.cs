using Microsoft.EntityFrameworkCore;

namespace Packt.CS7
{
    //데이터베이스에 대한 연결을 관리한다.
    public class Northwind : DbContext
    {
        // 이 속성들은 데이터베이스의 테이블에 매핑된다.
        public DbSet<Category> Categories {get;set;}
        public DbSet<Product> Products{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ms SQL 서버용 연결 문자열
            // 윈도우에서 VS2017을 사용하는 경우, 이 코드를 사용하고
            // 아래 UseSqlite 코드를 주석 처리한다.
            //optionsBuilder.UseSqlServer(
            //    @"Data Source=(LocalDB)\mssqlLocalDB;" +
            //    "Initial Catalog=Northwind;" +
            //    "Integrated Secutity=true;"
            //);

            // SQLite 연결
            // macOS에서 VS Code을 사용하는 경우, 이 코드를 사용한다.
            optionsBuilder.UseSqlite("Filename=../Northwind.db");
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 속성 대신 Flunet API를 사용한 예
            modelBuilder.Entity<Category>()
            .Property(category => category.CategoryName)
            .IsRequired()
            .HasMaxLength(40);
        }
    }
}