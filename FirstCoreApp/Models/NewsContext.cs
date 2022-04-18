using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstCoreApp.Models
{
    public class NewsContext : DbContext // الكلاس اللي مسؤول ي ماب الداتا بتاعتك للداتا بيز
    {//DbContect   - >  هوا اللي بيعمل ال كونتانر بتاع الداتا بيز
        public NewsContext(DbContextOptions<NewsContext> options)
            : base(options)
        {
        }
        // كدا بتعرف انهي كلاسات اللي هتروح للداتا بيز
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }   // DbSet -> يعني هتنشيء جدول 
        public DbSet<ContactUs> Contacts { get; set; }
        public DbSet<Teammember> Teammembers { get; set; }


    }
}
