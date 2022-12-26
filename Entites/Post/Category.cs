using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Category : BaseEntity
    {
        public string  Name{ get; set; }
        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public ICollection<Category> ChaildCategoreis { get; set; }
        public ICollection<Post> Posts{ get; set; }

    }
}
