using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Post : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string Descriptoin { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId{ get; set; }

        public Category Category { get; set; }
        public User Author { get; set; }
    }
    public class PostConfiguration : IEntityTypeConfiguration<Post> // IEntityTypeConfiguration برای استفاده از فلونت ای پی ای
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(x => x.Title).IsRequired();
            builder.HasOne(x => x.Category).WithMany(c=>c.Posts).HasForeignKey(p=>p.CategoryId);
        }

        
    }
}
