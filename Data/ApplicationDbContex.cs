
using Common.Utilities;
using Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDbContex : DbContext
    {
        //public ApplicationDbContex(DbContextOptions options )
        //    : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyApiDb;Integrated Security=true;User id=sa;password=Esmaeil1436;");
            base.OnConfiguring(optionsBuilder);
        }


        //public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//وظیفه ساخت جدول از روی مدل ها 
        {
            base.OnModelCreating(modelBuilder);
            var entetiesAssembly = typeof(IEntity).Assembly;
            //تمامی کلاسهایی که از انتیتی ارثبری کرده باشند به کلاس دی بی کانتکس معرفی شده و به ازای هر کدام جدول ساخته میشود
            modelBuilder.RegisterAllEntities<IEntity>(entetiesAssembly);
            //بصورت اتومات فلونت ای پی ها رو رجیستر میکند به این کلاس 
            modelBuilder.RegisterEntityTypeConfiguration(entetiesAssembly);
            //کلاس هایی که آی دی انها جیو ای دی باشد ...جیو ای دی را به سکونشال جیو ای دی تبدیل میکند
            //تفاوت guid و  sequentiolGuid
            //sequentiolId : //  fragment and performance  بالاتری دارد 
            //modelBuilder.AddSequentialGuidForIdConvention();
        }
    }
}
